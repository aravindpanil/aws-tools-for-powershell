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
using Amazon.MediaPackage;
using Amazon.MediaPackage.Model;

namespace Amazon.PowerShell.Cmdlets.EMP
{
    /// <summary>
    /// Creates a new OriginEndpoint record.
    /// </summary>
    [Cmdlet("New", "EMPOriginEndpoint", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.MediaPackage.Model.CreateOriginEndpointResponse")]
    [AWSCmdlet("Calls the AWS Elemental MediaPackage CreateOriginEndpoint API operation.", Operation = new[] {"CreateOriginEndpoint"}, SelectReturnType = typeof(Amazon.MediaPackage.Model.CreateOriginEndpointResponse))]
    [AWSCmdletOutput("Amazon.MediaPackage.Model.CreateOriginEndpointResponse",
        "This cmdlet returns an Amazon.MediaPackage.Model.CreateOriginEndpointResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewEMPOriginEndpointCmdlet : AmazonMediaPackageClientCmdlet, IExecutor
    {
        
        #region Parameter Authorization_CdnIdentifierSecret
        /// <summary>
        /// <para>
        /// The Amazon Resource Name (ARN) for
        /// the secret in Secrets Manager that your Content Distribution Network (CDN) uses for
        /// authorization to access your endpoint.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Authorization_CdnIdentifierSecret { get; set; }
        #endregion
        
        #region Parameter SpekeKeyProvider_CertificateArn
        /// <summary>
        /// <para>
        /// An Amazon Resource Name (ARN) of a Certificate
        /// Manager certificatethat MediaPackage will use for enforcing secure end-to-end datatransfer
        /// with the key provider service.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CmafPackage_Encryption_SpekeKeyProvider_CertificateArn")]
        public System.String SpekeKeyProvider_CertificateArn { get; set; }
        #endregion
        
        #region Parameter ChannelId
        /// <summary>
        /// <para>
        /// The ID of the Channel that the OriginEndpoint
        /// will be associated with.This cannot be changed after the OriginEndpoint is created.
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String ChannelId { get; set; }
        #endregion
        
        #region Parameter DashPackage
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.MediaPackage.Model.DashPackage DashPackage { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// A short text description of the OriginEndpoint.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter CmafPackage_HlsManifest
        /// <summary>
        /// <para>
        /// A list of HLS manifest configurations
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CmafPackage_HlsManifests")]
        public Amazon.MediaPackage.Model.HlsManifestCreateOrUpdateParameters[] CmafPackage_HlsManifest { get; set; }
        #endregion
        
        #region Parameter HlsPackage
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.MediaPackage.Model.HlsPackage HlsPackage { get; set; }
        #endregion
        
        #region Parameter Id
        /// <summary>
        /// <para>
        /// The ID of the OriginEndpoint.  The ID must be unique
        /// within the regionand it cannot be changed after the OriginEndpoint is created.
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String Id { get; set; }
        #endregion
        
        #region Parameter Encryption_KeyRotationIntervalSecond
        /// <summary>
        /// <para>
        /// Time (in seconds) between each
        /// encryption key rotation.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CmafPackage_Encryption_KeyRotationIntervalSeconds")]
        public System.Int32? Encryption_KeyRotationIntervalSecond { get; set; }
        #endregion
        
        #region Parameter ManifestName
        /// <summary>
        /// <para>
        /// A short string that will be used as the filename
        /// of the OriginEndpoint URL (defaults to "index").
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ManifestName { get; set; }
        #endregion
        
        #region Parameter StreamSelection_MaxVideoBitsPerSecond
        /// <summary>
        /// <para>
        /// The maximum video bitrate (bps)
        /// to include in output.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CmafPackage_StreamSelection_MaxVideoBitsPerSecond")]
        public System.Int32? StreamSelection_MaxVideoBitsPerSecond { get; set; }
        #endregion
        
        #region Parameter StreamSelection_MinVideoBitsPerSecond
        /// <summary>
        /// <para>
        /// The minimum video bitrate (bps)
        /// to include in output.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CmafPackage_StreamSelection_MinVideoBitsPerSecond")]
        public System.Int32? StreamSelection_MinVideoBitsPerSecond { get; set; }
        #endregion
        
        #region Parameter MssPackage
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.MediaPackage.Model.MssPackage MssPackage { get; set; }
        #endregion
        
        #region Parameter Origination
        /// <summary>
        /// <para>
        /// Control whether origination of video is allowed
        /// for this OriginEndpoint. If set to ALLOW, the OriginEndpointmay by requested, pursuant
        /// to any other form of access control. If set to DENY, the OriginEndpoint may not berequested.
        /// This can be helpful for Live to VOD harvesting, or for temporarily disabling origination
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.MediaPackage.Origination")]
        public Amazon.MediaPackage.Origination Origination { get; set; }
        #endregion
        
        #region Parameter SpekeKeyProvider_ResourceId
        /// <summary>
        /// <para>
        /// The resource ID to include in key requests.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CmafPackage_Encryption_SpekeKeyProvider_ResourceId")]
        public System.String SpekeKeyProvider_ResourceId { get; set; }
        #endregion
        
        #region Parameter SpekeKeyProvider_RoleArn
        /// <summary>
        /// <para>
        /// An Amazon Resource Name (ARN) of an IAM role that
        /// AWS ElementalMediaPackage will assume when accessing the key provider service.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CmafPackage_Encryption_SpekeKeyProvider_RoleArn")]
        public System.String SpekeKeyProvider_RoleArn { get; set; }
        #endregion
        
        #region Parameter Authorization_SecretsRoleArn
        /// <summary>
        /// <para>
        /// The Amazon Resource Name (ARN) for the
        /// IAM role that allows MediaPackage to communicate with AWS Secrets Manager.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Authorization_SecretsRoleArn { get; set; }
        #endregion
        
        #region Parameter CmafPackage_SegmentDurationSecond
        /// <summary>
        /// <para>
        /// Duration (in seconds) of each segment.
        /// Actual segments will berounded to the nearest multiple of the source segment duration.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CmafPackage_SegmentDurationSeconds")]
        public System.Int32? CmafPackage_SegmentDurationSecond { get; set; }
        #endregion
        
        #region Parameter CmafPackage_SegmentPrefix
        /// <summary>
        /// <para>
        /// An optional custom string that is prepended
        /// to the name of each segment. If not specified, it defaults to the ChannelId.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String CmafPackage_SegmentPrefix { get; set; }
        #endregion
        
        #region Parameter StartoverWindowSecond
        /// <summary>
        /// <para>
        /// Maximum duration (seconds) of content
        /// to retain for startover playback.If not specified, startover playback will be disabled
        /// for the OriginEndpoint.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("StartoverWindowSeconds")]
        public System.Int32? StartoverWindowSecond { get; set; }
        #endregion
        
        #region Parameter StreamSelection_StreamOrder
        /// <summary>
        /// <para>
        /// A directive that determines the order of streams
        /// in the output.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CmafPackage_StreamSelection_StreamOrder")]
        [AWSConstantClassSource("Amazon.MediaPackage.StreamOrder")]
        public Amazon.MediaPackage.StreamOrder StreamSelection_StreamOrder { get; set; }
        #endregion
        
        #region Parameter SpekeKeyProvider_SystemId
        /// <summary>
        /// <para>
        /// The system IDs to include in key requests.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CmafPackage_Encryption_SpekeKeyProvider_SystemIds")]
        public System.String[] SpekeKeyProvider_SystemId { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public System.Collections.Hashtable Tag { get; set; }
        #endregion
        
        #region Parameter TimeDelaySecond
        /// <summary>
        /// <para>
        /// Amount of delay (seconds) to enforce
        /// on the playback of live content.If not specified, there will be no time delay in effect
        /// for the OriginEndpoint.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TimeDelaySeconds")]
        public System.Int32? TimeDelaySecond { get; set; }
        #endregion
        
        #region Parameter SpekeKeyProvider_Url
        /// <summary>
        /// <para>
        /// The URL of the external key provider service.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CmafPackage_Encryption_SpekeKeyProvider_Url")]
        public System.String SpekeKeyProvider_Url { get; set; }
        #endregion
        
        #region Parameter Whitelist
        /// <summary>
        /// <para>
        /// A list of source IP CIDR blocks that will be
        /// allowed to access the OriginEndpoint.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String[] Whitelist { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.MediaPackage.Model.CreateOriginEndpointResponse).
        /// Specifying the name of a property of type Amazon.MediaPackage.Model.CreateOriginEndpointResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Id parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Id' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Id' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Id), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-EMPOriginEndpoint (CreateOriginEndpoint)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.MediaPackage.Model.CreateOriginEndpointResponse, NewEMPOriginEndpointCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Id;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Authorization_CdnIdentifierSecret = this.Authorization_CdnIdentifierSecret;
            context.Authorization_SecretsRoleArn = this.Authorization_SecretsRoleArn;
            context.ChannelId = this.ChannelId;
            #if MODULAR
            if (this.ChannelId == null && ParameterWasBound(nameof(this.ChannelId)))
            {
                WriteWarning("You are passing $null as a value for parameter ChannelId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Encryption_KeyRotationIntervalSecond = this.Encryption_KeyRotationIntervalSecond;
            context.SpekeKeyProvider_CertificateArn = this.SpekeKeyProvider_CertificateArn;
            context.SpekeKeyProvider_ResourceId = this.SpekeKeyProvider_ResourceId;
            context.SpekeKeyProvider_RoleArn = this.SpekeKeyProvider_RoleArn;
            if (this.SpekeKeyProvider_SystemId != null)
            {
                context.SpekeKeyProvider_SystemId = new List<System.String>(this.SpekeKeyProvider_SystemId);
            }
            context.SpekeKeyProvider_Url = this.SpekeKeyProvider_Url;
            if (this.CmafPackage_HlsManifest != null)
            {
                context.CmafPackage_HlsManifest = new List<Amazon.MediaPackage.Model.HlsManifestCreateOrUpdateParameters>(this.CmafPackage_HlsManifest);
            }
            context.CmafPackage_SegmentDurationSecond = this.CmafPackage_SegmentDurationSecond;
            context.CmafPackage_SegmentPrefix = this.CmafPackage_SegmentPrefix;
            context.StreamSelection_MaxVideoBitsPerSecond = this.StreamSelection_MaxVideoBitsPerSecond;
            context.StreamSelection_MinVideoBitsPerSecond = this.StreamSelection_MinVideoBitsPerSecond;
            context.StreamSelection_StreamOrder = this.StreamSelection_StreamOrder;
            context.DashPackage = this.DashPackage;
            context.Description = this.Description;
            context.HlsPackage = this.HlsPackage;
            context.Id = this.Id;
            #if MODULAR
            if (this.Id == null && ParameterWasBound(nameof(this.Id)))
            {
                WriteWarning("You are passing $null as a value for parameter Id which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.ManifestName = this.ManifestName;
            context.MssPackage = this.MssPackage;
            context.Origination = this.Origination;
            context.StartoverWindowSecond = this.StartoverWindowSecond;
            if (this.Tag != null)
            {
                context.Tag = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.Tag.Keys)
                {
                    context.Tag.Add((String)hashKey, (String)(this.Tag[hashKey]));
                }
            }
            context.TimeDelaySecond = this.TimeDelaySecond;
            if (this.Whitelist != null)
            {
                context.Whitelist = new List<System.String>(this.Whitelist);
            }
            
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
            var request = new Amazon.MediaPackage.Model.CreateOriginEndpointRequest();
            
            
             // populate Authorization
            var requestAuthorizationIsNull = true;
            request.Authorization = new Amazon.MediaPackage.Model.Authorization();
            System.String requestAuthorization_authorization_CdnIdentifierSecret = null;
            if (cmdletContext.Authorization_CdnIdentifierSecret != null)
            {
                requestAuthorization_authorization_CdnIdentifierSecret = cmdletContext.Authorization_CdnIdentifierSecret;
            }
            if (requestAuthorization_authorization_CdnIdentifierSecret != null)
            {
                request.Authorization.CdnIdentifierSecret = requestAuthorization_authorization_CdnIdentifierSecret;
                requestAuthorizationIsNull = false;
            }
            System.String requestAuthorization_authorization_SecretsRoleArn = null;
            if (cmdletContext.Authorization_SecretsRoleArn != null)
            {
                requestAuthorization_authorization_SecretsRoleArn = cmdletContext.Authorization_SecretsRoleArn;
            }
            if (requestAuthorization_authorization_SecretsRoleArn != null)
            {
                request.Authorization.SecretsRoleArn = requestAuthorization_authorization_SecretsRoleArn;
                requestAuthorizationIsNull = false;
            }
             // determine if request.Authorization should be set to null
            if (requestAuthorizationIsNull)
            {
                request.Authorization = null;
            }
            if (cmdletContext.ChannelId != null)
            {
                request.ChannelId = cmdletContext.ChannelId;
            }
            
             // populate CmafPackage
            var requestCmafPackageIsNull = true;
            request.CmafPackage = new Amazon.MediaPackage.Model.CmafPackageCreateOrUpdateParameters();
            List<Amazon.MediaPackage.Model.HlsManifestCreateOrUpdateParameters> requestCmafPackage_cmafPackage_HlsManifest = null;
            if (cmdletContext.CmafPackage_HlsManifest != null)
            {
                requestCmafPackage_cmafPackage_HlsManifest = cmdletContext.CmafPackage_HlsManifest;
            }
            if (requestCmafPackage_cmafPackage_HlsManifest != null)
            {
                request.CmafPackage.HlsManifests = requestCmafPackage_cmafPackage_HlsManifest;
                requestCmafPackageIsNull = false;
            }
            System.Int32? requestCmafPackage_cmafPackage_SegmentDurationSecond = null;
            if (cmdletContext.CmafPackage_SegmentDurationSecond != null)
            {
                requestCmafPackage_cmafPackage_SegmentDurationSecond = cmdletContext.CmafPackage_SegmentDurationSecond.Value;
            }
            if (requestCmafPackage_cmafPackage_SegmentDurationSecond != null)
            {
                request.CmafPackage.SegmentDurationSeconds = requestCmafPackage_cmafPackage_SegmentDurationSecond.Value;
                requestCmafPackageIsNull = false;
            }
            System.String requestCmafPackage_cmafPackage_SegmentPrefix = null;
            if (cmdletContext.CmafPackage_SegmentPrefix != null)
            {
                requestCmafPackage_cmafPackage_SegmentPrefix = cmdletContext.CmafPackage_SegmentPrefix;
            }
            if (requestCmafPackage_cmafPackage_SegmentPrefix != null)
            {
                request.CmafPackage.SegmentPrefix = requestCmafPackage_cmafPackage_SegmentPrefix;
                requestCmafPackageIsNull = false;
            }
            Amazon.MediaPackage.Model.CmafEncryption requestCmafPackage_cmafPackage_Encryption = null;
            
             // populate Encryption
            var requestCmafPackage_cmafPackage_EncryptionIsNull = true;
            requestCmafPackage_cmafPackage_Encryption = new Amazon.MediaPackage.Model.CmafEncryption();
            System.Int32? requestCmafPackage_cmafPackage_Encryption_encryption_KeyRotationIntervalSecond = null;
            if (cmdletContext.Encryption_KeyRotationIntervalSecond != null)
            {
                requestCmafPackage_cmafPackage_Encryption_encryption_KeyRotationIntervalSecond = cmdletContext.Encryption_KeyRotationIntervalSecond.Value;
            }
            if (requestCmafPackage_cmafPackage_Encryption_encryption_KeyRotationIntervalSecond != null)
            {
                requestCmafPackage_cmafPackage_Encryption.KeyRotationIntervalSeconds = requestCmafPackage_cmafPackage_Encryption_encryption_KeyRotationIntervalSecond.Value;
                requestCmafPackage_cmafPackage_EncryptionIsNull = false;
            }
            Amazon.MediaPackage.Model.SpekeKeyProvider requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider = null;
            
             // populate SpekeKeyProvider
            var requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProviderIsNull = true;
            requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider = new Amazon.MediaPackage.Model.SpekeKeyProvider();
            System.String requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_CertificateArn = null;
            if (cmdletContext.SpekeKeyProvider_CertificateArn != null)
            {
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_CertificateArn = cmdletContext.SpekeKeyProvider_CertificateArn;
            }
            if (requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_CertificateArn != null)
            {
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider.CertificateArn = requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_CertificateArn;
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProviderIsNull = false;
            }
            System.String requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_ResourceId = null;
            if (cmdletContext.SpekeKeyProvider_ResourceId != null)
            {
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_ResourceId = cmdletContext.SpekeKeyProvider_ResourceId;
            }
            if (requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_ResourceId != null)
            {
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider.ResourceId = requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_ResourceId;
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProviderIsNull = false;
            }
            System.String requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_RoleArn = null;
            if (cmdletContext.SpekeKeyProvider_RoleArn != null)
            {
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_RoleArn = cmdletContext.SpekeKeyProvider_RoleArn;
            }
            if (requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_RoleArn != null)
            {
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider.RoleArn = requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_RoleArn;
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProviderIsNull = false;
            }
            List<System.String> requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_SystemId = null;
            if (cmdletContext.SpekeKeyProvider_SystemId != null)
            {
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_SystemId = cmdletContext.SpekeKeyProvider_SystemId;
            }
            if (requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_SystemId != null)
            {
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider.SystemIds = requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_SystemId;
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProviderIsNull = false;
            }
            System.String requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_Url = null;
            if (cmdletContext.SpekeKeyProvider_Url != null)
            {
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_Url = cmdletContext.SpekeKeyProvider_Url;
            }
            if (requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_Url != null)
            {
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider.Url = requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider_spekeKeyProvider_Url;
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProviderIsNull = false;
            }
             // determine if requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider should be set to null
            if (requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProviderIsNull)
            {
                requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider = null;
            }
            if (requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider != null)
            {
                requestCmafPackage_cmafPackage_Encryption.SpekeKeyProvider = requestCmafPackage_cmafPackage_Encryption_cmafPackage_Encryption_SpekeKeyProvider;
                requestCmafPackage_cmafPackage_EncryptionIsNull = false;
            }
             // determine if requestCmafPackage_cmafPackage_Encryption should be set to null
            if (requestCmafPackage_cmafPackage_EncryptionIsNull)
            {
                requestCmafPackage_cmafPackage_Encryption = null;
            }
            if (requestCmafPackage_cmafPackage_Encryption != null)
            {
                request.CmafPackage.Encryption = requestCmafPackage_cmafPackage_Encryption;
                requestCmafPackageIsNull = false;
            }
            Amazon.MediaPackage.Model.StreamSelection requestCmafPackage_cmafPackage_StreamSelection = null;
            
             // populate StreamSelection
            var requestCmafPackage_cmafPackage_StreamSelectionIsNull = true;
            requestCmafPackage_cmafPackage_StreamSelection = new Amazon.MediaPackage.Model.StreamSelection();
            System.Int32? requestCmafPackage_cmafPackage_StreamSelection_streamSelection_MaxVideoBitsPerSecond = null;
            if (cmdletContext.StreamSelection_MaxVideoBitsPerSecond != null)
            {
                requestCmafPackage_cmafPackage_StreamSelection_streamSelection_MaxVideoBitsPerSecond = cmdletContext.StreamSelection_MaxVideoBitsPerSecond.Value;
            }
            if (requestCmafPackage_cmafPackage_StreamSelection_streamSelection_MaxVideoBitsPerSecond != null)
            {
                requestCmafPackage_cmafPackage_StreamSelection.MaxVideoBitsPerSecond = requestCmafPackage_cmafPackage_StreamSelection_streamSelection_MaxVideoBitsPerSecond.Value;
                requestCmafPackage_cmafPackage_StreamSelectionIsNull = false;
            }
            System.Int32? requestCmafPackage_cmafPackage_StreamSelection_streamSelection_MinVideoBitsPerSecond = null;
            if (cmdletContext.StreamSelection_MinVideoBitsPerSecond != null)
            {
                requestCmafPackage_cmafPackage_StreamSelection_streamSelection_MinVideoBitsPerSecond = cmdletContext.StreamSelection_MinVideoBitsPerSecond.Value;
            }
            if (requestCmafPackage_cmafPackage_StreamSelection_streamSelection_MinVideoBitsPerSecond != null)
            {
                requestCmafPackage_cmafPackage_StreamSelection.MinVideoBitsPerSecond = requestCmafPackage_cmafPackage_StreamSelection_streamSelection_MinVideoBitsPerSecond.Value;
                requestCmafPackage_cmafPackage_StreamSelectionIsNull = false;
            }
            Amazon.MediaPackage.StreamOrder requestCmafPackage_cmafPackage_StreamSelection_streamSelection_StreamOrder = null;
            if (cmdletContext.StreamSelection_StreamOrder != null)
            {
                requestCmafPackage_cmafPackage_StreamSelection_streamSelection_StreamOrder = cmdletContext.StreamSelection_StreamOrder;
            }
            if (requestCmafPackage_cmafPackage_StreamSelection_streamSelection_StreamOrder != null)
            {
                requestCmafPackage_cmafPackage_StreamSelection.StreamOrder = requestCmafPackage_cmafPackage_StreamSelection_streamSelection_StreamOrder;
                requestCmafPackage_cmafPackage_StreamSelectionIsNull = false;
            }
             // determine if requestCmafPackage_cmafPackage_StreamSelection should be set to null
            if (requestCmafPackage_cmafPackage_StreamSelectionIsNull)
            {
                requestCmafPackage_cmafPackage_StreamSelection = null;
            }
            if (requestCmafPackage_cmafPackage_StreamSelection != null)
            {
                request.CmafPackage.StreamSelection = requestCmafPackage_cmafPackage_StreamSelection;
                requestCmafPackageIsNull = false;
            }
             // determine if request.CmafPackage should be set to null
            if (requestCmafPackageIsNull)
            {
                request.CmafPackage = null;
            }
            if (cmdletContext.DashPackage != null)
            {
                request.DashPackage = cmdletContext.DashPackage;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.HlsPackage != null)
            {
                request.HlsPackage = cmdletContext.HlsPackage;
            }
            if (cmdletContext.Id != null)
            {
                request.Id = cmdletContext.Id;
            }
            if (cmdletContext.ManifestName != null)
            {
                request.ManifestName = cmdletContext.ManifestName;
            }
            if (cmdletContext.MssPackage != null)
            {
                request.MssPackage = cmdletContext.MssPackage;
            }
            if (cmdletContext.Origination != null)
            {
                request.Origination = cmdletContext.Origination;
            }
            if (cmdletContext.StartoverWindowSecond != null)
            {
                request.StartoverWindowSeconds = cmdletContext.StartoverWindowSecond.Value;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.TimeDelaySecond != null)
            {
                request.TimeDelaySeconds = cmdletContext.TimeDelaySecond.Value;
            }
            if (cmdletContext.Whitelist != null)
            {
                request.Whitelist = cmdletContext.Whitelist;
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
        
        private Amazon.MediaPackage.Model.CreateOriginEndpointResponse CallAWSServiceOperation(IAmazonMediaPackage client, Amazon.MediaPackage.Model.CreateOriginEndpointRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Elemental MediaPackage", "CreateOriginEndpoint");
            try
            {
                #if DESKTOP
                return client.CreateOriginEndpoint(request);
                #elif CORECLR
                return client.CreateOriginEndpointAsync(request).GetAwaiter().GetResult();
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
            public System.String Authorization_CdnIdentifierSecret { get; set; }
            public System.String Authorization_SecretsRoleArn { get; set; }
            public System.String ChannelId { get; set; }
            public System.Int32? Encryption_KeyRotationIntervalSecond { get; set; }
            public System.String SpekeKeyProvider_CertificateArn { get; set; }
            public System.String SpekeKeyProvider_ResourceId { get; set; }
            public System.String SpekeKeyProvider_RoleArn { get; set; }
            public List<System.String> SpekeKeyProvider_SystemId { get; set; }
            public System.String SpekeKeyProvider_Url { get; set; }
            public List<Amazon.MediaPackage.Model.HlsManifestCreateOrUpdateParameters> CmafPackage_HlsManifest { get; set; }
            public System.Int32? CmafPackage_SegmentDurationSecond { get; set; }
            public System.String CmafPackage_SegmentPrefix { get; set; }
            public System.Int32? StreamSelection_MaxVideoBitsPerSecond { get; set; }
            public System.Int32? StreamSelection_MinVideoBitsPerSecond { get; set; }
            public Amazon.MediaPackage.StreamOrder StreamSelection_StreamOrder { get; set; }
            public Amazon.MediaPackage.Model.DashPackage DashPackage { get; set; }
            public System.String Description { get; set; }
            public Amazon.MediaPackage.Model.HlsPackage HlsPackage { get; set; }
            public System.String Id { get; set; }
            public System.String ManifestName { get; set; }
            public Amazon.MediaPackage.Model.MssPackage MssPackage { get; set; }
            public Amazon.MediaPackage.Origination Origination { get; set; }
            public System.Int32? StartoverWindowSecond { get; set; }
            public Dictionary<System.String, System.String> Tag { get; set; }
            public System.Int32? TimeDelaySecond { get; set; }
            public List<System.String> Whitelist { get; set; }
            public System.Func<Amazon.MediaPackage.Model.CreateOriginEndpointResponse, NewEMPOriginEndpointCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
