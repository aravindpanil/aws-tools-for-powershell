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
using Amazon.Detective;
using Amazon.Detective.Model;

namespace Amazon.PowerShell.Cmdlets.DTCT
{
    /// <summary>
    /// Amazon Detective is currently in preview.
    /// 
    ///  
    /// <para>
    /// Creates a new behavior graph for the calling account, and sets that account as the
    /// master account. This operation is called by the account that is enabling Detective.
    /// </para><para>
    /// The operation also enables Detective for the calling account in the currently selected
    /// Region. It returns the ARN of the new behavior graph.
    /// </para><para><code>CreateGraph</code> triggers a process to create the corresponding data tables
    /// for the new behavior graph.
    /// </para><para>
    /// An account can only be the master account for one behavior graph within a Region.
    /// If the same account calls <code>CreateGraph</code> with the same master account, it
    /// always returns the same behavior graph ARN. It does not create a new behavior graph.
    /// </para>
    /// </summary>
    [Cmdlet("New", "DTCTGraph", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the Amazon Detective CreateGraph API operation.", Operation = new[] {"CreateGraph"}, SelectReturnType = typeof(Amazon.Detective.Model.CreateGraphResponse))]
    [AWSCmdletOutput("System.String or Amazon.Detective.Model.CreateGraphResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.Detective.Model.CreateGraphResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewDTCTGraphCmdlet : AmazonDetectiveClientCmdlet, IExecutor
    {
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'GraphArn'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Detective.Model.CreateGraphResponse).
        /// Specifying the name of a property of type Amazon.Detective.Model.CreateGraphResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "GraphArn";
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
            
            var resourceIdentifiersText = string.Empty;
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-DTCTGraph (CreateGraph)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Detective.Model.CreateGraphResponse, NewDTCTGraphCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            
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
            var request = new Amazon.Detective.Model.CreateGraphRequest();
            
            
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
        
        private Amazon.Detective.Model.CreateGraphResponse CallAWSServiceOperation(IAmazonDetective client, Amazon.Detective.Model.CreateGraphRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Detective", "CreateGraph");
            try
            {
                #if DESKTOP
                return client.CreateGraph(request);
                #elif CORECLR
                return client.CreateGraphAsync(request).GetAwaiter().GetResult();
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
            public System.Func<Amazon.Detective.Model.CreateGraphResponse, NewDTCTGraphCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.GraphArn;
        }
        
    }
}
