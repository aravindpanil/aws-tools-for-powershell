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
using Amazon.ApplicationDiscoveryService;
using Amazon.ApplicationDiscoveryService.Model;

namespace Amazon.PowerShell.Cmdlets.ADS
{
    /// <summary>
    /// Starts an import task, which allows you to import details of your on-premises environment
    /// directly into AWS Migration Hub without having to use the Application Discovery Service
    /// (ADS) tools such as the Discovery Connector or Discovery Agent. This gives you the
    /// option to perform migration assessment and planning directly from your imported data,
    /// including the ability to group your devices as applications and track their migration
    /// status.
    /// 
    ///  
    /// <para>
    /// To start an import request, do this:
    /// </para><ol><li><para>
    /// Download the specially formatted comma separated value (CSV) import template, which
    /// you can find here: <a href="https://s3-us-west-2.amazonaws.com/templates-7cffcf56-bd96-4b1c-b45b-a5b42f282e46/import_template.csv">https://s3-us-west-2.amazonaws.com/templates-7cffcf56-bd96-4b1c-b45b-a5b42f282e46/import_template.csv</a>.
    /// </para></li><li><para>
    /// Fill out the template with your server and application data.
    /// </para></li><li><para>
    /// Upload your import file to an Amazon S3 bucket, and make a note of it's Object URL.
    /// Your import file must be in the CSV format.
    /// </para></li><li><para>
    /// Use the console or the <code>StartImportTask</code> command with the AWS CLI or one
    /// of the AWS SDKs to import the records from your file.
    /// </para></li></ol><para>
    /// For more information, including step-by-step procedures, see <a href="https://docs.aws.amazon.com/application-discovery/latest/userguide/discovery-import.html">Migration
    /// Hub Import</a> in the <i>AWS Application Discovery Service User Guide</i>.
    /// </para><note><para>
    /// There are limits to the number of import tasks you can create (and delete) in an AWS
    /// account. For more information, see <a href="https://docs.aws.amazon.com/application-discovery/latest/userguide/ads_service_limits.html">AWS
    /// Application Discovery Service Limits</a> in the <i>AWS Application Discovery Service
    /// User Guide</i>.
    /// </para></note>
    /// </summary>
    [Cmdlet("Start", "ADSImportTask", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.ApplicationDiscoveryService.Model.ImportTask")]
    [AWSCmdlet("Calls the AWS Application Discovery Service StartImportTask API operation.", Operation = new[] {"StartImportTask"}, SelectReturnType = typeof(Amazon.ApplicationDiscoveryService.Model.StartImportTaskResponse))]
    [AWSCmdletOutput("Amazon.ApplicationDiscoveryService.Model.ImportTask or Amazon.ApplicationDiscoveryService.Model.StartImportTaskResponse",
        "This cmdlet returns an Amazon.ApplicationDiscoveryService.Model.ImportTask object.",
        "The service call response (type Amazon.ApplicationDiscoveryService.Model.StartImportTaskResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class StartADSImportTaskCmdlet : AmazonApplicationDiscoveryServiceClientCmdlet, IExecutor
    {
        
        #region Parameter ClientRequestToken
        /// <summary>
        /// <para>
        /// <para>Optional. A unique token that you can provide to prevent the same import request from
        /// occurring more than once. If you don't provide a token, a token is automatically generated.</para><para>Sending more than one <code>StartImportTask</code> request with the same client request
        /// token will return information about the original import task with that client request
        /// token.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientRequestToken { get; set; }
        #endregion
        
        #region Parameter ImportUrl
        /// <summary>
        /// <para>
        /// <para>The URL for your import file that you've uploaded to Amazon S3.</para><note><para>If you're using the AWS CLI, this URL is structured as follows: <code>s3://BucketName/ImportFileName.CSV</code></para></note>
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
        public System.String ImportUrl { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>A descriptive name for this request. You can use this name to filter future requests
        /// related to this import task, such as identifying applications and servers that were
        /// included in this import task. We recommend that you use a meaningful name for each
        /// import task.</para>
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
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Task'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.ApplicationDiscoveryService.Model.StartImportTaskResponse).
        /// Specifying the name of a property of type Amazon.ApplicationDiscoveryService.Model.StartImportTaskResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Task";
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
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Start-ADSImportTask (StartImportTask)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.ApplicationDiscoveryService.Model.StartImportTaskResponse, StartADSImportTaskCmdlet>(Select) ??
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
            context.ClientRequestToken = this.ClientRequestToken;
            context.ImportUrl = this.ImportUrl;
            #if MODULAR
            if (this.ImportUrl == null && ParameterWasBound(nameof(this.ImportUrl)))
            {
                WriteWarning("You are passing $null as a value for parameter ImportUrl which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Name = this.Name;
            #if MODULAR
            if (this.Name == null && ParameterWasBound(nameof(this.Name)))
            {
                WriteWarning("You are passing $null as a value for parameter Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.ApplicationDiscoveryService.Model.StartImportTaskRequest();
            
            if (cmdletContext.ClientRequestToken != null)
            {
                request.ClientRequestToken = cmdletContext.ClientRequestToken;
            }
            if (cmdletContext.ImportUrl != null)
            {
                request.ImportUrl = cmdletContext.ImportUrl;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
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
        
        private Amazon.ApplicationDiscoveryService.Model.StartImportTaskResponse CallAWSServiceOperation(IAmazonApplicationDiscoveryService client, Amazon.ApplicationDiscoveryService.Model.StartImportTaskRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Application Discovery Service", "StartImportTask");
            try
            {
                #if DESKTOP
                return client.StartImportTask(request);
                #elif CORECLR
                return client.StartImportTaskAsync(request).GetAwaiter().GetResult();
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
            public System.String ImportUrl { get; set; }
            public System.String Name { get; set; }
            public System.Func<Amazon.ApplicationDiscoveryService.Model.StartImportTaskResponse, StartADSImportTaskCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Task;
        }
        
    }
}
