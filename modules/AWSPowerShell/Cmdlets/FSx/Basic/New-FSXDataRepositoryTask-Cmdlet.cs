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
using Amazon.FSx;
using Amazon.FSx.Model;

namespace Amazon.PowerShell.Cmdlets.FSX
{
    /// <summary>
    /// Creates an Amazon FSx for Lustre data repository task. You use data repository tasks
    /// to perform bulk operations between your Amazon FSx file system and its linked data
    /// repository. An example of a data repository task is exporting any data and metadata
    /// changes, including POSIX metadata, to files, directories, and symbolic links (symlinks)
    /// from your FSx file system to its linked data repository. A <code>CreateDataRepositoryTask</code>
    /// operation will fail if a data repository is not linked to the FSx file system. To
    /// learn more about data repository tasks, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/data-repository-tasks.html">Using
    /// Data Repository Tasks</a>. To learn more about linking a data repository to your file
    /// system, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/getting-started-step1.html">Step
    /// 1: Create Your Amazon FSx for Lustre File System</a>.
    /// </summary>
    [Cmdlet("New", "FSXDataRepositoryTask", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.FSx.Model.DataRepositoryTask")]
    [AWSCmdlet("Calls the Amazon FSx CreateDataRepositoryTask API operation.", Operation = new[] {"CreateDataRepositoryTask"}, SelectReturnType = typeof(Amazon.FSx.Model.CreateDataRepositoryTaskResponse))]
    [AWSCmdletOutput("Amazon.FSx.Model.DataRepositoryTask or Amazon.FSx.Model.CreateDataRepositoryTaskResponse",
        "This cmdlet returns an Amazon.FSx.Model.DataRepositoryTask object.",
        "The service call response (type Amazon.FSx.Model.CreateDataRepositoryTaskResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewFSXDataRepositoryTaskCmdlet : AmazonFSxClientCmdlet, IExecutor
    {
        
        #region Parameter ClientRequestToken
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientRequestToken { get; set; }
        #endregion
        
        #region Parameter Report_Enabled
        /// <summary>
        /// <para>
        /// <para>Set <code>Enabled</code> to <code>True</code> to generate a <code>CompletionReport</code>
        /// when the task completes. If set to <code>true</code>, then you need to provide a report
        /// <code>Scope</code>, <code>Path</code>, and <code>Format</code>. Set <code>Enabled</code>
        /// to <code>False</code> if you do not want a <code>CompletionReport</code> generated
        /// when the task completes.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.Boolean? Report_Enabled { get; set; }
        #endregion
        
        #region Parameter FileSystemId
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
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
        public System.String FileSystemId { get; set; }
        #endregion
        
        #region Parameter Report_Format
        /// <summary>
        /// <para>
        /// <para>Required if <code>Enabled</code> is set to <code>true</code>. Specifies the format
        /// of the <code>CompletionReport</code>. <code>REPORT_CSV_20191124</code> is the only
        /// format currently supported. When <code>Format</code> is set to <code>REPORT_CSV_20191124</code>,
        /// the <code>CompletionReport</code> is provided in CSV format, and is delivered to <code>{path}/task-{id}/failures.csv</code>.
        /// </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.FSx.ReportFormat")]
        public Amazon.FSx.ReportFormat Report_Format { get; set; }
        #endregion
        
        #region Parameter Report_Path
        /// <summary>
        /// <para>
        /// <para>Required if <code>Enabled</code> is set to <code>true</code>. Specifies the location
        /// of the report on the file system's linked S3 data repository. An absolute path that
        /// defines where the completion report will be stored in the destination location. The
        /// <code>Path</code> you provide must be located within the file system’s ExportPath.
        /// An example <code>Path</code> value is "s3://myBucket/myExportPath/optionalPrefix".
        /// The report provides the following information for each file in the report: FilePath,
        /// FileStatus, and ErrorCode. To learn more about a file system's <code>ExportPath</code>,
        /// see . </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Report_Path { get; set; }
        #endregion
        
        #region Parameter Path
        /// <summary>
        /// <para>
        /// <para>(Optional) The path or paths on the Amazon FSx file system to use when the data repository
        /// task is processed. The default path is the file system root directory.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Paths")]
        public System.String[] Path { get; set; }
        #endregion
        
        #region Parameter Report_Scope
        /// <summary>
        /// <para>
        /// <para>Required if <code>Enabled</code> is set to <code>true</code>. Specifies the scope
        /// of the <code>CompletionReport</code>; <code>FAILED_FILES_ONLY</code> is the only scope
        /// currently supported. When <code>Scope</code> is set to <code>FAILED_FILES_ONLY</code>,
        /// the <code>CompletionReport</code> only contains information about files that the data
        /// repository task failed to process.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.FSx.ReportScope")]
        public Amazon.FSx.ReportScope Report_Scope { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.FSx.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter Type
        /// <summary>
        /// <para>
        /// <para>Specifies the type of data repository task to create.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.FSx.DataRepositoryTaskType")]
        public Amazon.FSx.DataRepositoryTaskType Type { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'DataRepositoryTask'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.FSx.Model.CreateDataRepositoryTaskResponse).
        /// Specifying the name of a property of type Amazon.FSx.Model.CreateDataRepositoryTaskResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "DataRepositoryTask";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the FileSystemId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^FileSystemId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^FileSystemId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.FileSystemId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-FSXDataRepositoryTask (CreateDataRepositoryTask)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.FSx.Model.CreateDataRepositoryTaskResponse, NewFSXDataRepositoryTaskCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.FileSystemId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ClientRequestToken = this.ClientRequestToken;
            context.FileSystemId = this.FileSystemId;
            #if MODULAR
            if (this.FileSystemId == null && ParameterWasBound(nameof(this.FileSystemId)))
            {
                WriteWarning("You are passing $null as a value for parameter FileSystemId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Path != null)
            {
                context.Path = new List<System.String>(this.Path);
            }
            context.Report_Enabled = this.Report_Enabled;
            #if MODULAR
            if (this.Report_Enabled == null && ParameterWasBound(nameof(this.Report_Enabled)))
            {
                WriteWarning("You are passing $null as a value for parameter Report_Enabled which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Report_Format = this.Report_Format;
            context.Report_Path = this.Report_Path;
            context.Report_Scope = this.Report_Scope;
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.FSx.Model.Tag>(this.Tag);
            }
            context.Type = this.Type;
            #if MODULAR
            if (this.Type == null && ParameterWasBound(nameof(this.Type)))
            {
                WriteWarning("You are passing $null as a value for parameter Type which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.FSx.Model.CreateDataRepositoryTaskRequest();
            
            if (cmdletContext.ClientRequestToken != null)
            {
                request.ClientRequestToken = cmdletContext.ClientRequestToken;
            }
            if (cmdletContext.FileSystemId != null)
            {
                request.FileSystemId = cmdletContext.FileSystemId;
            }
            if (cmdletContext.Path != null)
            {
                request.Paths = cmdletContext.Path;
            }
            
             // populate Report
            var requestReportIsNull = true;
            request.Report = new Amazon.FSx.Model.CompletionReport();
            System.Boolean? requestReport_report_Enabled = null;
            if (cmdletContext.Report_Enabled != null)
            {
                requestReport_report_Enabled = cmdletContext.Report_Enabled.Value;
            }
            if (requestReport_report_Enabled != null)
            {
                request.Report.Enabled = requestReport_report_Enabled.Value;
                requestReportIsNull = false;
            }
            Amazon.FSx.ReportFormat requestReport_report_Format = null;
            if (cmdletContext.Report_Format != null)
            {
                requestReport_report_Format = cmdletContext.Report_Format;
            }
            if (requestReport_report_Format != null)
            {
                request.Report.Format = requestReport_report_Format;
                requestReportIsNull = false;
            }
            System.String requestReport_report_Path = null;
            if (cmdletContext.Report_Path != null)
            {
                requestReport_report_Path = cmdletContext.Report_Path;
            }
            if (requestReport_report_Path != null)
            {
                request.Report.Path = requestReport_report_Path;
                requestReportIsNull = false;
            }
            Amazon.FSx.ReportScope requestReport_report_Scope = null;
            if (cmdletContext.Report_Scope != null)
            {
                requestReport_report_Scope = cmdletContext.Report_Scope;
            }
            if (requestReport_report_Scope != null)
            {
                request.Report.Scope = requestReport_report_Scope;
                requestReportIsNull = false;
            }
             // determine if request.Report should be set to null
            if (requestReportIsNull)
            {
                request.Report = null;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.Type != null)
            {
                request.Type = cmdletContext.Type;
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
        
        private Amazon.FSx.Model.CreateDataRepositoryTaskResponse CallAWSServiceOperation(IAmazonFSx client, Amazon.FSx.Model.CreateDataRepositoryTaskRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon FSx", "CreateDataRepositoryTask");
            try
            {
                #if DESKTOP
                return client.CreateDataRepositoryTask(request);
                #elif CORECLR
                return client.CreateDataRepositoryTaskAsync(request).GetAwaiter().GetResult();
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
            public System.String ClientRequestToken { get; set; }
            public System.String FileSystemId { get; set; }
            public List<System.String> Path { get; set; }
            public System.Boolean? Report_Enabled { get; set; }
            public Amazon.FSx.ReportFormat Report_Format { get; set; }
            public System.String Report_Path { get; set; }
            public Amazon.FSx.ReportScope Report_Scope { get; set; }
            public List<Amazon.FSx.Model.Tag> Tag { get; set; }
            public Amazon.FSx.DataRepositoryTaskType Type { get; set; }
            public System.Func<Amazon.FSx.Model.CreateDataRepositoryTaskResponse, NewFSXDataRepositoryTaskCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.DataRepositoryTask;
        }
        
    }
}
