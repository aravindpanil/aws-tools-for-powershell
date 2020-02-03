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
using Amazon.Connect;
using Amazon.Connect.Model;

namespace Amazon.PowerShell.Cmdlets.CONN
{
    /// <summary>
    /// Gets the real-time metric data from the specified Amazon Connect instance.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-reports.html">Real-time
    /// Metrics Reports</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </para><br/><br/>In the AWS.Tools.Connect module, this cmdlet automatically pages all available results to the pipeline - parameters related to iteration are only needed if you want to manually control the paginated output. To disable autopagination, use -NoAutoIteration.
    /// </summary>
    [Cmdlet("Get", "CONNCurrentMetricData")]
    [OutputType("Amazon.Connect.Model.GetCurrentMetricDataResponse")]
    [AWSCmdlet("Calls the Amazon Connect Service GetCurrentMetricData API operation.", Operation = new[] {"GetCurrentMetricData"}, SelectReturnType = typeof(Amazon.Connect.Model.GetCurrentMetricDataResponse))]
    [AWSCmdletOutput("Amazon.Connect.Model.GetCurrentMetricDataResponse",
        "This cmdlet returns an Amazon.Connect.Model.GetCurrentMetricDataResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetCONNCurrentMetricDataCmdlet : AmazonConnectClientCmdlet, IExecutor
    {
        
        #region Parameter Filters_Channel
        /// <summary>
        /// <para>
        /// <para>The channel to use to filter the metrics.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filters_Channels")]
        public System.String[] Filters_Channel { get; set; }
        #endregion
        
        #region Parameter CurrentMetric
        /// <summary>
        /// <para>
        /// <para>The metrics to retrieve. Specify the name and unit for each metric. The following
        /// metrics are available:</para><dl><dt>AGENTS_AFTER_CONTACT_WORK</dt><dd><para>Unit: COUNT</para></dd><dt>AGENTS_AVAILABLE</dt><dd><para>Unit: COUNT</para></dd><dt>AGENTS_ERROR</dt><dd><para>Unit: COUNT</para></dd><dt>AGENTS_NON_PRODUCTIVE</dt><dd><para>Unit: COUNT</para></dd><dt>AGENTS_ON_CALL</dt><dd><para>Unit: COUNT</para></dd><dt>AGENTS_ON_CONTACT</dt><dd><para>Unit: COUNT</para></dd><dt>AGENTS_ONLINE</dt><dd><para>Unit: COUNT</para></dd><dt>AGENTS_STAFFED</dt><dd><para>Unit: COUNT</para></dd><dt>CONTACTS_IN_QUEUE</dt><dd><para>Unit: COUNT</para></dd><dt>CONTACTS_SCHEDULED</dt><dd><para>Unit: COUNT</para></dd><dt>OLDEST_CONTACT_AGE</dt><dd><para>Unit: SECONDS</para></dd><dt>SLOTS_ACTIVE</dt><dd><para>Unit: COUNT</para></dd><dt>SLOTS_AVAILABLE</dt><dd><para>Unit: COUNT</para></dd></dl>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("CurrentMetrics")]
        public Amazon.Connect.Model.CurrentMetric[] CurrentMetric { get; set; }
        #endregion
        
        #region Parameter Grouping
        /// <summary>
        /// <para>
        /// <para>The grouping applied to the metrics returned. For example, when grouped by <code>QUEUE</code>,
        /// the metrics returned apply to each queue rather than aggregated for all queues. If
        /// you group by <code>CHANNEL</code>, you should include a Channels filter. The only
        /// supported channel is <code>VOICE</code>.</para><para>If no <code>Grouping</code> is included in the request, a summary of metrics is returned.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Groupings")]
        public System.String[] Grouping { get; set; }
        #endregion
        
        #region Parameter InstanceId
        /// <summary>
        /// <para>
        /// <para>The identifier of the Amazon Connect instance.</para>
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
        public System.String InstanceId { get; set; }
        #endregion
        
        #region Parameter Filters_Queue
        /// <summary>
        /// <para>
        /// <para>The queues to use to filter the metrics. You can specify up to 100 queues per request.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filters_Queues")]
        public System.String[] Filters_Queue { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>The maximimum number of results to return per page.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxResults")]
        public System.Int32? MaxResult { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.</para><para>The token expires after 5 minutes from the time it is created. Subsequent requests
        /// that use the token must use the same request parameters as the request that generated
        /// the token.</para>
        /// </para>
        /// <para>
        /// <br/><b>Note:</b> In the AWS.Tools.Connect module, this parameter is only used if you are manually controlling output pagination of the service API call.
        /// <br/>In order to manually control output pagination, use '-NextToken $null' for the first call and '-NextToken $AWSHistory.LastServiceResponse.NextToken' for subsequent calls.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Connect.Model.GetCurrentMetricDataResponse).
        /// Specifying the name of a property of type Amazon.Connect.Model.GetCurrentMetricDataResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the InstanceId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^InstanceId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^InstanceId' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter NoAutoIteration
        #if MODULAR
        /// <summary>
        /// By default the cmdlet will auto-iterate and retrieve all results to the pipeline by performing multiple
        /// service calls. If set, the cmdlet will retrieve only the next 'page' of results using the value of NextToken
        /// as the start point.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter NoAutoIteration { get; set; }
        #endif
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Connect.Model.GetCurrentMetricDataResponse, GetCONNCurrentMetricDataCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.InstanceId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.CurrentMetric != null)
            {
                context.CurrentMetric = new List<Amazon.Connect.Model.CurrentMetric>(this.CurrentMetric);
            }
            #if MODULAR
            if (this.CurrentMetric == null && ParameterWasBound(nameof(this.CurrentMetric)))
            {
                WriteWarning("You are passing $null as a value for parameter CurrentMetric which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Filters_Channel != null)
            {
                context.Filters_Channel = new List<System.String>(this.Filters_Channel);
            }
            if (this.Filters_Queue != null)
            {
                context.Filters_Queue = new List<System.String>(this.Filters_Queue);
            }
            if (this.Grouping != null)
            {
                context.Grouping = new List<System.String>(this.Grouping);
            }
            context.InstanceId = this.InstanceId;
            #if MODULAR
            if (this.InstanceId == null && ParameterWasBound(nameof(this.InstanceId)))
            {
                WriteWarning("You are passing $null as a value for parameter InstanceId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.MaxResult = this.MaxResult;
            context.NextToken = this.NextToken;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        #if MODULAR
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            var useParameterSelect = this.Select.StartsWith("^") || this.PassThru.IsPresent;
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            
            // create request and set iteration invariants
            var request = new Amazon.Connect.Model.GetCurrentMetricDataRequest();
            
            if (cmdletContext.CurrentMetric != null)
            {
                request.CurrentMetrics = cmdletContext.CurrentMetric;
            }
            
             // populate Filters
            var requestFiltersIsNull = true;
            request.Filters = new Amazon.Connect.Model.Filters();
            List<System.String> requestFilters_filters_Channel = null;
            if (cmdletContext.Filters_Channel != null)
            {
                requestFilters_filters_Channel = cmdletContext.Filters_Channel;
            }
            if (requestFilters_filters_Channel != null)
            {
                request.Filters.Channels = requestFilters_filters_Channel;
                requestFiltersIsNull = false;
            }
            List<System.String> requestFilters_filters_Queue = null;
            if (cmdletContext.Filters_Queue != null)
            {
                requestFilters_filters_Queue = cmdletContext.Filters_Queue;
            }
            if (requestFilters_filters_Queue != null)
            {
                request.Filters.Queues = requestFilters_filters_Queue;
                requestFiltersIsNull = false;
            }
             // determine if request.Filters should be set to null
            if (requestFiltersIsNull)
            {
                request.Filters = null;
            }
            if (cmdletContext.Grouping != null)
            {
                request.Groupings = cmdletContext.Grouping;
            }
            if (cmdletContext.InstanceId != null)
            {
                request.InstanceId = cmdletContext.InstanceId;
            }
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = cmdletContext.MaxResult.Value;
            }
            
            // Initialize loop variant and commence piping
            var _nextToken = cmdletContext.NextToken;
            var _userControllingPaging = this.NoAutoIteration.IsPresent || ParameterWasBound(nameof(this.NextToken));
            
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            do
            {
                request.NextToken = _nextToken;
                
                CmdletOutput output;
                
                try
                {
                    
                    var response = CallAWSServiceOperation(client, request);
                    
                    object pipelineOutput = null;
                    if (!useParameterSelect)
                    {
                        pipelineOutput = cmdletContext.Select(response, this);
                    }
                    output = new CmdletOutput
                    {
                        PipelineOutput = pipelineOutput,
                        ServiceResponse = response
                    };
                    
                    _nextToken = response.NextToken;
                }
                catch (Exception e)
                {
                    output = new CmdletOutput { ErrorResponse = e };
                }
                
                ProcessOutput(output);
                
            } while (!_userControllingPaging && AutoIterationHelpers.HasValue(_nextToken));
            
            if (useParameterSelect)
            {
                WriteObject(cmdletContext.Select(null, this));
            }
            
            
            return null;
        }
        #else
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.Connect.Model.GetCurrentMetricDataRequest();
            
            if (cmdletContext.CurrentMetric != null)
            {
                request.CurrentMetrics = cmdletContext.CurrentMetric;
            }
            
             // populate Filters
            var requestFiltersIsNull = true;
            request.Filters = new Amazon.Connect.Model.Filters();
            List<System.String> requestFilters_filters_Channel = null;
            if (cmdletContext.Filters_Channel != null)
            {
                requestFilters_filters_Channel = cmdletContext.Filters_Channel;
            }
            if (requestFilters_filters_Channel != null)
            {
                request.Filters.Channels = requestFilters_filters_Channel;
                requestFiltersIsNull = false;
            }
            List<System.String> requestFilters_filters_Queue = null;
            if (cmdletContext.Filters_Queue != null)
            {
                requestFilters_filters_Queue = cmdletContext.Filters_Queue;
            }
            if (requestFilters_filters_Queue != null)
            {
                request.Filters.Queues = requestFilters_filters_Queue;
                requestFiltersIsNull = false;
            }
             // determine if request.Filters should be set to null
            if (requestFiltersIsNull)
            {
                request.Filters = null;
            }
            if (cmdletContext.Grouping != null)
            {
                request.Groupings = cmdletContext.Grouping;
            }
            if (cmdletContext.InstanceId != null)
            {
                request.InstanceId = cmdletContext.InstanceId;
            }
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = cmdletContext.MaxResult.Value;
            }
            if (cmdletContext.NextToken != null)
            {
                request.NextToken = cmdletContext.NextToken;
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
        #endif
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.Connect.Model.GetCurrentMetricDataResponse CallAWSServiceOperation(IAmazonConnect client, Amazon.Connect.Model.GetCurrentMetricDataRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Connect Service", "GetCurrentMetricData");
            try
            {
                #if DESKTOP
                return client.GetCurrentMetricData(request);
                #elif CORECLR
                return client.GetCurrentMetricDataAsync(request).GetAwaiter().GetResult();
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
            public List<Amazon.Connect.Model.CurrentMetric> CurrentMetric { get; set; }
            public List<System.String> Filters_Channel { get; set; }
            public List<System.String> Filters_Queue { get; set; }
            public List<System.String> Grouping { get; set; }
            public System.String InstanceId { get; set; }
            public System.Int32? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public System.Func<Amazon.Connect.Model.GetCurrentMetricDataResponse, GetCONNCurrentMetricDataCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
