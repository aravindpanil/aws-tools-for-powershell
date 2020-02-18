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
using Amazon.RDS;
using Amazon.RDS.Model;

namespace Amazon.PowerShell.Cmdlets.RDS
{
    /// <summary>
    /// Copies a snapshot of a DB cluster.
    /// 
    ///  
    /// <para>
    /// To copy a DB cluster snapshot from a shared manual DB cluster snapshot, <code>SourceDBClusterSnapshotIdentifier</code>
    /// must be the Amazon Resource Name (ARN) of the shared DB cluster snapshot.
    /// </para><para>
    /// You can copy an encrypted DB cluster snapshot from another AWS Region. In that case,
    /// the AWS Region where you call the <code>CopyDBClusterSnapshot</code> action is the
    /// destination AWS Region for the encrypted DB cluster snapshot to be copied to. To copy
    /// an encrypted DB cluster snapshot from another AWS Region, you must provide the following
    /// values:
    /// </para><ul><li><para><code>KmsKeyId</code> - The AWS Key Management System (AWS KMS) key identifier for
    /// the key to use to encrypt the copy of the DB cluster snapshot in the destination AWS
    /// Region.
    /// </para></li><li><para><code>PreSignedUrl</code> - A URL that contains a Signature Version 4 signed request
    /// for the <code>CopyDBClusterSnapshot</code> action to be called in the source AWS Region
    /// where the DB cluster snapshot is copied from. The pre-signed URL must be a valid request
    /// for the <code>CopyDBClusterSnapshot</code> API action that can be executed in the
    /// source AWS Region that contains the encrypted DB cluster snapshot to be copied.
    /// </para><para>
    /// The pre-signed URL request must contain the following parameter values:
    /// </para><ul><li><para><code>KmsKeyId</code> - The KMS key identifier for the key to use to encrypt the
    /// copy of the DB cluster snapshot in the destination AWS Region. This is the same identifier
    /// for both the <code>CopyDBClusterSnapshot</code> action that is called in the destination
    /// AWS Region, and the action contained in the pre-signed URL.
    /// </para></li><li><para><code>DestinationRegion</code> - The name of the AWS Region that the DB cluster snapshot
    /// is to be created in.
    /// </para></li><li><para><code>SourceDBClusterSnapshotIdentifier</code> - The DB cluster snapshot identifier
    /// for the encrypted DB cluster snapshot to be copied. This identifier must be in the
    /// Amazon Resource Name (ARN) format for the source AWS Region. For example, if you are
    /// copying an encrypted DB cluster snapshot from the us-west-2 AWS Region, then your
    /// <code>SourceDBClusterSnapshotIdentifier</code> looks like the following example: <code>arn:aws:rds:us-west-2:123456789012:cluster-snapshot:aurora-cluster1-snapshot-20161115</code>.
    /// </para></li></ul><para>
    /// To learn how to generate a Signature Version 4 signed request, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">
    /// Authenticating Requests: Using Query Parameters (AWS Signature Version 4)</a> and
    /// <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">
    /// Signature Version 4 Signing Process</a>.
    /// </para><note><para>
    /// If you are using an AWS SDK tool or the AWS CLI, you can specify <code>SourceRegion</code>
    /// (or <code>--source-region</code> for the AWS CLI) instead of specifying <code>PreSignedUrl</code>
    /// manually. Specifying <code>SourceRegion</code> autogenerates a pre-signed URL that
    /// is a valid request for the operation that can be executed in the source AWS Region.
    /// </para></note></li><li><para><code>TargetDBClusterSnapshotIdentifier</code> - The identifier for the new copy
    /// of the DB cluster snapshot in the destination AWS Region.
    /// </para></li><li><para><code>SourceDBClusterSnapshotIdentifier</code> - The DB cluster snapshot identifier
    /// for the encrypted DB cluster snapshot to be copied. This identifier must be in the
    /// ARN format for the source AWS Region and is the same value as the <code>SourceDBClusterSnapshotIdentifier</code>
    /// in the pre-signed URL. 
    /// </para></li></ul><para>
    /// To cancel the copy operation once it is in progress, delete the target DB cluster
    /// snapshot identified by <code>TargetDBClusterSnapshotIdentifier</code> while that DB
    /// cluster snapshot is in "copying" status.
    /// </para><para>
    /// For more information on copying encrypted DB cluster snapshots from one AWS Region
    /// to another, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_CopySnapshot.html">
    /// Copying a Snapshot</a> in the <i>Amazon Aurora User Guide.</i></para><para>
    /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What Is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide.</i></para><note><para>
    /// This action only applies to Aurora DB clusters.
    /// </para></note>
    /// </summary>
    [Cmdlet("Copy", "RDSDBClusterSnapshot", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.RDS.Model.DBClusterSnapshot")]
    [AWSCmdlet("Calls the Amazon Relational Database Service CopyDBClusterSnapshot API operation.", Operation = new[] {"CopyDBClusterSnapshot"}, SelectReturnType = typeof(Amazon.RDS.Model.CopyDBClusterSnapshotResponse))]
    [AWSCmdletOutput("Amazon.RDS.Model.DBClusterSnapshot or Amazon.RDS.Model.CopyDBClusterSnapshotResponse",
        "This cmdlet returns an Amazon.RDS.Model.DBClusterSnapshot object.",
        "The service call response (type Amazon.RDS.Model.CopyDBClusterSnapshotResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class CopyRDSDBClusterSnapshotCmdlet : AmazonRDSClientCmdlet, IExecutor
    {
        
        #region Parameter CopyTag
        /// <summary>
        /// <para>
        /// <para>A value that indicates whether to copy all tags from the source DB cluster snapshot
        /// to the target DB cluster snapshot. By default, tags are not copied.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("CopyTags")]
        public System.Boolean? CopyTag { get; set; }
        #endregion
        
        #region Parameter KmsKeyId
        /// <summary>
        /// <para>
        /// <para>The AWS KMS key ID for an encrypted DB cluster snapshot. The KMS key ID is the Amazon
        /// Resource Name (ARN), KMS key identifier, or the KMS key alias for the KMS encryption
        /// key. </para><para>If you copy an encrypted DB cluster snapshot from your AWS account, you can specify
        /// a value for <code>KmsKeyId</code> to encrypt the copy with a new KMS encryption key.
        /// If you don't specify a value for <code>KmsKeyId</code>, then the copy of the DB cluster
        /// snapshot is encrypted with the same KMS key as the source DB cluster snapshot. </para><para>If you copy an encrypted DB cluster snapshot that is shared from another AWS account,
        /// then you must specify a value for <code>KmsKeyId</code>. </para><para>To copy an encrypted DB cluster snapshot to another AWS Region, you must set <code>KmsKeyId</code>
        /// to the KMS key ID you want to use to encrypt the copy of the DB cluster snapshot in
        /// the destination AWS Region. KMS encryption keys are specific to the AWS Region that
        /// they are created in, and you can't use encryption keys from one AWS Region in another
        /// AWS Region.</para><para>If you copy an unencrypted DB cluster snapshot and specify a value for the <code>KmsKeyId</code>
        /// parameter, an error is returned.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String KmsKeyId { get; set; }
        #endregion
        
        #region Parameter PreSignedUrl
        /// <summary>
        /// <para>
        /// <para>The URL that contains a Signature Version 4 signed request for the <code>CopyDBClusterSnapshot</code>
        /// API action in the AWS Region that contains the source DB cluster snapshot to copy.
        /// The <code>PreSignedUrl</code> parameter must be used when copying an encrypted DB
        /// cluster snapshot from another AWS Region. Don't specify <code>PreSignedUrl</code>
        /// when you are copying an encrypted DB cluster snapshot in the same AWS Region.</para><para>The pre-signed URL must be a valid request for the <code>CopyDBSClusterSnapshot</code>
        /// API action that can be executed in the source AWS Region that contains the encrypted
        /// DB cluster snapshot to be copied. The pre-signed URL request must contain the following
        /// parameter values:</para><ul><li><para><code>KmsKeyId</code> - The AWS KMS key identifier for the key to use to encrypt
        /// the copy of the DB cluster snapshot in the destination AWS Region. This is the same
        /// identifier for both the <code>CopyDBClusterSnapshot</code> action that is called in
        /// the destination AWS Region, and the action contained in the pre-signed URL.</para></li><li><para><code>DestinationRegion</code> - The name of the AWS Region that the DB cluster snapshot
        /// is to be created in.</para></li><li><para><code>SourceDBClusterSnapshotIdentifier</code> - The DB cluster snapshot identifier
        /// for the encrypted DB cluster snapshot to be copied. This identifier must be in the
        /// Amazon Resource Name (ARN) format for the source AWS Region. For example, if you are
        /// copying an encrypted DB cluster snapshot from the us-west-2 AWS Region, then your
        /// <code>SourceDBClusterSnapshotIdentifier</code> looks like the following example: <code>arn:aws:rds:us-west-2:123456789012:cluster-snapshot:aurora-cluster1-snapshot-20161115</code>.</para></li></ul><para>To learn how to generate a Signature Version 4 signed request, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">
        /// Authenticating Requests: Using Query Parameters (AWS Signature Version 4)</a> and
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">
        /// Signature Version 4 Signing Process</a>.</para><note><para>If you are using an AWS SDK tool or the AWS CLI, you can specify <code>SourceRegion</code>
        /// (or <code>--source-region</code> for the AWS CLI) instead of specifying <code>PreSignedUrl</code>
        /// manually. Specifying <code>SourceRegion</code> autogenerates a pre-signed URL that
        /// is a valid request for the operation that can be executed in the source AWS Region.</para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String PreSignedUrl { get; set; }
        #endregion
        
        #region Parameter SourceDBClusterSnapshotIdentifier
        /// <summary>
        /// <para>
        /// <para>The identifier of the DB cluster snapshot to copy. This parameter isn't case-sensitive.</para><para>You can't copy an encrypted, shared DB cluster snapshot from one AWS Region to another.</para><para>Constraints:</para><ul><li><para>Must specify a valid system snapshot in the "available" state.</para></li><li><para>If the source snapshot is in the same AWS Region as the copy, specify a valid DB snapshot
        /// identifier.</para></li><li><para>If the source snapshot is in a different AWS Region than the copy, specify a valid
        /// DB cluster snapshot ARN. For more information, go to <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_CopySnapshot.html#USER_CopySnapshot.AcrossRegions">
        /// Copying Snapshots Across AWS Regions</a> in the <i>Amazon Aurora User Guide.</i></para></li></ul><para>Example: <code>my-cluster-snapshot1</code></para>
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
        public System.String SourceDBClusterSnapshotIdentifier { get; set; }
        #endregion
        
        #region Parameter SourceRegion
        /// <summary>
        /// <para>
        ///  The SourceRegion for generating the PreSignedUrl property.
        /// 
        ///  If SourceRegion is set and the PreSignedUrl property is not,
        ///  then PreSignedUrl will be automatically generated by the client.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SourceRegion { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.RDS.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter TargetDBClusterSnapshotIdentifier
        /// <summary>
        /// <para>
        /// <para>The identifier of the new DB cluster snapshot to create from the source DB cluster
        /// snapshot. This parameter isn't case-sensitive.</para><para>Constraints:</para><ul><li><para>Must contain from 1 to 63 letters, numbers, or hyphens.</para></li><li><para>First character must be a letter.</para></li><li><para>Can't end with a hyphen or contain two consecutive hyphens.</para></li></ul><para>Example: <code>my-cluster-snapshot2</code></para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 1, ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(Position = 1, ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String TargetDBClusterSnapshotIdentifier { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'DBClusterSnapshot'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.RDS.Model.CopyDBClusterSnapshotResponse).
        /// Specifying the name of a property of type Amazon.RDS.Model.CopyDBClusterSnapshotResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "DBClusterSnapshot";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the SourceDBClusterSnapshotIdentifier parameter.
        /// The -PassThru parameter is deprecated, use -Select '^SourceDBClusterSnapshotIdentifier' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^SourceDBClusterSnapshotIdentifier' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.SourceDBClusterSnapshotIdentifier), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Copy-RDSDBClusterSnapshot (CopyDBClusterSnapshot)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.RDS.Model.CopyDBClusterSnapshotResponse, CopyRDSDBClusterSnapshotCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.SourceDBClusterSnapshotIdentifier;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.SourceRegion = this.SourceRegion;
            context.CopyTag = this.CopyTag;
            context.KmsKeyId = this.KmsKeyId;
            context.PreSignedUrl = this.PreSignedUrl;
            context.SourceDBClusterSnapshotIdentifier = this.SourceDBClusterSnapshotIdentifier;
            #if MODULAR
            if (this.SourceDBClusterSnapshotIdentifier == null && ParameterWasBound(nameof(this.SourceDBClusterSnapshotIdentifier)))
            {
                WriteWarning("You are passing $null as a value for parameter SourceDBClusterSnapshotIdentifier which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.RDS.Model.Tag>(this.Tag);
            }
            context.TargetDBClusterSnapshotIdentifier = this.TargetDBClusterSnapshotIdentifier;
            #if MODULAR
            if (this.TargetDBClusterSnapshotIdentifier == null && ParameterWasBound(nameof(this.TargetDBClusterSnapshotIdentifier)))
            {
                WriteWarning("You are passing $null as a value for parameter TargetDBClusterSnapshotIdentifier which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
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
            var request = new Amazon.RDS.Model.CopyDBClusterSnapshotRequest();
            
            if (cmdletContext.SourceRegion != null)
            {
                request.SourceRegion = cmdletContext.SourceRegion;
            }
            if (cmdletContext.CopyTag != null)
            {
                request.CopyTags = cmdletContext.CopyTag.Value;
            }
            if (cmdletContext.KmsKeyId != null)
            {
                request.KmsKeyId = cmdletContext.KmsKeyId;
            }
            if (cmdletContext.PreSignedUrl != null)
            {
                request.PreSignedUrl = cmdletContext.PreSignedUrl;
            }
            if (cmdletContext.SourceDBClusterSnapshotIdentifier != null)
            {
                request.SourceDBClusterSnapshotIdentifier = cmdletContext.SourceDBClusterSnapshotIdentifier;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.TargetDBClusterSnapshotIdentifier != null)
            {
                request.TargetDBClusterSnapshotIdentifier = cmdletContext.TargetDBClusterSnapshotIdentifier;
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
        
        private Amazon.RDS.Model.CopyDBClusterSnapshotResponse CallAWSServiceOperation(IAmazonRDS client, Amazon.RDS.Model.CopyDBClusterSnapshotRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Relational Database Service", "CopyDBClusterSnapshot");
            try
            {
                #if DESKTOP
                return client.CopyDBClusterSnapshot(request);
                #elif CORECLR
                return client.CopyDBClusterSnapshotAsync(request).GetAwaiter().GetResult();
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
            public System.String SourceRegion { get; set; }
            public System.Boolean? CopyTag { get; set; }
            public System.String KmsKeyId { get; set; }
            public System.String PreSignedUrl { get; set; }
            public System.String SourceDBClusterSnapshotIdentifier { get; set; }
            public List<Amazon.RDS.Model.Tag> Tag { get; set; }
            public System.String TargetDBClusterSnapshotIdentifier { get; set; }
            public System.Func<Amazon.RDS.Model.CopyDBClusterSnapshotResponse, CopyRDSDBClusterSnapshotCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.DBClusterSnapshot;
        }
        
    }
}
