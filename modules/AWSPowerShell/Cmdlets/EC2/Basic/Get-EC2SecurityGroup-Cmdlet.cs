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
using Amazon.EC2;
using Amazon.EC2.Model;

namespace Amazon.PowerShell.Cmdlets.EC2
{
    /// <summary>
    /// Describes the specified security groups or all of your security groups.
    /// 
    ///  
    /// <para>
    /// A security group is for use with instances either in the EC2-Classic platform or in
    /// a specific VPC. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
    /// EC2 Security Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and
    /// <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
    /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para><br/><br/>This cmdlet automatically pages all available results to the pipeline - parameters related to iteration are only needed if you want to manually control the paginated output. To disable autopagination, use -NoAutoIteration.
    /// </summary>
    [Cmdlet("Get", "EC2SecurityGroup")]
    [OutputType("Amazon.EC2.Model.SecurityGroup")]
    [AWSCmdlet("Calls the Amazon Elastic Compute Cloud (EC2) DescribeSecurityGroups API operation.", Operation = new[] {"DescribeSecurityGroups"}, SelectReturnType = typeof(Amazon.EC2.Model.DescribeSecurityGroupsResponse))]
    [AWSCmdletOutput("Amazon.EC2.Model.SecurityGroup or Amazon.EC2.Model.DescribeSecurityGroupsResponse",
        "This cmdlet returns a collection of Amazon.EC2.Model.SecurityGroup objects.",
        "The service call response (type Amazon.EC2.Model.DescribeSecurityGroupsResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetEC2SecurityGroupCmdlet : AmazonEC2ClientCmdlet, IExecutor
    {
        
        #region Parameter Filter
        /// <summary>
        /// <para>
        /// <para>The filters. If using multiple filters for rules, the results include security groups
        /// for which any combination of rules - not necessarily a single rule - match all filters.</para><ul><li><para><code>description</code> - The description of the security group.</para></li><li><para><code>egress.ip-permission.cidr</code> - An IPv4 CIDR block for an outbound security
        /// group rule.</para></li><li><para><code>egress.ip-permission.from-port</code> - For an outbound rule, the start of
        /// port range for the TCP and UDP protocols, or an ICMP type number.</para></li><li><para><code>egress.ip-permission.group-id</code> - The ID of a security group that has
        /// been referenced in an outbound security group rule.</para></li><li><para><code>egress.ip-permission.group-name</code> - The name of a security group that
        /// has been referenced in an outbound security group rule.</para></li><li><para><code>egress.ip-permission.ipv6-cidr</code> - An IPv6 CIDR block for an outbound
        /// security group rule.</para></li><li><para><code>egress.ip-permission.prefix-list-id</code> - The ID (prefix) of the AWS service
        /// to which a security group rule allows outbound access.</para></li><li><para><code>egress.ip-permission.protocol</code> - The IP protocol for an outbound security
        /// group rule (<code>tcp</code> | <code>udp</code> | <code>icmp</code> or a protocol
        /// number).</para></li><li><para><code>egress.ip-permission.to-port</code> - For an outbound rule, the end of port
        /// range for the TCP and UDP protocols, or an ICMP code.</para></li><li><para><code>egress.ip-permission.user-id</code> - The ID of an AWS account that has been
        /// referenced in an outbound security group rule.</para></li><li><para><code>group-id</code> - The ID of the security group. </para></li><li><para><code>group-name</code> - The name of the security group.</para></li><li><para><code>ip-permission.cidr</code> - An IPv4 CIDR block for an inbound security group
        /// rule.</para></li><li><para><code>ip-permission.from-port</code> - For an inbound rule, the start of port range
        /// for the TCP and UDP protocols, or an ICMP type number.</para></li><li><para><code>ip-permission.group-id</code> - The ID of a security group that has been referenced
        /// in an inbound security group rule.</para></li><li><para><code>ip-permission.group-name</code> - The name of a security group that has been
        /// referenced in an inbound security group rule.</para></li><li><para><code>ip-permission.ipv6-cidr</code> - An IPv6 CIDR block for an inbound security
        /// group rule.</para></li><li><para><code>ip-permission.prefix-list-id</code> - The ID (prefix) of the AWS service from
        /// which a security group rule allows inbound access.</para></li><li><para><code>ip-permission.protocol</code> - The IP protocol for an inbound security group
        /// rule (<code>tcp</code> | <code>udp</code> | <code>icmp</code> or a protocol number).</para></li><li><para><code>ip-permission.to-port</code> - For an inbound rule, the end of port range for
        /// the TCP and UDP protocols, or an ICMP code.</para></li><li><para><code>ip-permission.user-id</code> - The ID of an AWS account that has been referenced
        /// in an inbound security group rule.</para></li><li><para><code>owner-id</code> - The AWS account ID of the owner of the security group.</para></li><li><para><code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.</para></li><li><para><code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.</para></li><li><para><code>vpc-id</code> - The ID of the VPC specified when the security group was created.</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 1, ValueFromPipelineByPropertyName = true)]
        [Alias("Filters")]
        public Amazon.EC2.Model.Filter[] Filter { get; set; }
        #endregion
        
        #region Parameter GroupId
        /// <summary>
        /// <para>
        /// <para>The IDs of the security groups. Required for security groups in a nondefault VPC.</para><para>Default: Describes all your security groups.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        [Alias("GroupIds")]
        public System.String[] GroupId { get; set; }
        #endregion
        
        #region Parameter GroupName
        /// <summary>
        /// <para>
        /// <para>[EC2-Classic and default VPC only] The names of the security groups. You can specify
        /// either the security group name or the security group ID. For security groups in a
        /// nondefault VPC, use the <code>group-name</code> filter to describe security groups
        /// by name.</para><para>Default: Describes all your security groups.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("GroupNames")]
        public System.String[] GroupName { get; set; }
        #endregion
        
        #region Parameter MaxResult
        /// <summary>
        /// <para>
        /// <para>The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another request with the returned <code>NextToken</code> value. This
        /// value can be between 5 and 1000. If this parameter is not specified, then all results
        /// are returned.</para>
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
        /// <para>The token to request the next page of results.</para>
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
        /// Use the -Select parameter to control the cmdlet output. The default value is 'SecurityGroups'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.EC2.Model.DescribeSecurityGroupsResponse).
        /// Specifying the name of a property of type Amazon.EC2.Model.DescribeSecurityGroupsResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "SecurityGroups";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the GroupId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^GroupId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^GroupId' instead. This parameter will be removed in a future version.")]
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
                context.Select = CreateSelectDelegate<Amazon.EC2.Model.DescribeSecurityGroupsResponse, GetEC2SecurityGroupCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.GroupId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.Filter != null)
            {
                context.Filter = new List<Amazon.EC2.Model.Filter>(this.Filter);
            }
            if (this.GroupId != null)
            {
                context.GroupId = new List<System.String>(this.GroupId);
            }
            if (this.GroupName != null)
            {
                context.GroupName = new List<System.String>(this.GroupName);
            }
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
            var request = new Amazon.EC2.Model.DescribeSecurityGroupsRequest();
            
            if (cmdletContext.Filter != null)
            {
                request.Filters = cmdletContext.Filter;
            }
            if (cmdletContext.GroupId != null)
            {
                request.GroupIds = cmdletContext.GroupId;
            }
            if (cmdletContext.GroupName != null)
            {
                request.GroupNames = cmdletContext.GroupName;
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
            var request = new Amazon.EC2.Model.DescribeSecurityGroupsRequest();
            if (cmdletContext.Filter != null)
            {
                request.Filters = cmdletContext.Filter;
            }
            if (cmdletContext.GroupId != null)
            {
                request.GroupIds = cmdletContext.GroupId;
            }
            if (cmdletContext.GroupName != null)
            {
                request.GroupNames = cmdletContext.GroupName;
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
                // The service has a maximum page size of 1000. If the user has
                // asked for more items than page max, and there is no page size
                // configured, we rely on the service ignoring the set maximum
                // and giving us 1000 items back. If a page size is set, that will
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
                    int correctPageSize = Math.Min(1000, _emitLimit.Value);
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
                    int _receivedThisCall = response.SecurityGroups.Count;
                    
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
            } while (!_userControllingPaging && AutoIterationHelpers.HasValue(_nextToken) && (!_emitLimit.HasValue || _emitLimit.Value >= 5));
            
            
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
        
        private Amazon.EC2.Model.DescribeSecurityGroupsResponse CallAWSServiceOperation(IAmazonEC2 client, Amazon.EC2.Model.DescribeSecurityGroupsRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Elastic Compute Cloud (EC2)", "DescribeSecurityGroups");
            try
            {
                #if DESKTOP
                return client.DescribeSecurityGroups(request);
                #elif CORECLR
                return client.DescribeSecurityGroupsAsync(request).GetAwaiter().GetResult();
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
            public List<Amazon.EC2.Model.Filter> Filter { get; set; }
            public List<System.String> GroupId { get; set; }
            public List<System.String> GroupName { get; set; }
            public int? MaxResult { get; set; }
            public System.String NextToken { get; set; }
            public System.Func<Amazon.EC2.Model.DescribeSecurityGroupsResponse, GetEC2SecurityGroupCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.SecurityGroups;
        }
        
    }
}
