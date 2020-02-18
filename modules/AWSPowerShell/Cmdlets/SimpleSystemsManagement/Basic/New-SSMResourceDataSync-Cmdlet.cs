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
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace Amazon.PowerShell.Cmdlets.SSM
{
    /// <summary>
    /// A resource data sync helps you view data from multiple sources in a single location.
    /// Systems Manager offers two types of resource data sync: <code>SyncToDestination</code>
    /// and <code>SyncFromSource</code>.
    /// 
    ///  
    /// <para>
    /// You can configure Systems Manager Inventory to use the <code>SyncToDestination</code>
    /// type to synchronize Inventory data from multiple AWS Regions to a single Amazon S3
    /// bucket. For more information, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-inventory-datasync.html">Configuring
    /// Resource Data Sync for Inventory</a> in the <i>AWS Systems Manager User Guide</i>.
    /// </para><para>
    /// You can configure Systems Manager Explorer to use the <code>SyncFromSource</code>
    /// type to synchronize operational work items (OpsItems) and operational data (OpsData)
    /// from multiple AWS Regions to a single Amazon S3 bucket. This type can synchronize
    /// OpsItems and OpsData from multiple AWS accounts and Regions or <code>EntireOrganization</code>
    /// by using AWS Organizations. For more information, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/Explorer-resource-data-sync.html">Setting
    /// Up Explorer to Display Data from Multiple Accounts and Regions</a> in the <i>AWS Systems
    /// Manager User Guide</i>.
    /// </para><para>
    /// A resource data sync is an asynchronous operation that returns immediately. After
    /// a successful initial sync is completed, the system continuously syncs data. To check
    /// the status of a sync, use the <a>ListResourceDataSync</a>.
    /// </para><note><para>
    /// By default, data is not encrypted in Amazon S3. We strongly recommend that you enable
    /// encryption in Amazon S3 to ensure secure data storage. We also recommend that you
    /// secure access to the Amazon S3 bucket by creating a restrictive bucket policy. 
    /// </para></note>
    /// </summary>
    [Cmdlet("New", "SSMResourceDataSync", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the AWS Systems Manager CreateResourceDataSync API operation.", Operation = new[] {"CreateResourceDataSync"}, SelectReturnType = typeof(Amazon.SimpleSystemsManagement.Model.CreateResourceDataSyncResponse))]
    [AWSCmdletOutput("None or Amazon.SimpleSystemsManagement.Model.CreateResourceDataSyncResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.SimpleSystemsManagement.Model.CreateResourceDataSyncResponse) can be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewSSMResourceDataSyncCmdlet : AmazonSimpleSystemsManagementClientCmdlet, IExecutor
    {
        
        #region Parameter S3Destination_AWSKMSKeyARN
        /// <summary>
        /// <para>
        /// <para>The ARN of an encryption key for a destination in Amazon S3. Must belong to the same
        /// Region as the destination Amazon S3 bucket.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String S3Destination_AWSKMSKeyARN { get; set; }
        #endregion
        
        #region Parameter S3Destination_BucketName
        /// <summary>
        /// <para>
        /// <para>The name of the Amazon S3 bucket where the aggregated data is stored.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String S3Destination_BucketName { get; set; }
        #endregion
        
        #region Parameter SyncSource_IncludeFutureRegion
        /// <summary>
        /// <para>
        /// <para>Whether to automatically synchronize and aggregate data from new AWS Regions when
        /// those Regions come online.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SyncSource_IncludeFutureRegions")]
        public System.Boolean? SyncSource_IncludeFutureRegion { get; set; }
        #endregion
        
        #region Parameter AwsOrganizationsSource_OrganizationalUnit
        /// <summary>
        /// <para>
        /// <para>The AWS Organizations organization units included in the sync.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SyncSource_AwsOrganizationsSource_OrganizationalUnits")]
        public Amazon.SimpleSystemsManagement.Model.ResourceDataSyncOrganizationalUnit[] AwsOrganizationsSource_OrganizationalUnit { get; set; }
        #endregion
        
        #region Parameter AwsOrganizationsSource_OrganizationSourceType
        /// <summary>
        /// <para>
        /// <para>If an AWS Organization is present, this is either <code>OrganizationalUnits</code>
        /// or <code>EntireOrganization</code>. For <code>OrganizationalUnits</code>, the data
        /// is aggregated from a set of organization units. For <code>EntireOrganization</code>,
        /// the data is aggregated from the entire AWS Organization. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SyncSource_AwsOrganizationsSource_OrganizationSourceType")]
        public System.String AwsOrganizationsSource_OrganizationSourceType { get; set; }
        #endregion
        
        #region Parameter S3Destination_Prefix
        /// <summary>
        /// <para>
        /// <para>An Amazon S3 prefix for the bucket.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String S3Destination_Prefix { get; set; }
        #endregion
        
        #region Parameter S3Destination_Region
        /// <summary>
        /// <para>
        /// <para>The AWS Region with the Amazon S3 bucket targeted by the Resource Data Sync.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String S3Destination_Region { get; set; }
        #endregion
        
        #region Parameter SyncSource_SourceRegion
        /// <summary>
        /// <para>
        /// <para>The <code>SyncSource</code> AWS Regions included in the resource data sync.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SyncSource_SourceRegions")]
        public System.String[] SyncSource_SourceRegion { get; set; }
        #endregion
        
        #region Parameter SyncSource_SourceType
        /// <summary>
        /// <para>
        /// <para>The type of data source for the resource data sync. <code>SourceType</code> is either
        /// <code>AwsOrganizations</code> (if an organization is present in AWS Organizations)
        /// or <code>singleAccountMultiRegions</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SyncSource_SourceType { get; set; }
        #endregion
        
        #region Parameter S3Destination_SyncFormat
        /// <summary>
        /// <para>
        /// <para>A supported sync format. The following format is currently supported: JsonSerDe</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.SimpleSystemsManagement.ResourceDataSyncS3Format")]
        public Amazon.SimpleSystemsManagement.ResourceDataSyncS3Format S3Destination_SyncFormat { get; set; }
        #endregion
        
        #region Parameter SyncName
        /// <summary>
        /// <para>
        /// <para>A name for the configuration.</para>
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
        public System.String SyncName { get; set; }
        #endregion
        
        #region Parameter SyncType
        /// <summary>
        /// <para>
        /// <para>Specify <code>SyncToDestination</code> to create a resource data sync that synchronizes
        /// data from multiple AWS Regions to an Amazon S3 bucket. Specify <code>SyncFromSource</code>
        /// to synchronize data from multiple AWS accounts and Regions, as listed in AWS Organizations.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SyncType { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SimpleSystemsManagement.Model.CreateResourceDataSyncResponse).
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the SyncName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^SyncName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^SyncName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.SyncName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-SSMResourceDataSync (CreateResourceDataSync)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SimpleSystemsManagement.Model.CreateResourceDataSyncResponse, NewSSMResourceDataSyncCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.SyncName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.S3Destination_AWSKMSKeyARN = this.S3Destination_AWSKMSKeyARN;
            context.S3Destination_BucketName = this.S3Destination_BucketName;
            context.S3Destination_Prefix = this.S3Destination_Prefix;
            context.S3Destination_Region = this.S3Destination_Region;
            context.S3Destination_SyncFormat = this.S3Destination_SyncFormat;
            context.SyncName = this.SyncName;
            #if MODULAR
            if (this.SyncName == null && ParameterWasBound(nameof(this.SyncName)))
            {
                WriteWarning("You are passing $null as a value for parameter SyncName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.AwsOrganizationsSource_OrganizationalUnit != null)
            {
                context.AwsOrganizationsSource_OrganizationalUnit = new List<Amazon.SimpleSystemsManagement.Model.ResourceDataSyncOrganizationalUnit>(this.AwsOrganizationsSource_OrganizationalUnit);
            }
            context.AwsOrganizationsSource_OrganizationSourceType = this.AwsOrganizationsSource_OrganizationSourceType;
            context.SyncSource_IncludeFutureRegion = this.SyncSource_IncludeFutureRegion;
            if (this.SyncSource_SourceRegion != null)
            {
                context.SyncSource_SourceRegion = new List<System.String>(this.SyncSource_SourceRegion);
            }
            context.SyncSource_SourceType = this.SyncSource_SourceType;
            context.SyncType = this.SyncType;
            
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
            var request = new Amazon.SimpleSystemsManagement.Model.CreateResourceDataSyncRequest();
            
            
             // populate S3Destination
            var requestS3DestinationIsNull = true;
            request.S3Destination = new Amazon.SimpleSystemsManagement.Model.ResourceDataSyncS3Destination();
            System.String requestS3Destination_s3Destination_AWSKMSKeyARN = null;
            if (cmdletContext.S3Destination_AWSKMSKeyARN != null)
            {
                requestS3Destination_s3Destination_AWSKMSKeyARN = cmdletContext.S3Destination_AWSKMSKeyARN;
            }
            if (requestS3Destination_s3Destination_AWSKMSKeyARN != null)
            {
                request.S3Destination.AWSKMSKeyARN = requestS3Destination_s3Destination_AWSKMSKeyARN;
                requestS3DestinationIsNull = false;
            }
            System.String requestS3Destination_s3Destination_BucketName = null;
            if (cmdletContext.S3Destination_BucketName != null)
            {
                requestS3Destination_s3Destination_BucketName = cmdletContext.S3Destination_BucketName;
            }
            if (requestS3Destination_s3Destination_BucketName != null)
            {
                request.S3Destination.BucketName = requestS3Destination_s3Destination_BucketName;
                requestS3DestinationIsNull = false;
            }
            System.String requestS3Destination_s3Destination_Prefix = null;
            if (cmdletContext.S3Destination_Prefix != null)
            {
                requestS3Destination_s3Destination_Prefix = cmdletContext.S3Destination_Prefix;
            }
            if (requestS3Destination_s3Destination_Prefix != null)
            {
                request.S3Destination.Prefix = requestS3Destination_s3Destination_Prefix;
                requestS3DestinationIsNull = false;
            }
            System.String requestS3Destination_s3Destination_Region = null;
            if (cmdletContext.S3Destination_Region != null)
            {
                requestS3Destination_s3Destination_Region = cmdletContext.S3Destination_Region;
            }
            if (requestS3Destination_s3Destination_Region != null)
            {
                request.S3Destination.Region = requestS3Destination_s3Destination_Region;
                requestS3DestinationIsNull = false;
            }
            Amazon.SimpleSystemsManagement.ResourceDataSyncS3Format requestS3Destination_s3Destination_SyncFormat = null;
            if (cmdletContext.S3Destination_SyncFormat != null)
            {
                requestS3Destination_s3Destination_SyncFormat = cmdletContext.S3Destination_SyncFormat;
            }
            if (requestS3Destination_s3Destination_SyncFormat != null)
            {
                request.S3Destination.SyncFormat = requestS3Destination_s3Destination_SyncFormat;
                requestS3DestinationIsNull = false;
            }
             // determine if request.S3Destination should be set to null
            if (requestS3DestinationIsNull)
            {
                request.S3Destination = null;
            }
            if (cmdletContext.SyncName != null)
            {
                request.SyncName = cmdletContext.SyncName;
            }
            
             // populate SyncSource
            var requestSyncSourceIsNull = true;
            request.SyncSource = new Amazon.SimpleSystemsManagement.Model.ResourceDataSyncSource();
            System.Boolean? requestSyncSource_syncSource_IncludeFutureRegion = null;
            if (cmdletContext.SyncSource_IncludeFutureRegion != null)
            {
                requestSyncSource_syncSource_IncludeFutureRegion = cmdletContext.SyncSource_IncludeFutureRegion.Value;
            }
            if (requestSyncSource_syncSource_IncludeFutureRegion != null)
            {
                request.SyncSource.IncludeFutureRegions = requestSyncSource_syncSource_IncludeFutureRegion.Value;
                requestSyncSourceIsNull = false;
            }
            List<System.String> requestSyncSource_syncSource_SourceRegion = null;
            if (cmdletContext.SyncSource_SourceRegion != null)
            {
                requestSyncSource_syncSource_SourceRegion = cmdletContext.SyncSource_SourceRegion;
            }
            if (requestSyncSource_syncSource_SourceRegion != null)
            {
                request.SyncSource.SourceRegions = requestSyncSource_syncSource_SourceRegion;
                requestSyncSourceIsNull = false;
            }
            System.String requestSyncSource_syncSource_SourceType = null;
            if (cmdletContext.SyncSource_SourceType != null)
            {
                requestSyncSource_syncSource_SourceType = cmdletContext.SyncSource_SourceType;
            }
            if (requestSyncSource_syncSource_SourceType != null)
            {
                request.SyncSource.SourceType = requestSyncSource_syncSource_SourceType;
                requestSyncSourceIsNull = false;
            }
            Amazon.SimpleSystemsManagement.Model.ResourceDataSyncAwsOrganizationsSource requestSyncSource_syncSource_AwsOrganizationsSource = null;
            
             // populate AwsOrganizationsSource
            var requestSyncSource_syncSource_AwsOrganizationsSourceIsNull = true;
            requestSyncSource_syncSource_AwsOrganizationsSource = new Amazon.SimpleSystemsManagement.Model.ResourceDataSyncAwsOrganizationsSource();
            List<Amazon.SimpleSystemsManagement.Model.ResourceDataSyncOrganizationalUnit> requestSyncSource_syncSource_AwsOrganizationsSource_awsOrganizationsSource_OrganizationalUnit = null;
            if (cmdletContext.AwsOrganizationsSource_OrganizationalUnit != null)
            {
                requestSyncSource_syncSource_AwsOrganizationsSource_awsOrganizationsSource_OrganizationalUnit = cmdletContext.AwsOrganizationsSource_OrganizationalUnit;
            }
            if (requestSyncSource_syncSource_AwsOrganizationsSource_awsOrganizationsSource_OrganizationalUnit != null)
            {
                requestSyncSource_syncSource_AwsOrganizationsSource.OrganizationalUnits = requestSyncSource_syncSource_AwsOrganizationsSource_awsOrganizationsSource_OrganizationalUnit;
                requestSyncSource_syncSource_AwsOrganizationsSourceIsNull = false;
            }
            System.String requestSyncSource_syncSource_AwsOrganizationsSource_awsOrganizationsSource_OrganizationSourceType = null;
            if (cmdletContext.AwsOrganizationsSource_OrganizationSourceType != null)
            {
                requestSyncSource_syncSource_AwsOrganizationsSource_awsOrganizationsSource_OrganizationSourceType = cmdletContext.AwsOrganizationsSource_OrganizationSourceType;
            }
            if (requestSyncSource_syncSource_AwsOrganizationsSource_awsOrganizationsSource_OrganizationSourceType != null)
            {
                requestSyncSource_syncSource_AwsOrganizationsSource.OrganizationSourceType = requestSyncSource_syncSource_AwsOrganizationsSource_awsOrganizationsSource_OrganizationSourceType;
                requestSyncSource_syncSource_AwsOrganizationsSourceIsNull = false;
            }
             // determine if requestSyncSource_syncSource_AwsOrganizationsSource should be set to null
            if (requestSyncSource_syncSource_AwsOrganizationsSourceIsNull)
            {
                requestSyncSource_syncSource_AwsOrganizationsSource = null;
            }
            if (requestSyncSource_syncSource_AwsOrganizationsSource != null)
            {
                request.SyncSource.AwsOrganizationsSource = requestSyncSource_syncSource_AwsOrganizationsSource;
                requestSyncSourceIsNull = false;
            }
             // determine if request.SyncSource should be set to null
            if (requestSyncSourceIsNull)
            {
                request.SyncSource = null;
            }
            if (cmdletContext.SyncType != null)
            {
                request.SyncType = cmdletContext.SyncType;
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
        
        private Amazon.SimpleSystemsManagement.Model.CreateResourceDataSyncResponse CallAWSServiceOperation(IAmazonSimpleSystemsManagement client, Amazon.SimpleSystemsManagement.Model.CreateResourceDataSyncRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Systems Manager", "CreateResourceDataSync");
            try
            {
                #if DESKTOP
                return client.CreateResourceDataSync(request);
                #elif CORECLR
                return client.CreateResourceDataSyncAsync(request).GetAwaiter().GetResult();
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
            public System.String S3Destination_AWSKMSKeyARN { get; set; }
            public System.String S3Destination_BucketName { get; set; }
            public System.String S3Destination_Prefix { get; set; }
            public System.String S3Destination_Region { get; set; }
            public Amazon.SimpleSystemsManagement.ResourceDataSyncS3Format S3Destination_SyncFormat { get; set; }
            public System.String SyncName { get; set; }
            public List<Amazon.SimpleSystemsManagement.Model.ResourceDataSyncOrganizationalUnit> AwsOrganizationsSource_OrganizationalUnit { get; set; }
            public System.String AwsOrganizationsSource_OrganizationSourceType { get; set; }
            public System.Boolean? SyncSource_IncludeFutureRegion { get; set; }
            public List<System.String> SyncSource_SourceRegion { get; set; }
            public System.String SyncSource_SourceType { get; set; }
            public System.String SyncType { get; set; }
            public System.Func<Amazon.SimpleSystemsManagement.Model.CreateResourceDataSyncResponse, NewSSMResourceDataSyncCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}
