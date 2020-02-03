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
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace Amazon.PowerShell.Cmdlets.SSM
{
    /// <summary>
    /// Generates an activation code and activation ID you can use to register your on-premises
    /// server or virtual machine (VM) with Systems Manager. Registering these machines with
    /// Systems Manager makes it possible to manage them using Systems Manager capabilities.
    /// You use the activation code and ID when installing SSM Agent on machines in your hybrid
    /// environment. For more information about requirements for managing on-premises instances
    /// and VMs using Systems Manager, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-managedinstances.html">Setting
    /// Up AWS Systems Manager for Hybrid Environments</a> in the <i>AWS Systems Manager User
    /// Guide</i>. 
    /// 
    ///  <note><para>
    /// On-premises servers or VMs that are registered with Systems Manager and Amazon EC2
    /// instances that you manage with Systems Manager are all called <i>managed instances</i>.
    /// </para></note>
    /// </summary>
    [Cmdlet("New", "SSMActivation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.SimpleSystemsManagement.Model.CreateActivationResponse")]
    [AWSCmdlet("Calls the AWS Systems Manager CreateActivation API operation.", Operation = new[] {"CreateActivation"}, SelectReturnType = typeof(Amazon.SimpleSystemsManagement.Model.CreateActivationResponse))]
    [AWSCmdletOutput("Amazon.SimpleSystemsManagement.Model.CreateActivationResponse",
        "This cmdlet returns an Amazon.SimpleSystemsManagement.Model.CreateActivationResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewSSMActivationCmdlet : AmazonSimpleSystemsManagementClientCmdlet, IExecutor
    {
        
        #region Parameter DefaultInstanceName
        /// <summary>
        /// <para>
        /// <para>The name of the registered, managed instance as it will appear in the Systems Manager
        /// console or when you use the AWS command line tools to list Systems Manager resources.</para><important><para>Do not enter personally identifiable information in this field.</para></important>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String DefaultInstanceName { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>A user-defined description of the resource that you want to register with Systems
        /// Manager. </para><important><para>Do not enter personally identifiable information in this field.</para></important>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter ExpirationDate
        /// <summary>
        /// <para>
        /// <para>The date by which this activation request should expire. The default value is 24 hours.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.DateTime? ExpirationDate { get; set; }
        #endregion
        
        #region Parameter IamRole
        /// <summary>
        /// <para>
        /// <para>The Amazon Identity and Access Management (IAM) role that you want to assign to the
        /// managed instance. This IAM role must provide AssumeRole permissions for the Systems
        /// Manager service principal <code>ssm.amazonaws.com</code>. For more information, see
        /// <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-service-role.html">Create
        /// an IAM Service Role for a Hybrid Environment</a> in the <i>AWS Systems Manager User
        /// Guide</i>.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String IamRole { get; set; }
        #endregion
        
        #region Parameter RegistrationLimit
        /// <summary>
        /// <para>
        /// <para>Specify the maximum number of managed instances you want to register. The default
        /// value is 1 instance.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? RegistrationLimit { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>Optional metadata that you assign to a resource. Tags enable you to categorize a resource
        /// in different ways, such as by purpose, owner, or environment. For example, you might
        /// want to tag an activation to identify which servers or virtual machines (VMs) in your
        /// on-premises environment you intend to activate. In this case, you could specify the
        /// following key name/value pairs:</para><ul><li><para><code>Key=OS,Value=Windows</code></para></li><li><para><code>Key=Environment,Value=Production</code></para></li></ul><important><para>When you install SSM Agent on your on-premises servers and VMs, you specify an activation
        /// ID and code. When you specify the activation ID and code, tags assigned to the activation
        /// are automatically applied to the on-premises servers or VMs.</para></important><para>You can't add tags to or delete tags from an existing activation. You can tag your
        /// on-premises servers and VMs after they connect to Systems Manager for the first time
        /// and are assigned a managed instance ID. This means they are listed in the AWS Systems
        /// Manager console with an ID that is prefixed with "mi-". For information about how
        /// to add tags to your managed instances, see <a>AddTagsToResource</a>. For information
        /// about how to remove tags from your managed instances, see <a>RemoveTagsFromResource</a>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.SimpleSystemsManagement.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SimpleSystemsManagement.Model.CreateActivationResponse).
        /// Specifying the name of a property of type Amazon.SimpleSystemsManagement.Model.CreateActivationResponse will result in that property being returned.
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.DefaultInstanceName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-SSMActivation (CreateActivation)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SimpleSystemsManagement.Model.CreateActivationResponse, NewSSMActivationCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            context.DefaultInstanceName = this.DefaultInstanceName;
            context.Description = this.Description;
            context.ExpirationDate = this.ExpirationDate;
            context.IamRole = this.IamRole;
            #if MODULAR
            if (this.IamRole == null && ParameterWasBound(nameof(this.IamRole)))
            {
                WriteWarning("You are passing $null as a value for parameter IamRole which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.RegistrationLimit = this.RegistrationLimit;
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.SimpleSystemsManagement.Model.Tag>(this.Tag);
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
            var request = new Amazon.SimpleSystemsManagement.Model.CreateActivationRequest();
            
            if (cmdletContext.DefaultInstanceName != null)
            {
                request.DefaultInstanceName = cmdletContext.DefaultInstanceName;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.ExpirationDate != null)
            {
                request.ExpirationDate = cmdletContext.ExpirationDate.Value;
            }
            if (cmdletContext.IamRole != null)
            {
                request.IamRole = cmdletContext.IamRole;
            }
            if (cmdletContext.RegistrationLimit != null)
            {
                request.RegistrationLimit = cmdletContext.RegistrationLimit.Value;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
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
        
        private Amazon.SimpleSystemsManagement.Model.CreateActivationResponse CallAWSServiceOperation(IAmazonSimpleSystemsManagement client, Amazon.SimpleSystemsManagement.Model.CreateActivationRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Systems Manager", "CreateActivation");
            try
            {
                #if DESKTOP
                return client.CreateActivation(request);
                #elif CORECLR
                return client.CreateActivationAsync(request).GetAwaiter().GetResult();
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
            public System.String DefaultInstanceName { get; set; }
            public System.String Description { get; set; }
            public System.DateTime? ExpirationDate { get; set; }
            public System.String IamRole { get; set; }
            public System.Int32? RegistrationLimit { get; set; }
            public List<Amazon.SimpleSystemsManagement.Model.Tag> Tag { get; set; }
            public System.Func<Amazon.SimpleSystemsManagement.Model.CreateActivationResponse, NewSSMActivationCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
