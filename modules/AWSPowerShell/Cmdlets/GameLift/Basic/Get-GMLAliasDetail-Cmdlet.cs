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
using Amazon.GameLift;
using Amazon.GameLift.Model;

namespace Amazon.PowerShell.Cmdlets.GML
{
    /// <summary>
    /// Retrieves properties for an alias. This operation returns all alias metadata and settings.
    /// To get an alias's target fleet ID only, use <code>ResolveAlias</code>. 
    /// 
    ///  
    /// <para>
    /// To get alias properties, specify the alias ID. If successful, the requested alias
    /// record is returned.
    /// </para><ul><li><para><a>CreateAlias</a></para></li><li><para><a>ListAliases</a></para></li><li><para><a>DescribeAlias</a></para></li><li><para><a>UpdateAlias</a></para></li><li><para><a>DeleteAlias</a></para></li><li><para><a>ResolveAlias</a></para></li></ul>
    /// </summary>
    [Cmdlet("Get", "GMLAliasDetail")]
    [OutputType("Amazon.GameLift.Model.Alias")]
    [AWSCmdlet("Calls the Amazon GameLift Service DescribeAlias API operation.", Operation = new[] {"DescribeAlias"}, SelectReturnType = typeof(Amazon.GameLift.Model.DescribeAliasResponse))]
    [AWSCmdletOutput("Amazon.GameLift.Model.Alias or Amazon.GameLift.Model.DescribeAliasResponse",
        "This cmdlet returns an Amazon.GameLift.Model.Alias object.",
        "The service call response (type Amazon.GameLift.Model.DescribeAliasResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetGMLAliasDetailCmdlet : AmazonGameLiftClientCmdlet, IExecutor
    {
        
        #region Parameter AliasId
        /// <summary>
        /// <para>
        /// <para>The unique identifier for the fleet alias that you want to retrieve. You can use either
        /// the alias ID or ARN value. </para>
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
        public System.String AliasId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Alias'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.GameLift.Model.DescribeAliasResponse).
        /// Specifying the name of a property of type Amazon.GameLift.Model.DescribeAliasResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Alias";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the AliasId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^AliasId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^AliasId' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
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
                context.Select = CreateSelectDelegate<Amazon.GameLift.Model.DescribeAliasResponse, GetGMLAliasDetailCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.AliasId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AliasId = this.AliasId;
            #if MODULAR
            if (this.AliasId == null && ParameterWasBound(nameof(this.AliasId)))
            {
                WriteWarning("You are passing $null as a value for parameter AliasId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.GameLift.Model.DescribeAliasRequest();
            
            if (cmdletContext.AliasId != null)
            {
                request.AliasId = cmdletContext.AliasId;
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
        
        private Amazon.GameLift.Model.DescribeAliasResponse CallAWSServiceOperation(IAmazonGameLift client, Amazon.GameLift.Model.DescribeAliasRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon GameLift Service", "DescribeAlias");
            try
            {
                #if DESKTOP
                return client.DescribeAlias(request);
                #elif CORECLR
                return client.DescribeAliasAsync(request).GetAwaiter().GetResult();
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
            public System.String AliasId { get; set; }
            public System.Func<Amazon.GameLift.Model.DescribeAliasResponse, GetGMLAliasDetailCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Alias;
        }
        
    }
}
