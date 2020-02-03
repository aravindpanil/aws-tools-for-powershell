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
using Amazon.DeviceFarm;
using Amazon.DeviceFarm.Model;

namespace Amazon.PowerShell.Cmdlets.DF
{
    /// <summary>
    /// Immediately purchases offerings for an AWS account. Offerings renew with the latest
    /// total purchased quantity for an offering, unless the renewal was overridden. The API
    /// returns a <code>NotEligible</code> error if the user is not permitted to invoke the
    /// operation. If you must be able to invoke this operation, contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>.
    /// </summary>
    [Cmdlet("New", "DFOfferingPurchase", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.DeviceFarm.Model.OfferingTransaction")]
    [AWSCmdlet("Calls the AWS Device Farm PurchaseOffering API operation.", Operation = new[] {"PurchaseOffering"}, SelectReturnType = typeof(Amazon.DeviceFarm.Model.PurchaseOfferingResponse))]
    [AWSCmdletOutput("Amazon.DeviceFarm.Model.OfferingTransaction or Amazon.DeviceFarm.Model.PurchaseOfferingResponse",
        "This cmdlet returns an Amazon.DeviceFarm.Model.OfferingTransaction object.",
        "The service call response (type Amazon.DeviceFarm.Model.PurchaseOfferingResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewDFOfferingPurchaseCmdlet : AmazonDeviceFarmClientCmdlet, IExecutor
    {
        
        #region Parameter OfferingId
        /// <summary>
        /// <para>
        /// <para>The ID of the offering.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String OfferingId { get; set; }
        #endregion
        
        #region Parameter OfferingPromotionId
        /// <summary>
        /// <para>
        /// <para>The ID of the offering promotion to be applied to the purchase.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String OfferingPromotionId { get; set; }
        #endregion
        
        #region Parameter Quantity
        /// <summary>
        /// <para>
        /// <para>The number of device slots to purchase in an offering request.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? Quantity { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'OfferingTransaction'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.DeviceFarm.Model.PurchaseOfferingResponse).
        /// Specifying the name of a property of type Amazon.DeviceFarm.Model.PurchaseOfferingResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "OfferingTransaction";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the OfferingId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^OfferingId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^OfferingId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.OfferingId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-DFOfferingPurchase (PurchaseOffering)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.DeviceFarm.Model.PurchaseOfferingResponse, NewDFOfferingPurchaseCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.OfferingId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.OfferingId = this.OfferingId;
            context.OfferingPromotionId = this.OfferingPromotionId;
            context.Quantity = this.Quantity;
            
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
            var request = new Amazon.DeviceFarm.Model.PurchaseOfferingRequest();
            
            if (cmdletContext.OfferingId != null)
            {
                request.OfferingId = cmdletContext.OfferingId;
            }
            if (cmdletContext.OfferingPromotionId != null)
            {
                request.OfferingPromotionId = cmdletContext.OfferingPromotionId;
            }
            if (cmdletContext.Quantity != null)
            {
                request.Quantity = cmdletContext.Quantity.Value;
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
        
        private Amazon.DeviceFarm.Model.PurchaseOfferingResponse CallAWSServiceOperation(IAmazonDeviceFarm client, Amazon.DeviceFarm.Model.PurchaseOfferingRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Device Farm", "PurchaseOffering");
            try
            {
                #if DESKTOP
                return client.PurchaseOffering(request);
                #elif CORECLR
                return client.PurchaseOfferingAsync(request).GetAwaiter().GetResult();
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
            public System.String OfferingId { get; set; }
            public System.String OfferingPromotionId { get; set; }
            public System.Int32? Quantity { get; set; }
            public System.Func<Amazon.DeviceFarm.Model.PurchaseOfferingResponse, NewDFOfferingPurchaseCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.OfferingTransaction;
        }
        
    }
}
