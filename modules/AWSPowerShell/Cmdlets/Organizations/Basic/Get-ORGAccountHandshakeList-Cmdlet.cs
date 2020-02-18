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
using Amazon.Organizations;
using Amazon.Organizations.Model;

namespace Amazon.PowerShell.Cmdlets.ORG
{
    /// <summary>
    /// Lists the current handshakes that are associated with the account of the requesting
    /// user.
    /// 
    ///  
    /// <para>
    /// Handshakes that are <code>ACCEPTED</code>, <code>DECLINED</code>, or <code>CANCELED</code>
    /// appear in the results of this API for only 30 days after changing to that state. After
    /// that, they're deleted and no longer accessible.
    /// </para><note><para>
    /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
    /// value when calling a <code>List*</code> operation. These operations can occasionally
    /// return an empty set of results even when there are more results available. The <code>NextToken</code>
    /// response parameter value is <code>null</code><i>only</i> when there are no more results
    /// to display.
    /// </para></note><para>
    /// This operation can be called from any account in the organization.
    /// </para><br/><br/>This cmdlet automatically pages all available results to the pipeline - parameters related to iteration are only needed if you want to manually control the paginated output. To disable autopagination, use -NoAutoIteration.
    /// </summary>
    [Cmdlet("Get", "ORGAccountHandshakeList")]
    [OutputType("Amazon.Organizations.Model.Handshake")]
    [AWSCmdlet("Calls the AWS Organizations ListHandshakesForAccount API operation.", Operation = new[] {"ListHandshakesForAccount"}, SelectReturnType = typeof(Amazon.Organizations.Model.ListHandshakesForAccountResponse))]
    [AWSCmdletOutput("Amazon.Organizations.Model.Handshake or Amazon.Organizations.Model.ListHandshakesForAccountResponse",
        "This cmdlet returns a collection of Amazon.Organizations.Model.Handshake objects.",
        "The service call response (type Amazon.Organizations.Model.ListHandshakesForAccountResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetORGAccountHandshakeListCmdlet : AmazonOrganizationsClientCmdlet, IExecutor
    {
        
        #region Parameter Filter_ActionType
        /// <summary>
        /// <para>
        /// <para>Specifies the type of handshake action.</para><para>If you specify <code>ActionType</code>, you cannot also specify <code>ParentHandshakeId</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Organizations.ActionType")]
        public Amazon.Organizations.ActionType Filter_ActionType { get; set; }
        #endregion
        
        #region Parameter Filter_ParentHandshakeId
        /// <summary>
        /// <para>
        /// <para>Specifies the parent handshake. Only used for handshake types that are a child of
        /// another type.</para><para>If you specify <code>ParentHandshakeId</code>, you cannot also specify <code>ActionType</code>.</para><para>The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for handshake ID string
        /// requires "h-" followed by from 8 to 32 lower-case letters or digits.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Filter_ParentHandshakeId { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>(Optional) Use this to limit the number of results you want included per page in the
        /// response. If you do not include this parameter, it defaults to a value that is specific
        /// to the operation. If additional items exist beyond the maximum you specify, the <code>NextToken</code>
        /// response element is present and has a value (is not null). Include that value as the
        /// <code>NextToken</code> request parameter in the next call to the operation to get
        /// the next part of the results. Note that Organizations might return fewer results than
        /// the maximum even when there are more results available. You should check <code>NextToken</code>
        /// after every operation to ensure that you receive all of the results.</para>
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
        /// <para>Use this parameter if you receive a <code>NextToken</code> response in a previous
        /// request that indicates that there is more output available. Set it to the value of
        /// the previous call's <code>NextToken</code> response to indicate where the output should
        /// continue from.</para>
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
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Handshakes'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Organizations.Model.ListHandshakesForAccountResponse).
        /// Specifying the name of a property of type Amazon.Organizations.Model.ListHandshakesForAccountResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Handshakes";
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
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Organizations.Model.ListHandshakesForAccountResponse, GetORGAccountHandshakeListCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            context.Filter_ActionType = this.Filter_ActionType;
            context.Filter_ParentHandshakeId = this.Filter_ParentHandshakeId;
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
            var useParameterSelect = this.Select.StartsWith("^");
            
            // create request and set iteration invariants
            var request = new Amazon.Organizations.Model.ListHandshakesForAccountRequest();
            
            
             // populate Filter
            var requestFilterIsNull = true;
            request.Filter = new Amazon.Organizations.Model.HandshakeFilter();
            Amazon.Organizations.ActionType requestFilter_filter_ActionType = null;
            if (cmdletContext.Filter_ActionType != null)
            {
                requestFilter_filter_ActionType = cmdletContext.Filter_ActionType;
            }
            if (requestFilter_filter_ActionType != null)
            {
                request.Filter.ActionType = requestFilter_filter_ActionType;
                requestFilterIsNull = false;
            }
            System.String requestFilter_filter_ParentHandshakeId = null;
            if (cmdletContext.Filter_ParentHandshakeId != null)
            {
                requestFilter_filter_ParentHandshakeId = cmdletContext.Filter_ParentHandshakeId;
            }
            if (requestFilter_filter_ParentHandshakeId != null)
            {
                request.Filter.ParentHandshakeId = requestFilter_filter_ParentHandshakeId;
                requestFilterIsNull = false;
            }
             // determine if request.Filter should be set to null
            if (requestFilterIsNull)
            {
                request.Filter = null;
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
            var useParameterSelect = this.Select.StartsWith("^");
            
            // create request and set iteration invariants
            var request = new Amazon.Organizations.Model.ListHandshakesForAccountRequest();
            
             // populate Filter
            var requestFilterIsNull = true;
            request.Filter = new Amazon.Organizations.Model.HandshakeFilter();
            Amazon.Organizations.ActionType requestFilter_filter_ActionType = null;
            if (cmdletContext.Filter_ActionType != null)
            {
                requestFilter_filter_ActionType = cmdletContext.Filter_ActionType;
            }
            if (requestFilter_filter_ActionType != null)
            {
                request.Filter.ActionType = requestFilter_filter_ActionType;
                requestFilterIsNull = false;
            }
            System.String requestFilter_filter_ParentHandshakeId = null;
            if (cmdletContext.Filter_ParentHandshakeId != null)
            {
                requestFilter_filter_ParentHandshakeId = cmdletContext.Filter_ParentHandshakeId;
            }
            if (requestFilter_filter_ParentHandshakeId != null)
            {
                request.Filter.ParentHandshakeId = requestFilter_filter_ParentHandshakeId;
                requestFilterIsNull = false;
            }
             // determine if request.Filter should be set to null
            if (requestFilterIsNull)
            {
                request.Filter = null;
            }
            
            // Initialize loop variants and commence piping
            System.String _nextToken = null;
            int? _emitLimit = null;
            int _retrievedSoFar = 0;
            if (AutoIterationHelpers.HasValue(cmdletContext.NextToken))
            {
                _nextToken = cmdletContext.NextToken;
            }
            if (cmdletContext.MaxResult.HasValue)
            {
                // The service has a maximum page size of 20. If the user has
                // asked for more items than page max, and there is no page size
                // configured, we rely on the service ignoring the set maximum
                // and giving us 20 items back. If a page size is set, that will
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
                    int correctPageSize = Math.Min(20, _emitLimit.Value);
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
                    int _receivedThisCall = response.Handshakes.Count;
                    
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
            } while (!_userControllingPaging && AutoIterationHelpers.HasValue(_nextToken) && (!_emitLimit.HasValue || _emitLimit.Value >= 1));
            
            
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
        
        private Amazon.Organizations.Model.ListHandshakesForAccountResponse CallAWSServiceOperation(IAmazonOrganizations client, Amazon.Organizations.Model.ListHandshakesForAccountRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Organizations", "ListHandshakesForAccount");
            try
            {
                #if DESKTOP
                return client.ListHandshakesForAccount(request);
                #elif CORECLR
                return client.ListHandshakesForAccountAsync(request).GetAwaiter().GetResult();
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
            public Amazon.Organizations.ActionType Filter_ActionType { get; set; }
            public System.String Filter_ParentHandshakeId { get; set; }
            public int? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public System.Func<Amazon.Organizations.Model.ListHandshakesForAccountResponse, GetORGAccountHandshakeListCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Handshakes;
        }
        
    }
}
