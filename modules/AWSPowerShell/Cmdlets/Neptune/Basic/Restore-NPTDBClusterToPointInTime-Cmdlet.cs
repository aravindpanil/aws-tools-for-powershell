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
using Amazon.Neptune;
using Amazon.Neptune.Model;

namespace Amazon.PowerShell.Cmdlets.NPT
{
    /// <summary>
    /// Restores a DB cluster to an arbitrary point in time. Users can restore to any point
    /// in time before <code>LatestRestorableTime</code> for up to <code>BackupRetentionPeriod</code>
    /// days. The target DB cluster is created from the source DB cluster with the same configuration
    /// as the original DB cluster, except that the new DB cluster is created with the default
    /// DB security group.
    /// 
    ///  <note><para>
    /// This action only restores the DB cluster, not the DB instances for that DB cluster.
    /// You must invoke the <a>CreateDBInstance</a> action to create DB instances for the
    /// restored DB cluster, specifying the identifier of the restored DB cluster in <code>DBClusterIdentifier</code>.
    /// You can create DB instances only after the <code>RestoreDBClusterToPointInTime</code>
    /// action has completed and the DB cluster is available.
    /// </para></note>
    /// </summary>
    [Cmdlet("Restore", "NPTDBClusterToPointInTime", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Neptune.Model.DBCluster")]
    [AWSCmdlet("Calls the Amazon Neptune RestoreDBClusterToPointInTime API operation.", Operation = new[] {"RestoreDBClusterToPointInTime"}, SelectReturnType = typeof(Amazon.Neptune.Model.RestoreDBClusterToPointInTimeResponse))]
    [AWSCmdletOutput("Amazon.Neptune.Model.DBCluster or Amazon.Neptune.Model.RestoreDBClusterToPointInTimeResponse",
        "This cmdlet returns an Amazon.Neptune.Model.DBCluster object.",
        "The service call response (type Amazon.Neptune.Model.RestoreDBClusterToPointInTimeResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class RestoreNPTDBClusterToPointInTimeCmdlet : AmazonNeptuneClientCmdlet, IExecutor
    {
        
        #region Parameter DBClusterIdentifier
        /// <summary>
        /// <para>
        /// <para>The name of the new DB cluster to be created.</para><para>Constraints:</para><ul><li><para>Must contain from 1 to 63 letters, numbers, or hyphens</para></li><li><para>First character must be a letter</para></li><li><para>Cannot end with a hyphen or contain two consecutive hyphens</para></li></ul>
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
        public System.String DBClusterIdentifier { get; set; }
        #endregion
        
        #region Parameter DBClusterParameterGroupName
        /// <summary>
        /// <para>
        /// <para>The name of the DB cluster parameter group to associate with the new DB cluster.</para><para>Constraints:</para><ul><li><para>If supplied, must match the name of an existing DBClusterParameterGroup.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String DBClusterParameterGroupName { get; set; }
        #endregion
        
        #region Parameter DBSubnetGroupName
        /// <summary>
        /// <para>
        /// <para>The DB subnet group name to use for the new DB cluster.</para><para>Constraints: If supplied, must match the name of an existing DBSubnetGroup.</para><para>Example: <code>mySubnetgroup</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String DBSubnetGroupName { get; set; }
        #endregion
        
        #region Parameter DeletionProtection
        /// <summary>
        /// <para>
        /// <para>A value that indicates whether the DB cluster has deletion protection enabled. The
        /// database can't be deleted when deletion protection is enabled. By default, deletion
        /// protection is disabled. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? DeletionProtection { get; set; }
        #endregion
        
        #region Parameter EnableCloudwatchLogsExport
        /// <summary>
        /// <para>
        /// <para>The list of logs that the restored DB cluster is to export to CloudWatch Logs.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("EnableCloudwatchLogsExports")]
        public System.String[] EnableCloudwatchLogsExport { get; set; }
        #endregion
        
        #region Parameter EnableIAMDatabaseAuthentication
        /// <summary>
        /// <para>
        /// <para>True to enable mapping of AWS Identity and Access Management (IAM) accounts to database
        /// accounts, and otherwise false.</para><para>Default: <code>false</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? EnableIAMDatabaseAuthentication { get; set; }
        #endregion
        
        #region Parameter KmsKeyId
        /// <summary>
        /// <para>
        /// <para>The AWS KMS key identifier to use when restoring an encrypted DB cluster from an encrypted
        /// DB cluster.</para><para>The KMS key identifier is the Amazon Resource Name (ARN) for the KMS encryption key.
        /// If you are restoring a DB cluster with the same AWS account that owns the KMS encryption
        /// key used to encrypt the new DB cluster, then you can use the KMS key alias instead
        /// of the ARN for the KMS encryption key.</para><para>You can restore to a new DB cluster and encrypt the new DB cluster with a KMS key
        /// that is different than the KMS key used to encrypt the source DB cluster. The new
        /// DB cluster is encrypted with the KMS key identified by the <code>KmsKeyId</code> parameter.</para><para>If you do not specify a value for the <code>KmsKeyId</code> parameter, then the following
        /// will occur:</para><ul><li><para>If the DB cluster is encrypted, then the restored DB cluster is encrypted using the
        /// KMS key that was used to encrypt the source DB cluster.</para></li><li><para>If the DB cluster is not encrypted, then the restored DB cluster is not encrypted.</para></li></ul><para>If <code>DBClusterIdentifier</code> refers to a DB cluster that is not encrypted,
        /// then the restore request is rejected.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String KmsKeyId { get; set; }
        #endregion
        
        #region Parameter OptionGroupName
        /// <summary>
        /// <para>
        /// <para><i>(Not supported by Neptune)</i></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String OptionGroupName { get; set; }
        #endregion
        
        #region Parameter Port
        /// <summary>
        /// <para>
        /// <para>The port number on which the new DB cluster accepts connections.</para><para>Constraints: Value must be <code>1150-65535</code></para><para>Default: The same port as the original DB cluster.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? Port { get; set; }
        #endregion
        
        #region Parameter RestoreToTimeUtc
        /// <summary>
        /// <para>
        /// <para>The date and time to restore the DB cluster to.</para><para>Valid Values: Value must be a time in Universal Coordinated Time (UTC) format</para><para>Constraints:</para><ul><li><para>Must be before the latest restorable time for the DB instance</para></li><li><para>Must be specified if <code>UseLatestRestorableTime</code> parameter is not provided</para></li><li><para>Cannot be specified if <code>UseLatestRestorableTime</code> parameter is true</para></li><li><para>Cannot be specified if <code>RestoreType</code> parameter is <code>copy-on-write</code></para></li></ul><para>Example: <code>2015-03-07T23:45:00Z</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.DateTime? RestoreToTimeUtc { get; set; }
        #endregion
        
        #region Parameter RestoreType
        /// <summary>
        /// <para>
        /// <para>The type of restore to be performed. You can specify one of the following values:</para><ul><li><para><code>full-copy</code> - The new DB cluster is restored as a full copy of the source
        /// DB cluster.</para></li><li><para><code>copy-on-write</code> - The new DB cluster is restored as a clone of the source
        /// DB cluster.</para></li></ul><para>If you don't specify a <code>RestoreType</code> value, then the new DB cluster is
        /// restored as a full copy of the source DB cluster.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String RestoreType { get; set; }
        #endregion
        
        #region Parameter SourceDBClusterIdentifier
        /// <summary>
        /// <para>
        /// <para>The identifier of the source DB cluster from which to restore.</para><para>Constraints:</para><ul><li><para>Must match the identifier of an existing DBCluster.</para></li></ul>
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
        public System.String SourceDBClusterIdentifier { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>The tags to be applied to the restored DB cluster.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.Neptune.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter UseLatestRestorableTime
        /// <summary>
        /// <para>
        /// <para>A value that is set to <code>true</code> to restore the DB cluster to the latest restorable
        /// backup time, and <code>false</code> otherwise.</para><para>Default: <code>false</code></para><para>Constraints: Cannot be specified if <code>RestoreToTime</code> parameter is provided.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? UseLatestRestorableTime { get; set; }
        #endregion
        
        #region Parameter VpcSecurityGroupId
        /// <summary>
        /// <para>
        /// <para>A list of VPC security groups that the new DB cluster belongs to.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("VpcSecurityGroupIds")]
        public System.String[] VpcSecurityGroupId { get; set; }
        #endregion
        
        #region Parameter RestoreToTime
        /// <summary>
        /// <para>
        /// <para>This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use RestoreToTimeUtc instead. Setting either RestoreToTime
        /// or RestoreToTimeUtc results in both RestoreToTime and RestoreToTimeUtc being assigned,
        /// the latest assignment to either one of the two property is reflected in the value
        /// of both. RestoreToTime is provided for backwards compatibility only and assigning
        /// a non-Utc DateTime to it results in the wrong timestamp being passed to the service.</para><para>The date and time to restore the DB cluster to.</para><para>Valid Values: Value must be a time in Universal Coordinated Time (UTC) format</para><para>Constraints:</para><ul><li><para>Must be before the latest restorable time for the DB instance</para></li><li><para>Must be specified if <code>UseLatestRestorableTime</code> parameter is not provided</para></li><li><para>Cannot be specified if <code>UseLatestRestorableTime</code> parameter is true</para></li><li><para>Cannot be specified if <code>RestoreType</code> parameter is <code>copy-on-write</code></para></li></ul><para>Example: <code>2015-03-07T23:45:00Z</code></para>
        /// </para>
        /// <para>This parameter is deprecated.</para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [System.ObsoleteAttribute("Setting this property results in non-UTC DateTimes not being marshalled correctly. Use RestoreToTimeUtc instead. Setting either RestoreToTime or RestoreToTimeUtc results in both RestoreToTime and RestoreToTimeUtc being assigned, the latest assignment to either one of the two property is reflected in the value of both. RestoreToTime is provided for backwards compatibility only and assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.")]
        public System.DateTime? RestoreToTime { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'DBCluster'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Neptune.Model.RestoreDBClusterToPointInTimeResponse).
        /// Specifying the name of a property of type Amazon.Neptune.Model.RestoreDBClusterToPointInTimeResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "DBCluster";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the DBClusterIdentifier parameter.
        /// The -PassThru parameter is deprecated, use -Select '^DBClusterIdentifier' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^DBClusterIdentifier' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.DBClusterIdentifier), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Restore-NPTDBClusterToPointInTime (RestoreDBClusterToPointInTime)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Neptune.Model.RestoreDBClusterToPointInTimeResponse, RestoreNPTDBClusterToPointInTimeCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.DBClusterIdentifier;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.DBClusterIdentifier = this.DBClusterIdentifier;
            #if MODULAR
            if (this.DBClusterIdentifier == null && ParameterWasBound(nameof(this.DBClusterIdentifier)))
            {
                WriteWarning("You are passing $null as a value for parameter DBClusterIdentifier which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.DBClusterParameterGroupName = this.DBClusterParameterGroupName;
            context.DBSubnetGroupName = this.DBSubnetGroupName;
            context.DeletionProtection = this.DeletionProtection;
            if (this.EnableCloudwatchLogsExport != null)
            {
                context.EnableCloudwatchLogsExport = new List<System.String>(this.EnableCloudwatchLogsExport);
            }
            context.EnableIAMDatabaseAuthentication = this.EnableIAMDatabaseAuthentication;
            context.KmsKeyId = this.KmsKeyId;
            context.OptionGroupName = this.OptionGroupName;
            context.Port = this.Port;
            context.RestoreToTimeUtc = this.RestoreToTimeUtc;
            context.RestoreType = this.RestoreType;
            context.SourceDBClusterIdentifier = this.SourceDBClusterIdentifier;
            #if MODULAR
            if (this.SourceDBClusterIdentifier == null && ParameterWasBound(nameof(this.SourceDBClusterIdentifier)))
            {
                WriteWarning("You are passing $null as a value for parameter SourceDBClusterIdentifier which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.Neptune.Model.Tag>(this.Tag);
            }
            context.UseLatestRestorableTime = this.UseLatestRestorableTime;
            if (this.VpcSecurityGroupId != null)
            {
                context.VpcSecurityGroupId = new List<System.String>(this.VpcSecurityGroupId);
            }
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.RestoreToTime = this.RestoreToTime;
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            
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
            var request = new Amazon.Neptune.Model.RestoreDBClusterToPointInTimeRequest();
            
            if (cmdletContext.DBClusterIdentifier != null)
            {
                request.DBClusterIdentifier = cmdletContext.DBClusterIdentifier;
            }
            if (cmdletContext.DBClusterParameterGroupName != null)
            {
                request.DBClusterParameterGroupName = cmdletContext.DBClusterParameterGroupName;
            }
            if (cmdletContext.DBSubnetGroupName != null)
            {
                request.DBSubnetGroupName = cmdletContext.DBSubnetGroupName;
            }
            if (cmdletContext.DeletionProtection != null)
            {
                request.DeletionProtection = cmdletContext.DeletionProtection.Value;
            }
            if (cmdletContext.EnableCloudwatchLogsExport != null)
            {
                request.EnableCloudwatchLogsExports = cmdletContext.EnableCloudwatchLogsExport;
            }
            if (cmdletContext.EnableIAMDatabaseAuthentication != null)
            {
                request.EnableIAMDatabaseAuthentication = cmdletContext.EnableIAMDatabaseAuthentication.Value;
            }
            if (cmdletContext.KmsKeyId != null)
            {
                request.KmsKeyId = cmdletContext.KmsKeyId;
            }
            if (cmdletContext.OptionGroupName != null)
            {
                request.OptionGroupName = cmdletContext.OptionGroupName;
            }
            if (cmdletContext.Port != null)
            {
                request.Port = cmdletContext.Port.Value;
            }
            if (cmdletContext.RestoreToTimeUtc != null)
            {
                request.RestoreToTimeUtc = cmdletContext.RestoreToTimeUtc.Value;
            }
            if (cmdletContext.RestoreType != null)
            {
                request.RestoreType = cmdletContext.RestoreType;
            }
            if (cmdletContext.SourceDBClusterIdentifier != null)
            {
                request.SourceDBClusterIdentifier = cmdletContext.SourceDBClusterIdentifier;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.UseLatestRestorableTime != null)
            {
                request.UseLatestRestorableTime = cmdletContext.UseLatestRestorableTime.Value;
            }
            if (cmdletContext.VpcSecurityGroupId != null)
            {
                request.VpcSecurityGroupIds = cmdletContext.VpcSecurityGroupId;
            }
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (cmdletContext.RestoreToTime != null)
            {
                request.RestoreToTime = cmdletContext.RestoreToTime.Value;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            
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
        
        private Amazon.Neptune.Model.RestoreDBClusterToPointInTimeResponse CallAWSServiceOperation(IAmazonNeptune client, Amazon.Neptune.Model.RestoreDBClusterToPointInTimeRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Neptune", "RestoreDBClusterToPointInTime");
            try
            {
                #if DESKTOP
                return client.RestoreDBClusterToPointInTime(request);
                #elif CORECLR
                return client.RestoreDBClusterToPointInTimeAsync(request).GetAwaiter().GetResult();
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
            public System.String DBClusterIdentifier { get; set; }
            public System.String DBClusterParameterGroupName { get; set; }
            public System.String DBSubnetGroupName { get; set; }
            public System.Boolean? DeletionProtection { get; set; }
            public List<System.String> EnableCloudwatchLogsExport { get; set; }
            public System.Boolean? EnableIAMDatabaseAuthentication { get; set; }
            public System.String KmsKeyId { get; set; }
            public System.String OptionGroupName { get; set; }
            public System.Int32? Port { get; set; }
            public System.DateTime? RestoreToTimeUtc { get; set; }
            public System.String RestoreType { get; set; }
            public System.String SourceDBClusterIdentifier { get; set; }
            public List<Amazon.Neptune.Model.Tag> Tag { get; set; }
            public System.Boolean? UseLatestRestorableTime { get; set; }
            public List<System.String> VpcSecurityGroupId { get; set; }
            [System.ObsoleteAttribute]
            public System.DateTime? RestoreToTime { get; set; }
            public System.Func<Amazon.Neptune.Model.RestoreDBClusterToPointInTimeResponse, RestoreNPTDBClusterToPointInTimeCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.DBCluster;
        }
        
    }
}
