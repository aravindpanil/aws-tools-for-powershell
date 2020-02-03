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
    /// This operation provides status information on enabling or disabling AWS Health to
    /// work with your organization. To call this operation, you must sign in as an IAM user,
    /// assume an IAM role, or sign in as the root user (not recommended) in the organization's
    /// master account.
    /// </summary>
    [Cmdlet("Get", "HLTHHealthServiceStatusForOrganization")]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the AWS Health DescribeHealthServiceStatusForOrganization API operation.", Operation = new[] {"DescribeHealthServiceStatusForOrganization"}, SelectReturnType = typeof(Amazon.AWSHealth.Model.DescribeHealthServiceStatusForOrganizationResponse))]
    [AWSCmdletOutput("System.String or Amazon.AWSHealth.Model.DescribeHealthServiceStatusForOrganizationResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.AWSHealth.Model.DescribeHealthServiceStatusForOrganizationResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetHLTHHealthServiceStatusForOrganizationCmdlet : AmazonAWSHealthClientCmdlet, IExecutor
    {
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'HealthServiceAccessStatusForOrganization'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.AWSHealth.Model.DescribeHealthServiceStatusForOrganizationResponse).
        /// Specifying the name of a property of type Amazon.AWSHealth.Model.DescribeHealthServiceStatusForOrganizationResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "HealthServiceAccessStatusForOrganization";
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.AWSHealth.Model.DescribeHealthServiceStatusForOrganizationResponse, GetHLTHHealthServiceStatusForOrganizationCmdlet>(Select) ??
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
            var request = new Amazon.AWSHealth.Model.DescribeHealthServiceStatusForOrganizationRequest();
            
            
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
        
        private Amazon.AWSHealth.Model.DescribeHealthServiceStatusForOrganizationResponse CallAWSServiceOperation(IAmazonAWSHealth client, Amazon.AWSHealth.Model.DescribeHealthServiceStatusForOrganizationRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Health", "DescribeHealthServiceStatusForOrganization");
            try
            {
                #if DESKTOP
                return client.DescribeHealthServiceStatusForOrganization(request);
                #elif CORECLR
                return client.DescribeHealthServiceStatusForOrganizationAsync(request).GetAwaiter().GetResult();
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
            public System.Func<Amazon.AWSHealth.Model.DescribeHealthServiceStatusForOrganizationResponse, GetHLTHHealthServiceStatusForOrganizationCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.HealthServiceAccessStatusForOrganization;
        }
        
    }
}
