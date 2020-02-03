﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AWSPowerShellGenerator.Utils
{
    /// <summary>
    /// This class provides helper methods to download libraries from NuGet.
    /// </summary>
    class SdkVersionsUtils
    {
        private const string SdkLibraryPrefix = "AWSSDK.";
        private static HashSet<string> DownloadedSdkPlatforms = new HashSet<string>();

        internal static IEnumerable<string> GetDependencies(string sdkAssembliesFolder, string packageName)
        {
            if (!packageName.StartsWith(SdkLibraryPrefix))
            {
                throw new ArgumentException($"{packageName} is not an AWS SDK library");
            }

            try
            {
                var root = ReadSdkVersionFile(sdkAssembliesFolder);
                if (packageName == "AWSSDK.Core")
                {
                    return new string[0];
                }
                else
                {
                    var package = root["ServiceVersions"][packageName.Substring(SdkLibraryPrefix.Length)];
                    if (package != null)
                    {
                        var sdkDependencies = package["Dependencies"].Children()
                            .OfType<JProperty>()
                            .Select(dep => dep.Name)
                            .Except(new string[] { "Core" })
                            .ToArray();
                        return sdkDependencies;
                    }
                    else
                    {
                        throw new Exception($"Couldn't find package {packageName} in versions file");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error while reading {packageName} entry from version file", e);
            }
        }

        internal static Version GetSDKVersion(string sdkAssembliesFolder)
        {
            try
            {
                var root = ReadSdkVersionFile(sdkAssembliesFolder);
                return Version.Parse((string)root["ProductVersion"]);
            }
            catch (Exception e)
            {
                throw new Exception($"Error while reading ProductVersion from version file", e);
            }
        }

        /// <summary>
        /// Downloads the latest version of a library.
        /// </summary>
        /// <param name="baseName">Name of the NuGet package</param>
        /// <param name="sdkAssembliesFolder">Path where the library should be extracted</param>
        /// <param name="platformName">Name of the platorm, for example "net35" or "netstandard2.0'</param>
        /// <returns>A list of other SDK libraries this library depends on</returns>
        internal static void EnsureSdkLibraryIsAvailable(string packageName, string sdkAssembliesFolder, IEnumerable<string> platformNames)
        {
            Directory.CreateDirectory(sdkAssembliesFolder);

            foreach (string platformName in platformNames)
            {
                var platformPath = Path.Combine(sdkAssembliesFolder, platformName);
                Directory.CreateDirectory(platformPath);
                foreach (var fileName in new string[] { $"{packageName}.dll", $"{packageName}.xml" })
                {
                    string filePath = Path.Combine(platformPath, fileName);
                    if (!File.Exists(filePath))
                    {
                        var version = SdkVersionsUtils.GetSDKVersion(sdkAssembliesFolder);
                        DownloadSDKAssembliesAsync(platformPath, platformName, version).Wait();
                    }
                }
            }
        }

        /// <summary>
        /// Downloads the required version/platform of the SDK assemblies
        /// </summary>
        private static async Task DownloadSDKAssembliesAsync(string platformPath, string platformName, Version sdkVersion)
        {
            if (DownloadedSdkPlatforms.Add(platformPath))
            {
                var sdkUri = $"https://sdk-for-net.amazonwebservices.com/releases/aws-sdk-{platformName}-{sdkVersion}.zip";
                Console.WriteLine($"Downloading SDK at {sdkUri}");

                try
                {
                    var tempFile = Path.GetTempFileName();
                    try
                    {
                        using (var client = new HttpClient())
                        using (var fileStream = File.Create(tempFile))
                        using (var packageStream = await client.GetStreamAsync(sdkUri))
                        {
                            packageStream.CopyTo(fileStream);
                        }

                        using (var archive = ZipFile.OpenRead(tempFile))
                        {
                            foreach (var entry in archive.Entries)
                            {
                                var filePath = Path.Combine(platformPath, entry.Name);
                                //Existing files in the folder are not overwritten!
                                if (!File.Exists(filePath))
                                {
                                    entry.ExtractToFile(filePath, false);
                                }
                            }
                        }
                    }
                    finally
                    {
                        File.Delete(tempFile);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Error while downloading {sdkUri}", e);
                }
            }
        }

        private static JObject ReadSdkVersionFile(string sdkAssembliesFolder)
        {
            var versionsFilePath = Path.Combine(sdkAssembliesFolder, "..", "_sdk-versions.json");
            try
            {
                using (var jsonReader = new JsonTextReader(File.OpenText(versionsFilePath)))
                {
                    return JObject.Load(jsonReader);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error while reading from {versionsFilePath}", e);
            }
        }
    }
}
