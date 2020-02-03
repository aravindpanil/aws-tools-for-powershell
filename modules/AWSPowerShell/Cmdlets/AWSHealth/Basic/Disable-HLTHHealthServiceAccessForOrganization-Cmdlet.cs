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
    /// Calling this operation disables Health from working with AWS Organizations. This does
    /// not remove the Service Linked Role (SLR) from the the master account in your organization.
    /// Use the IAM console, API, or AWS CLI to remove the SLR if desired. To call this operation,
    /// you must sign in as an IAM user, assume an IAM role, or sign in as the root user (not
    /// recommended) in the organization's master account.
    /// </summary>
    [Cmdlet("Disable", "HLTHHealthServiceAccessForOrganization", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the AWS Health DisableHealthServiceAccessForOrganization API operation.", Operation = new[] {"DisableHealthServiceAccessForOrganization"}, SelectReturnType = typeof(Amazon.AWSHealth.Model.DisableHealthServiceAccessForOrganizationResponse))]
    [AWSCmdletOutput("None or Amazon.AWSHealth.Model.DisableHealthServiceAccessForOrganizationResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.AWSHealth.Model.DisableHealthServiceAccessForOrganizationResponse) can be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class DisableHLTHHealthServiceAccessForOrganizationCmdlet : AmazonAWSHealthClientCmdlet, IExecutor
    {
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AWSHealth.Model.DisableHealthServiceAccessForOrganizationResponse).
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
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
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Disable-HLTHHealthServiceAccessForOrganization (DisableHealthServiceAccessForOrganization)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AWSHealth.Model.DisableHealthServiceAccessForOrganizationResponse, DisableHLTHHealthServiceAccessForOrganizationCmdlet>(Select) ??
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
            var request = new Amazon.AWSHealth.Model.DisableHealthServiceAccessForOrganizationRequest();
            
            
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
        
        private Amazon.AWSHealth.Model.DisableHealthServiceAccessForOrganizationResponse CallAWSServiceOperation(IAmazonAWSHealth client, Amazon.AWSHealth.Model.DisableHealthServiceAccessForOrganizationRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Health", "DisableHealthServiceAccessForOrganization");
            try
            {
                #if DESKTOP
                return client.DisableHealthServiceAccessForOrganization(request);
                #elif CORECLR
                return client.DisableHealthServiceAccessForOrganizationAsync(request).GetAwaiter().GetResult();
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
            public System.Func<Amazon.AWSHealth.Model.DisableHealthServiceAccessForOrganizationResponse, DisableHLTHHealthServiceAccessForOrganizationCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}
