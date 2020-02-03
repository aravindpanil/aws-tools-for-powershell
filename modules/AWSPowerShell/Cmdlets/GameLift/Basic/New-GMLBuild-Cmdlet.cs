/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.GameLift;
using Amazon.GameLift.Model;

namespace Amazon.PowerShell.Cmdlets.GML
{
    /// <summary>
    /// Creates a new Amazon GameLift build record for your game server binary files and points
    /// to the location of your game server build files in an Amazon Simple Storage Service
    /// (Amazon S3) location. 
    /// 
    ///  
    /// <para>
    /// Game server binaries must be combined into a zip file for use with Amazon GameLift.
    /// 
    /// </para><important><para>
    /// To create new builds directly from a file directory, use the AWS CLI command <b><a href="https://docs.aws.amazon.com/cli/latest/reference/gamelift/upload-build.html">upload-build</a></b>. This helper command uploads build files and creates a new build record in one
    /// step, and automatically handles the necessary permissions. 
    /// </para></important><para>
    /// The <code>CreateBuild</code> operation should be used only in the following scenarios:
    /// </para><ul><li><para>
    /// To create a new game build with build files that are in an Amazon S3 bucket under
    /// your own AWS account. To use this option, you must first give Amazon GameLift access
    /// to that Amazon S3 bucket. Then call <code>CreateBuild</code> and specify a build name,
    /// operating system, and the Amazon S3 storage location of your game build.
    /// </para></li><li><para>
    /// To upload build files directly to Amazon GameLift's Amazon S3 account. To use this
    /// option, first call <code>CreateBuild</code> and specify a build name and operating
    /// system. This action creates a new build record and returns an Amazon S3 storage location
    /// (bucket and key only) and temporary access credentials. Use the credentials to manually
    /// upload your build file to the provided storage location (see the Amazon S3 topic <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UploadingObjects.html">Uploading
    /// Objects</a>). You can upload build files to the GameLift Amazon S3 location only once.
    /// 
    /// </para></li></ul><para>
    /// If successful, this operation creates a new build record with a unique build ID and
    /// places it in <code>INITIALIZED</code> status. You can use <a>DescribeBuild</a> to
    /// check the status of your build. A build must be in <code>READY</code> status before
    /// it can be used to create fleets.
    /// </para><para><b>Learn more</b></para><para><a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">Uploading
    /// Your Game</a><a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html</a></para><para><a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html#gamelift-build-cli-uploading-create-build">
    /// Create a Build with Files in Amazon S3</a></para><para><b>Related operations</b></para><ul><li><para><a>CreateBuild</a></para></li><li><para><a>ListBuilds</a></para></li><li><para><a>DescribeBuild</a></para></li><li><para><a>UpdateBuild</a></para></li><li><para><a>DeleteBuild</a></para></li></ul>
    /// </summary>
    [Cmdlet("New", "GMLBuild", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.GameLift.Model.CreateBuildResponse")]
    [AWSCmdlet("Calls the Amazon GameLift Service CreateBuild API operation.", Operation = new[] {"CreateBuild"}, SelectReturnType = typeof(Amazon.GameLift.Model.CreateBuildResponse))]
    [AWSCmdletOutput("Amazon.GameLift.Model.CreateBuildResponse",
        "This cmdlet returns an Amazon.GameLift.Model.CreateBuildResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewGMLBuildCmdlet : AmazonGameLiftClientCmdlet, IExecutor
    {
        
        #region Parameter StorageLocation_Bucket
        /// <summary>
        /// <para>
        /// <para>An Amazon S3 bucket identifier. This is the name of the S3 bucket.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String StorageLocation_Bucket { get; set; }
        #endregion
        
        #region Parameter StorageLocation_Key
        /// <summary>
        /// <para>
        /// <para>The name of the zip file that contains the build files or script files. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String StorageLocation_Key { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>A descriptive label that is associated with a build. Build names do not need to be
        /// unique. You can use <a>UpdateBuild</a> to change this value later. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter StorageLocation_ObjectVersion
        /// <summary>
        /// <para>
        /// <para>The version of the file, if object versioning is turned on for the bucket. Amazon
        /// GameLift uses this information when retrieving files from an S3 bucket that you own.
        /// Use this parameter to specify a specific version of the file. If not set, the latest
        /// version of the file is retrieved. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String StorageLocation_ObjectVersion { get; set; }
        #endregion
        
        #region Parameter OperatingSystem
        /// <summary>
        /// <para>
        /// <para>The operating system that the game server binaries are built to run on. This value
        /// determines the type of fleet resources that you can use for this build. If your game
        /// build contains multiple executables, they all must run on the same operating system.
        /// If an operating system is not specified when creating a build, Amazon GameLift uses
        /// the default value (WINDOWS_2012). This value cannot be changed later.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.GameLift.OperatingSystem")]
        public Amazon.GameLift.OperatingSystem OperatingSystem { get; set; }
        #endregion
        
        #region Parameter StorageLocation_RoleArn
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// for an IAM role that allows Amazon GameLift to access the S3 bucket.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String StorageLocation_RoleArn { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>A list of labels to assign to the new build resource. Tags are developer-defined key-value
        /// pairs. Tagging AWS resources are useful for resource management, access management
        /// and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging AWS Resources</a> in the <i>AWS General Reference</i>. Once the resource is
        /// created, you can use <a>TagResource</a>, <a>UntagResource</a>, and <a>ListTagsForResource</a>
        /// to add, remove, and view tags. The maximum tag limit may be lower than stated. See
        /// the AWS General Reference for actual tagging limits.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.GameLift.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter Version
        /// <summary>
        /// <para>
        /// <para>Version information that is associated with a build or script. Version strings do
        /// not need to be unique. You can use <a>UpdateBuild</a> to change this value later.
        /// </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Version { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.GameLift.Model.CreateBuildResponse).
        /// Specifying the name of a property of type Amazon.GameLift.Model.CreateBuildResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Name parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Name' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Name' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Name), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-GMLBuild (CreateBuild)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.GameLift.Model.CreateBuildResponse, NewGMLBuildCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Name;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Name = this.Name;
            context.OperatingSystem = this.OperatingSystem;
            context.StorageLocation_Bucket = this.StorageLocation_Bucket;
            context.StorageLocation_Key = this.StorageLocation_Key;
            context.StorageLocation_ObjectVersion = this.StorageLocation_ObjectVersion;
            context.StorageLocation_RoleArn = this.StorageLocation_RoleArn;
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.GameLift.Model.Tag>(this.Tag);
            }
            context.Version = this.Version;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.GameLift.Model.CreateBuildRequest();
            
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            if (cmdletContext.OperatingSystem != null)
            {
                request.OperatingSystem = cmdletContext.OperatingSystem;
            }
            
             // populate StorageLocation
            var requestStorageLocationIsNull = true;
            request.StorageLocation = new Amazon.GameLift.Model.S3Location();
            System.String requestStorageLocation_storageLocation_Bucket = null;
            if (cmdletContext.StorageLocation_Bucket != null)
            {
                requestStorageLocation_storageLocation_Bucket = cmdletContext.StorageLocation_Bucket;
            }
            if (requestStorageLocation_storageLocation_Bucket != null)
            {
                request.StorageLocation.Bucket = requestStorageLocation_storageLocation_Bucket;
                requestStorageLocationIsNull = false;
            }
            System.String requestStorageLocation_storageLocation_Key = null;
            if (cmdletContext.StorageLocation_Key != null)
            {
                requestStorageLocation_storageLocation_Key = cmdletContext.StorageLocation_Key;
            }
            if (requestStorageLocation_storageLocation_Key != null)
            {
                request.StorageLocation.Key = requestStorageLocation_storageLocation_Key;
                requestStorageLocationIsNull = false;
            }
            System.String requestStorageLocation_storageLocation_ObjectVersion = null;
            if (cmdletContext.StorageLocation_ObjectVersion != null)
            {
                requestStorageLocation_storageLocation_ObjectVersion = cmdletContext.StorageLocation_ObjectVersion;
            }
            if (requestStorageLocation_storageLocation_ObjectVersion != null)
            {
                request.StorageLocation.ObjectVersion = requestStorageLocation_storageLocation_ObjectVersion;
                requestStorageLocationIsNull = false;
            }
            System.String requestStorageLocation_storageLocation_RoleArn = null;
            if (cmdletContext.StorageLocation_RoleArn != null)
            {
                requestStorageLocation_storageLocation_RoleArn = cmdletContext.StorageLocation_RoleArn;
            }
            if (requestStorageLocation_storageLocation_RoleArn != null)
            {
                request.StorageLocation.RoleArn = requestStorageLocation_storageLocation_RoleArn;
                requestStorageLocationIsNull = false;
            }
             // determine if request.StorageLocation should be set to null
            if (requestStorageLocationIsNull)
            {
                request.StorageLocation = null;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.Version != null)
            {
                request.Version = cmdletContext.Version;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.GameLift.Model.CreateBuildResponse CallAWSServiceOperation(IAmazonGameLift client, Amazon.GameLift.Model.CreateBuildRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon GameLift Service", "CreateBuild");
            try
            {
                #if DESKTOP
                return client.CreateBuild(request);
                #elif CORECLR
                return client.CreateBuildAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.String Name { get; set; }
            public Amazon.GameLift.OperatingSystem OperatingSystem { get; set; }
            public System.String StorageLocation_Bucket { get; set; }
            public System.String StorageLocation_Key { get; set; }
            public System.String StorageLocation_ObjectVersion { get; set; }
            public System.String StorageLocation_RoleArn { get; set; }
            public List<Amazon.GameLift.Model.Tag> Tag { get; set; }
            public System.String Version { get; set; }
            public System.Func<Amazon.GameLift.Model.CreateBuildResponse, NewGMLBuildCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
