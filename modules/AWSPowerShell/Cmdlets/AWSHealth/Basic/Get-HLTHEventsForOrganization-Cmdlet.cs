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
using Amazon.AWSHealth;
using Amazon.AWSHealth.Model;

namespace Amazon.PowerShell.Cmdlets.HLTH
{
    /// <summary>
    /// Returns information about events across your organization in AWS Organizations, meeting
    /// the specified filter criteria. Events are returned in a summary form and do not include
    /// the accounts impacted, detailed description, any additional metadata that depends
    /// on the event type, or any affected resources. To retrieve that information, use the
    /// <a>DescribeAffectedAccountsForOrganization</a>, <a>DescribeEventDetailsForOrganization</a>,
    /// and <a>DescribeAffectedEntitiesForOrganization</a> operations.
    /// 
    ///  
    /// <para>
    /// If no filter criteria are specified, all events across your organization are returned.
    /// Results are sorted by <code>lastModifiedTime</code>, starting with the most recent.
    /// </para><para>
    /// Before you can call this operation, you must first enable Health to work with AWS
    /// Organizations. To do this, call the <a>EnableHealthServiceAccessForOrganization</a>
    /// operation from your organization's master account.
    /// </para><br/><br/>This cmdlet automatically pages all available results to the pipeline - parameters related to iteration are only needed if you want to manually control the paginated output. To disable autopagination, use -NoAutoIteration.
    /// </summary>
    [Cmdlet("Get", "HLTHEventsForOrganization")]
    [OutputType("Amazon.AWSHealth.Model.OrganizationEvent")]
    [AWSCmdlet("Calls the AWS Health DescribeEventsForOrganization API operation.", Operation = new[] {"DescribeEventsForOrganization"}, SelectReturnType = typeof(Amazon.AWSHealth.Model.DescribeEventsForOrganizationResponse))]
    [AWSCmdletOutput("Amazon.AWSHealth.Model.OrganizationEvent or Amazon.AWSHealth.Model.DescribeEventsForOrganizationResponse",
        "This cmdlet returns a collection of Amazon.AWSHealth.Model.OrganizationEvent objects.",
        "The service call response (type Amazon.AWSHealth.Model.DescribeEventsForOrganizationResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetHLTHEventsForOrganizationCmdlet : AmazonAWSHealthClientCmdlet, IExecutor
    {
        
        #region Parameter Filter_AwsAccountId
        /// <summary>
        /// <para>
        /// <para>A list of 12-digit AWS account numbers that contains the affected entities.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filter_AwsAccountIds")]
        public System.String[] Filter_AwsAccountId { get; set; }
        #endregion
        
        #region Parameter Filter_EntityArn
        /// <summary>
        /// <para>
        /// <para>REPLACEME</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filter_EntityArns")]
        public System.String[] Filter_EntityArn { get; set; }
        #endregion
        
        #region Parameter Filter_EntityValue
        /// <summary>
        /// <para>
        /// <para>A list of entity identifiers, such as EC2 instance IDs (i-34ab692e) or EBS volumes
        /// (vol-426ab23e).</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filter_EntityValues")]
        public System.String[] Filter_EntityValue { get; set; }
        #endregion
        
        #region Parameter Filter_EventStatusCode
        /// <summary>
        /// <para>
        /// <para>A list of event status codes.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filter_EventStatusCodes")]
        public System.String[] Filter_EventStatusCode { get; set; }
        #endregion
        
        #region Parameter Filter_EventTypeCategory
        /// <summary>
        /// <para>
        /// <para>REPLACEME</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filter_EventTypeCategories")]
        public System.String[] Filter_EventTypeCategory { get; set; }
        #endregion
        
        #region Parameter Filter_EventTypeCode
        /// <summary>
        /// <para>
        /// <para>A list of unique identifiers for event types. For example, <code>"AWS_EC2_SYSTEM_MAINTENANCE_EVENT","AWS_RDS_MAINTENANCE_SCHEDULED".</code></para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filter_EventTypeCodes")]
        public System.String[] Filter_EventTypeCode { get; set; }
        #endregion
        
        #region Parameter EndTime_From
        /// <summary>
        /// <para>
        /// <para>The starting date and time of a time range.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filter_EndTime_From")]
        public System.DateTime? EndTime_From { get; set; }
        #endregion
        
        #region Parameter LastUpdatedTime_From
        /// <summary>
        /// <para>
        /// <para>The starting date and time of a time range.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filter_LastUpdatedTime_From")]
        public System.DateTime? LastUpdatedTime_From { get; set; }
        #endregion
        
        #region Parameter StartTime_From
        /// <summary>
        /// <para>
        /// <para>The starting date and time of a time range.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filter_StartTime_From")]
        public System.DateTime? StartTime_From { get; set; }
        #endregion
        
        #region Parameter Locale
        /// <summary>
        /// <para>
        /// <para>The locale (language) to return information in. English (en) is the default and the
        /// only supported value at this time.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String Locale { get; set; }
        #endregion
        
        #region Parameter Filter_Region
        /// <summary>
        /// <para>
        /// <para>A list of AWS Regions.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filter_Regions")]
        public System.String[] Filter_Region { get; set; }
        #endregion
        
        #region Parameter Filter_Service
        /// <summary>
        /// <para>
        /// <para>The AWS services associated with the event. For example, <code>EC2</code>, <code>RDS</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filter_Services")]
        public System.String[] Filter_Service { get; set; }
        #endregion
        
        #region Parameter EndTime_To
        /// <summary>
        /// <para>
        /// <para>The ending date and time of a time range.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filter_EndTime_To")]
        public System.DateTime? EndTime_To { get; set; }
        #endregion
        
        #region Parameter LastUpdatedTime_To
        /// <summary>
        /// <para>
        /// <para>The ending date and time of a time range.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filter_LastUpdatedTime_To")]
        public System.DateTime? LastUpdatedTime_To { get; set; }
        #endregion
        
        #region Parameter StartTime_To
        /// <summary>
        /// <para>
        /// <para>The ending date and time of a time range.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Filter_StartTime_To")]
        public System.DateTime? StartTime_To { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>The maximum number of items to return in one batch, between 10 and 100, inclusive.</para>
        /// </para>
        /// <para>
        /// <br/><b>Note:</b> In AWSPowerShell and AWSPowerShell.NetCore this parameter is used to limit the total number of items returned by the cmdlet.
        /// <br/>In AWS.Tools this parameter is simply passed to the service to specify how many items should be returned by each service call.
        /// <br/>Pipe the output of this cmdlet into Select-Object -First to terminate retrieving data pages early and control the number of items returned.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("MaxItems","MaxResults")]
        public int? MaxResult { get; set; }
        #endregion
        
        #region Parameter NextToken
        /// <summary>
        /// <para>
        /// <para>If the results of a search are large, only a portion of the results are returned,
        /// and a <code>nextToken</code> pagination token is returned in the response. To retrieve
        /// the next batch of results, reissue the search request and include the returned token.
        /// When all results have been returned, the response does not contain a pagination token
        /// value.</para>
        /// </para>
        /// <para>
        /// <br/><b>Note:</b> This parameter is only used if you are manually controlling output pagination of the service API call.
        /// <br/>In order to manually control output pagination, use '-NextToken $null' for the first call and '-NextToken $AWSHistory.LastServiceResponse.NextToken' for subsequent calls.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NextToken { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Events'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AWSHealth.Model.DescribeEventsForOrganizationResponse).
        /// Specifying the name of a property of type Amazon.AWSHealth.Model.DescribeEventsForOrganizationResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Events";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Locale parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Locale' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Locale' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter NoAutoIteration
        /// <summary>
        /// By default the cmdlet will auto-iterate and retrieve all results to the pipeline by performing multiple
        /// service calls. If set, the cmdlet will retrieve only the next 'page' of results using the value of NextToken
        /// as the start point.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter NoAutoIteration { get; set; }
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
                context.Select = CreateSelectDelegate<Amazon.AWSHealth.Model.DescribeEventsForOrganizationResponse, GetHLTHEventsForOrganizationCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Locale;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.Filter_AwsAccountId != null)
            {
                context.Filter_AwsAccountId = new List<System.String>(this.Filter_AwsAccountId);
            }
            context.EndTime_From = this.EndTime_From;
            context.EndTime_To = this.EndTime_To;
            if (this.Filter_EntityArn != null)
            {
                context.Filter_EntityArn = new List<System.String>(this.Filter_EntityArn);
            }
            if (this.Filter_EntityValue != null)
            {
                context.Filter_EntityValue = new List<System.String>(this.Filter_EntityValue);
            }
            if (this.Filter_EventStatusCode != null)
            {
                context.Filter_EventStatusCode = new List<System.String>(this.Filter_EventStatusCode);
            }
            if (this.Filter_EventTypeCategory != null)
            {
                context.Filter_EventTypeCategory = new List<System.String>(this.Filter_EventTypeCategory);
            }
            if (this.Filter_EventTypeCode != null)
            {
                context.Filter_EventTypeCode = new List<System.String>(this.Filter_EventTypeCode);
            }
            context.LastUpdatedTime_From = this.LastUpdatedTime_From;
            context.LastUpdatedTime_To = this.LastUpdatedTime_To;
            if (this.Filter_Region != null)
            {
                context.Filter_Region = new List<System.String>(this.Filter_Region);
            }
            if (this.Filter_Service != null)
            {
                context.Filter_Service = new List<System.String>(this.Filter_Service);
            }
            context.StartTime_From = this.StartTime_From;
            context.StartTime_To = this.StartTime_To;
            context.Locale = this.Locale;
            context.MaxResult = this.MaxResult;
            #if !MODULAR
            if (ParameterWasBound(nameof(this.MaxResult)) && this.MaxResult.HasValue)
            {
                WriteWarning("AWSPowerShell and AWSPowerShell.NetCore use the MaxResult parameter to limit the total number of items returned by the cmdlet." +
                    " This behavior is obsolete and will be removed in a future version of these modules. Pipe the output of this cmdlet into Select-Object -First to terminate" +
                    " retrieving data pages early and control the number of items returned. AWS.Tools already implements the new behavior of simply passing MaxResult" +
                    " to the service to specify how many items should be returned by each service call.");
            }
            #endif
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
            var request = new Amazon.AWSHealth.Model.DescribeEventsForOrganizationRequest();
            
            
             // populate Filter
            var requestFilterIsNull = true;
            request.Filter = new Amazon.AWSHealth.Model.OrganizationEventFilter();
            List<System.String> requestFilter_filter_AwsAccountId = null;
            if (cmdletContext.Filter_AwsAccountId != null)
            {
                requestFilter_filter_AwsAccountId = cmdletContext.Filter_AwsAccountId;
            }
            if (requestFilter_filter_AwsAccountId != null)
            {
                request.Filter.AwsAccountIds = requestFilter_filter_AwsAccountId;
                requestFilterIsNull = false;
            }
            List<System.String> requestFilter_filter_EntityArn = null;
            if (cmdletContext.Filter_EntityArn != null)
            {
                requestFilter_filter_EntityArn = cmdletContext.Filter_EntityArn;
            }
            if (requestFilter_filter_EntityArn != null)
            {
                request.Filter.EntityArns = requestFilter_filter_EntityArn;
                requestFilterIsNull = false;
            }
            List<System.String> requestFilter_filter_EntityValue = null;
            if (cmdletContext.Filter_EntityValue != null)
            {
                requestFilter_filter_EntityValue = cmdletContext.Filter_EntityValue;
            }
            if (requestFilter_filter_EntityValue != null)
            {
                request.Filter.EntityValues = requestFilter_filter_EntityValue;
                requestFilterIsNull = false;
            }
            List<System.String> requestFilter_filter_EventStatusCode = null;
            if (cmdletContext.Filter_EventStatusCode != null)
            {
                requestFilter_filter_EventStatusCode = cmdletContext.Filter_EventStatusCode;
            }
            if (requestFilter_filter_EventStatusCode != null)
            {
                request.Filter.EventStatusCodes = requestFilter_filter_EventStatusCode;
                requestFilterIsNull = false;
            }
            List<System.String> requestFilter_filter_EventTypeCategory = null;
            if (cmdletContext.Filter_EventTypeCategory != null)
            {
                requestFilter_filter_EventTypeCategory = cmdletContext.Filter_EventTypeCategory;
            }
            if (requestFilter_filter_EventTypeCategory != null)
            {
                request.Filter.EventTypeCategories = requestFilter_filter_EventTypeCategory;
                requestFilterIsNull = false;
            }
            List<System.String> requestFilter_filter_EventTypeCode = null;
            if (cmdletContext.Filter_EventTypeCode != null)
            {
                requestFilter_filter_EventTypeCode = cmdletContext.Filter_EventTypeCode;
            }
            if (requestFilter_filter_EventTypeCode != null)
            {
                request.Filter.EventTypeCodes = requestFilter_filter_EventTypeCode;
                requestFilterIsNull = false;
            }
            List<System.String> requestFilter_filter_Region = null;
            if (cmdletContext.Filter_Region != null)
            {
                requestFilter_filter_Region = cmdletContext.Filter_Region;
            }
            if (requestFilter_filter_Region != null)
            {
                request.Filter.Regions = requestFilter_filter_Region;
                requestFilterIsNull = false;
            }
            List<System.String> requestFilter_filter_Service = null;
            if (cmdletContext.Filter_Service != null)
            {
                requestFilter_filter_Service = cmdletContext.Filter_Service;
            }
            if (requestFilter_filter_Service != null)
            {
                request.Filter.Services = requestFilter_filter_Service;
                requestFilterIsNull = false;
            }
            Amazon.AWSHealth.Model.DateTimeRange requestFilter_filter_EndTime = null;
            
             // populate EndTime
            var requestFilter_filter_EndTimeIsNull = true;
            requestFilter_filter_EndTime = new Amazon.AWSHealth.Model.DateTimeRange();
            System.DateTime? requestFilter_filter_EndTime_endTime_From = null;
            if (cmdletContext.EndTime_From != null)
            {
                requestFilter_filter_EndTime_endTime_From = cmdletContext.EndTime_From.Value;
            }
            if (requestFilter_filter_EndTime_endTime_From != null)
            {
                requestFilter_filter_EndTime.From = requestFilter_filter_EndTime_endTime_From.Value;
                requestFilter_filter_EndTimeIsNull = false;
            }
            System.DateTime? requestFilter_filter_EndTime_endTime_To = null;
            if (cmdletContext.EndTime_To != null)
            {
                requestFilter_filter_EndTime_endTime_To = cmdletContext.EndTime_To.Value;
            }
            if (requestFilter_filter_EndTime_endTime_To != null)
            {
                requestFilter_filter_EndTime.To = requestFilter_filter_EndTime_endTime_To.Value;
                requestFilter_filter_EndTimeIsNull = false;
            }
             // determine if requestFilter_filter_EndTime should be set to null
            if (requestFilter_filter_EndTimeIsNull)
            {
                requestFilter_filter_EndTime = null;
            }
            if (requestFilter_filter_EndTime != null)
            {
                request.Filter.EndTime = requestFilter_filter_EndTime;
                requestFilterIsNull = false;
            }
            Amazon.AWSHealth.Model.DateTimeRange requestFilter_filter_LastUpdatedTime = null;
            
             // populate LastUpdatedTime
            var requestFilter_filter_LastUpdatedTimeIsNull = true;
            requestFilter_filter_LastUpdatedTime = new Amazon.AWSHealth.Model.DateTimeRange();
            System.DateTime? requestFilter_filter_LastUpdatedTime_lastUpdatedTime_From = null;
            if (cmdletContext.LastUpdatedTime_From != null)
            {
                requestFilter_filter_LastUpdatedTime_lastUpdatedTime_From = cmdletContext.LastUpdatedTime_From.Value;
            }
            if (requestFilter_filter_LastUpdatedTime_lastUpdatedTime_From != null)
            {
                requestFilter_filter_LastUpdatedTime.From = requestFilter_filter_LastUpdatedTime_lastUpdatedTime_From.Value;
                requestFilter_filter_LastUpdatedTimeIsNull = false;
            }
            System.DateTime? requestFilter_filter_LastUpdatedTime_lastUpdatedTime_To = null;
            if (cmdletContext.LastUpdatedTime_To != null)
            {
                requestFilter_filter_LastUpdatedTime_lastUpdatedTime_To = cmdletContext.LastUpdatedTime_To.Value;
            }
            if (requestFilter_filter_LastUpdatedTime_lastUpdatedTime_To != null)
            {
                requestFilter_filter_LastUpdatedTime.To = requestFilter_filter_LastUpdatedTime_lastUpdatedTime_To.Value;
                requestFilter_filter_LastUpdatedTimeIsNull = false;
            }
             // determine if requestFilter_filter_LastUpdatedTime should be set to null
            if (requestFilter_filter_LastUpdatedTimeIsNull)
            {
                requestFilter_filter_LastUpdatedTime = null;
            }
            if (requestFilter_filter_LastUpdatedTime != null)
            {
                request.Filter.LastUpdatedTime = requestFilter_filter_LastUpdatedTime;
                requestFilterIsNull = false;
            }
            Amazon.AWSHealth.Model.DateTimeRange requestFilter_filter_StartTime = null;
            
             // populate StartTime
            var requestFilter_filter_StartTimeIsNull = true;
            requestFilter_filter_StartTime = new Amazon.AWSHealth.Model.DateTimeRange();
            System.DateTime? requestFilter_filter_StartTime_startTime_From = null;
            if (cmdletContext.StartTime_From != null)
            {
                requestFilter_filter_StartTime_startTime_From = cmdletContext.StartTime_From.Value;
            }
            if (requestFilter_filter_StartTime_startTime_From != null)
            {
                requestFilter_filter_StartTime.From = requestFilter_filter_StartTime_startTime_From.Value;
                requestFilter_filter_StartTimeIsNull = false;
            }
            System.DateTime? requestFilter_filter_StartTime_startTime_To = null;
            if (cmdletContext.StartTime_To != null)
            {
                requestFilter_filter_StartTime_startTime_To = cmdletContext.StartTime_To.Value;
            }
            if (requestFilter_filter_StartTime_startTime_To != null)
            {
                requestFilter_filter_StartTime.To = requestFilter_filter_StartTime_startTime_To.Value;
                requestFilter_filter_StartTimeIsNull = false;
            }
             // determine if requestFilter_filter_StartTime should be set to null
            if (requestFilter_filter_StartTimeIsNull)
            {
                requestFilter_filter_StartTime = null;
            }
            if (requestFilter_filter_StartTime != null)
            {
                request.Filter.StartTime = requestFilter_filter_StartTime;
                requestFilterIsNull = false;
            }
             // determine if request.Filter should be set to null
            if (requestFilterIsNull)
            {
                request.Filter = null;
            }
            if (cmdletContext.Locale != null)
            {
                request.Locale = cmdletContext.Locale;
            }
            if (cmdletContext.MaxResult != null)
            {
                request.MaxResults = AutoIterationHelpers.ConvertEmitLimitToServiceTypeInt32(cmdletContext.MaxResult.Value);
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
            var useParameterSelect = this.Select.StartsWith("^") || this.PassThru.IsPresent;
            
            // create request and set iteration invariants
            var request = new Amazon.AWSHealth.Model.DescribeEventsForOrganizationRequest();
            
             // populate Filter
            var requestFilterIsNull = true;
            request.Filter = new Amazon.AWSHealth.Model.OrganizationEventFilter();
            List<System.String> requestFilter_filter_AwsAccountId = null;
            if (cmdletContext.Filter_AwsAccountId != null)
            {
                requestFilter_filter_AwsAccountId = cmdletContext.Filter_AwsAccountId;
            }
            if (requestFilter_filter_AwsAccountId != null)
            {
                request.Filter.AwsAccountIds = requestFilter_filter_AwsAccountId;
                requestFilterIsNull = false;
            }
            List<System.String> requestFilter_filter_EntityArn = null;
            if (cmdletContext.Filter_EntityArn != null)
            {
                requestFilter_filter_EntityArn = cmdletContext.Filter_EntityArn;
            }
            if (requestFilter_filter_EntityArn != null)
            {
                request.Filter.EntityArns = requestFilter_filter_EntityArn;
                requestFilterIsNull = false;
            }
            List<System.String> requestFilter_filter_EntityValue = null;
            if (cmdletContext.Filter_EntityValue != null)
            {
                requestFilter_filter_EntityValue = cmdletContext.Filter_EntityValue;
            }
            if (requestFilter_filter_EntityValue != null)
            {
                request.Filter.EntityValues = requestFilter_filter_EntityValue;
                requestFilterIsNull = false;
            }
            List<System.String> requestFilter_filter_EventStatusCode = null;
            if (cmdletContext.Filter_EventStatusCode != null)
            {
                requestFilter_filter_EventStatusCode = cmdletContext.Filter_EventStatusCode;
            }
            if (requestFilter_filter_EventStatusCode != null)
            {
                request.Filter.EventStatusCodes = requestFilter_filter_EventStatusCode;
                requestFilterIsNull = false;
            }
            List<System.String> requestFilter_filter_EventTypeCategory = null;
            if (cmdletContext.Filter_EventTypeCategory != null)
            {
                requestFilter_filter_EventTypeCategory = cmdletContext.Filter_EventTypeCategory;
            }
            if (requestFilter_filter_EventTypeCategory != null)
            {
                request.Filter.EventTypeCategories = requestFilter_filter_EventTypeCategory;
                requestFilterIsNull = false;
            }
            List<System.String> requestFilter_filter_EventTypeCode = null;
            if (cmdletContext.Filter_EventTypeCode != null)
            {
                requestFilter_filter_EventTypeCode = cmdletContext.Filter_EventTypeCode;
            }
            if (requestFilter_filter_EventTypeCode != null)
            {
                request.Filter.EventTypeCodes = requestFilter_filter_EventTypeCode;
                requestFilterIsNull = false;
            }
            List<System.String> requestFilter_filter_Region = null;
            if (cmdletContext.Filter_Region != null)
            {
                requestFilter_filter_Region = cmdletContext.Filter_Region;
            }
            if (requestFilter_filter_Region != null)
            {
                request.Filter.Regions = requestFilter_filter_Region;
                requestFilterIsNull = false;
            }
            List<System.String> requestFilter_filter_Service = null;
            if (cmdletContext.Filter_Service != null)
            {
                requestFilter_filter_Service = cmdletContext.Filter_Service;
            }
            if (requestFilter_filter_Service != null)
            {
                request.Filter.Services = requestFilter_filter_Service;
                requestFilterIsNull = false;
            }
            Amazon.AWSHealth.Model.DateTimeRange requestFilter_filter_EndTime = null;
            
             // populate EndTime
            var requestFilter_filter_EndTimeIsNull = true;
            requestFilter_filter_EndTime = new Amazon.AWSHealth.Model.DateTimeRange();
            System.DateTime? requestFilter_filter_EndTime_endTime_From = null;
            if (cmdletContext.EndTime_From != null)
            {
                requestFilter_filter_EndTime_endTime_From = cmdletContext.EndTime_From.Value;
            }
            if (requestFilter_filter_EndTime_endTime_From != null)
            {
                requestFilter_filter_EndTime.From = requestFilter_filter_EndTime_endTime_From.Value;
                requestFilter_filter_EndTimeIsNull = false;
            }
            System.DateTime? requestFilter_filter_EndTime_endTime_To = null;
            if (cmdletContext.EndTime_To != null)
            {
                requestFilter_filter_EndTime_endTime_To = cmdletContext.EndTime_To.Value;
            }
            if (requestFilter_filter_EndTime_endTime_To != null)
            {
                requestFilter_filter_EndTime.To = requestFilter_filter_EndTime_endTime_To.Value;
                requestFilter_filter_EndTimeIsNull = false;
            }
             // determine if requestFilter_filter_EndTime should be set to null
            if (requestFilter_filter_EndTimeIsNull)
            {
                requestFilter_filter_EndTime = null;
            }
            if (requestFilter_filter_EndTime != null)
            {
                request.Filter.EndTime = requestFilter_filter_EndTime;
                requestFilterIsNull = false;
            }
            Amazon.AWSHealth.Model.DateTimeRange requestFilter_filter_LastUpdatedTime = null;
            
             // populate LastUpdatedTime
            var requestFilter_filter_LastUpdatedTimeIsNull = true;
            requestFilter_filter_LastUpdatedTime = new Amazon.AWSHealth.Model.DateTimeRange();
            System.DateTime? requestFilter_filter_LastUpdatedTime_lastUpdatedTime_From = null;
            if (cmdletContext.LastUpdatedTime_From != null)
            {
                requestFilter_filter_LastUpdatedTime_lastUpdatedTime_From = cmdletContext.LastUpdatedTime_From.Value;
            }
            if (requestFilter_filter_LastUpdatedTime_lastUpdatedTime_From != null)
            {
                requestFilter_filter_LastUpdatedTime.From = requestFilter_filter_LastUpdatedTime_lastUpdatedTime_From.Value;
                requestFilter_filter_LastUpdatedTimeIsNull = false;
            }
            System.DateTime? requestFilter_filter_LastUpdatedTime_lastUpdatedTime_To = null;
            if (cmdletContext.LastUpdatedTime_To != null)
            {
                requestFilter_filter_LastUpdatedTime_lastUpdatedTime_To = cmdletContext.LastUpdatedTime_To.Value;
            }
            if (requestFilter_filter_LastUpdatedTime_lastUpdatedTime_To != null)
            {
                requestFilter_filter_LastUpdatedTime.To = requestFilter_filter_LastUpdatedTime_lastUpdatedTime_To.Value;
                requestFilter_filter_LastUpdatedTimeIsNull = false;
            }
             // determine if requestFilter_filter_LastUpdatedTime should be set to null
            if (requestFilter_filter_LastUpdatedTimeIsNull)
            {
                requestFilter_filter_LastUpdatedTime = null;
            }
            if (requestFilter_filter_LastUpdatedTime != null)
            {
                request.Filter.LastUpdatedTime = requestFilter_filter_LastUpdatedTime;
                requestFilterIsNull = false;
            }
            Amazon.AWSHealth.Model.DateTimeRange requestFilter_filter_StartTime = null;
            
             // populate StartTime
            var requestFilter_filter_StartTimeIsNull = true;
            requestFilter_filter_StartTime = new Amazon.AWSHealth.Model.DateTimeRange();
            System.DateTime? requestFilter_filter_StartTime_startTime_From = null;
            if (cmdletContext.StartTime_From != null)
            {
                requestFilter_filter_StartTime_startTime_From = cmdletContext.StartTime_From.Value;
            }
            if (requestFilter_filter_StartTime_startTime_From != null)
            {
                requestFilter_filter_StartTime.From = requestFilter_filter_StartTime_startTime_From.Value;
                requestFilter_filter_StartTimeIsNull = false;
            }
            System.DateTime? requestFilter_filter_StartTime_startTime_To = null;
            if (cmdletContext.StartTime_To != null)
            {
                requestFilter_filter_StartTime_startTime_To = cmdletContext.StartTime_To.Value;
            }
            if (requestFilter_filter_StartTime_startTime_To != null)
            {
                requestFilter_filter_StartTime.To = requestFilter_filter_StartTime_startTime_To.Value;
                requestFilter_filter_StartTimeIsNull = false;
            }
             // determine if requestFilter_filter_StartTime should be set to null
            if (requestFilter_filter_StartTimeIsNull)
            {
                requestFilter_filter_StartTime = null;
            }
            if (requestFilter_filter_StartTime != null)
            {
                request.Filter.StartTime = requestFilter_filter_StartTime;
                requestFilterIsNull = false;
            }
             // determine if request.Filter should be set to null
            if (requestFilterIsNull)
            {
                request.Filter = null;
            }
            if (cmdletContext.Locale != null)
            {
                request.Locale = cmdletContext.Locale;
            }
            
            // Initialize loop variants and commence piping
            System.String _nextToken = null;
            int? _emitLimit = null;
            int _retrievedSoFar = 0;
            if (AutoIterationHelpers.HasValue(cmdletContext.NextToken))
            {
                _nextToken = cmdletContext.NextToken;
            }
            if (AutoIterationHelpers.HasValue(cmdletContext.MaxResult))
            {
                // The service has a maximum page size of 100. If the user has
                // asked for more items than page max, and there is no page size
                // configured, we rely on the service ignoring the set maximum
                // and giving us 100 items back. If a page size is set, that will
                // be used to configure the pagination.
                // We'll make further calls to satisfy the user's request.
                _emitLimit = cmdletContext.MaxResult;
            }
            var _userControllingPaging = this.NoAutoIteration.IsPresent || ParameterWasBound(nameof(this.NextToken));
            
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            do
            {
                request.NextToken = _nextToken;
                if (_emitLimit.HasValue)
                {
                    int correctPageSize = AutoIterationHelpers.Min(100, _emitLimit.Value);
                    request.MaxResults = AutoIterationHelpers.ConvertEmitLimitToInt32(correctPageSize);
                }
                
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
                    int _receivedThisCall = response.Events.Count;
                    
                    _nextToken = response.NextToken;
                    _retrievedSoFar += _receivedThisCall;
                    if (_emitLimit.HasValue)
                    {
                        _emitLimit -= _receivedThisCall;
                    }
                }
                catch (Exception e)
                {
                    if (_retrievedSoFar == 0 || !_emitLimit.HasValue)
                    {
                        output = new CmdletOutput { ErrorResponse = e };
                    }
                    else
                    {
                        break;
                    }
                }
                
                ProcessOutput(output);
            } while (!_userControllingPaging && AutoIterationHelpers.HasValue(_nextToken) && (!_emitLimit.HasValue || _emitLimit.Value >= 10));
            
            
            if (useParameterSelect)
            {
                WriteObject(cmdletContext.Select(null, this));
            }
            
            
            return null;
        }
        #endif
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.AWSHealth.Model.DescribeEventsForOrganizationResponse CallAWSServiceOperation(IAmazonAWSHealth client, Amazon.AWSHealth.Model.DescribeEventsForOrganizationRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Health", "DescribeEventsForOrganization");
            try
            {
                #if DESKTOP
                return client.DescribeEventsForOrganization(request);
                #elif CORECLR
                return client.DescribeEventsForOrganizationAsync(request).GetAwaiter().GetResult();
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
            public List<System.String> Filter_AwsAccountId { get; set; }
            public System.DateTime? EndTime_From { get; set; }
            public System.DateTime? EndTime_To { get; set; }
            public List<System.String> Filter_EntityArn { get; set; }
            public List<System.String> Filter_EntityValue { get; set; }
            public List<System.String> Filter_EventStatusCode { get; set; }
            public List<System.String> Filter_EventTypeCategory { get; set; }
            public List<System.String> Filter_EventTypeCode { get; set; }
            public System.DateTime? LastUpdatedTime_From { get; set; }
            public System.DateTime? LastUpdatedTime_To { get; set; }
            public List<System.String> Filter_Region { get; set; }
            public List<System.String> Filter_Service { get; set; }
            public System.DateTime? StartTime_From { get; set; }
            public System.DateTime? StartTime_To { get; set; }
            public System.String Locale { get; set; }
            public int? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public System.Func<Amazon.AWSHealth.Model.DescribeEventsForOrganizationResponse, GetHLTHEventsForOrganizationCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Events;
        }
        
    }
}
