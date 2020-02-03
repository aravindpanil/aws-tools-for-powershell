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
    /// Sends a request to invite the specified AWS accounts to be member accounts in the
    /// behavior graph. This operation can only be called by the master account for a behavior
    /// graph. 
    /// </para><para><code>CreateMembers</code> verifies the accounts and then sends invitations to the
    /// verified accounts.
    /// </para><para>
    /// The request provides the behavior graph ARN and the list of accounts to invite.
    /// </para><para>
    /// The response separates the requested accounts into two lists:
    /// </para><ul><li><para>
    /// The accounts that <code>CreateMembers</code> was able to start the verification for.
    /// This list includes member accounts that are being verified, that have passed verification
    /// and are being sent an invitation, and that have failed verification.
    /// </para></li><li><para>
    /// The accounts that <code>CreateMembers</code> was unable to process. This list includes
    /// accounts that were already invited to be member accounts in the behavior graph.
    /// </para></li></ul>
    /// </summary>
    [Cmdlet("New", "DTCTMember", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Detective.Model.CreateMembersResponse")]
    [AWSCmdlet("Calls the Amazon Detective CreateMembers API operation.", Operation = new[] {"CreateMembers"}, SelectReturnType = typeof(Amazon.Detective.Model.CreateMembersResponse))]
    [AWSCmdletOutput("Amazon.Detective.Model.CreateMembersResponse",
        "This cmdlet returns an Amazon.Detective.Model.CreateMembersResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewDTCTMemberCmdlet : AmazonDetectiveClientCmdlet, IExecutor
    {
        
        #region Parameter Account
        /// <summary>
        /// <para>
        /// <para>The list of AWS accounts to invite to become member accounts in the behavior graph.
        /// For each invited account, the account list contains the account identifier and the
        /// AWS account root user email address.</para>
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
        [Alias("Accounts")]
        public Amazon.Detective.Model.Account[] Account { get; set; }
        #endregion
        
        #region Parameter GraphArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the behavior graph to invite the member accounts to contribute their data
        /// to.</para>
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
        public System.String GraphArn { get; set; }
        #endregion
        
        #region Parameter Message
        /// <summary>
        /// <para>
        /// <para>Customized message text to include in the invitation email message to the invited
        /// member accounts.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Message { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Detective.Model.CreateMembersResponse).
        /// Specifying the name of a property of type Amazon.Detective.Model.CreateMembersResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the GraphArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^GraphArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^GraphArn' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.GraphArn), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-DTCTMember (CreateMembers)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Detective.Model.CreateMembersResponse, NewDTCTMemberCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.GraphArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (this.Account != null)
            {
                context.Account = new List<Amazon.Detective.Model.Account>(this.Account);
            }
            #if MODULAR
            if (this.Account == null && ParameterWasBound(nameof(this.Account)))
            {
                WriteWarning("You are passing $null as a value for parameter Account which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.GraphArn = this.GraphArn;
            #if MODULAR
            if (this.GraphArn == null && ParameterWasBound(nameof(this.GraphArn)))
            {
                WriteWarning("You are passing $null as a value for parameter GraphArn which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Message = this.Message;
            
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
            var request = new Amazon.Detective.Model.CreateMembersRequest();
            
            if (cmdletContext.Account != null)
            {
                request.Accounts = cmdletContext.Account;
            }
            if (cmdletContext.GraphArn != null)
            {
                request.GraphArn = cmdletContext.GraphArn;
            }
            if (cmdletContext.Message != null)
            {
                request.Message = cmdletContext.Message;
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
        
        private Amazon.Detective.Model.CreateMembersResponse CallAWSServiceOperation(IAmazonDetective client, Amazon.Detective.Model.CreateMembersRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Detective", "CreateMembers");
            try
            {
                #if DESKTOP
                return client.CreateMembers(request);
                #elif CORECLR
                return client.CreateMembersAsync(request).GetAwaiter().GetResult();
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
            public List<Amazon.Detective.Model.Account> Account { get; set; }
            public System.String GraphArn { get; set; }
            public System.String Message { get; set; }
            public System.Func<Amazon.Detective.Model.CreateMembersResponse, NewDTCTMemberCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
