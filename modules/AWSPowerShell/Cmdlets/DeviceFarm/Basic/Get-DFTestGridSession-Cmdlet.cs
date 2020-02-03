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
    /// A session is an instance of a browser created through a <code>RemoteWebDriver</code>
    /// with the URL from <a>CreateTestGridUrlResult$url</a>. You can use the following to
    /// look up sessions:
    /// 
    ///  <ul><li><para>
    /// The session ARN (<a>GetTestGridSessionRequest$sessionArn</a>).
    /// </para></li><li><para>
    /// The project ARN and a session ID (<a>GetTestGridSessionRequest$projectArn</a> and
    /// <a>GetTestGridSessionRequest$sessionId</a>).
    /// </para></li></ul>
    /// </summary>
    [Cmdlet("Get", "DFTestGridSession")]
    [OutputType("Amazon.DeviceFarm.Model.TestGridSession")]
    [AWSCmdlet("Calls the AWS Device Farm GetTestGridSession API operation.", Operation = new[] {"GetTestGridSession"}, SelectReturnType = typeof(Amazon.DeviceFarm.Model.GetTestGridSessionResponse))]
    [AWSCmdletOutput("Amazon.DeviceFarm.Model.TestGridSession or Amazon.DeviceFarm.Model.GetTestGridSessionResponse",
        "This cmdlet returns an Amazon.DeviceFarm.Model.TestGridSession object.",
        "The service call response (type Amazon.DeviceFarm.Model.GetTestGridSessionResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetDFTestGridSessionCmdlet : AmazonDeviceFarmClientCmdlet, IExecutor
    {
        
        #region Parameter ProjectArn
        /// <summary>
        /// <para>
        /// <para>The ARN for the project that this session belongs to. See <a>CreateTestGridProject</a>
        /// and <a>ListTestGridProjects</a>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ProjectArn { get; set; }
        #endregion
        
        #region Parameter SessionArn
        /// <summary>
        /// <para>
        /// <para>An ARN that uniquely identifies a <a>TestGridSession</a>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String SessionArn { get; set; }
        #endregion
        
        #region Parameter SessionId
        /// <summary>
        /// <para>
        /// <para>An ID associated with this session.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String SessionId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'TestGridSession'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.DeviceFarm.Model.GetTestGridSessionResponse).
        /// Specifying the name of a property of type Amazon.DeviceFarm.Model.GetTestGridSessionResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "TestGridSession";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the SessionArn parameter.
        /// The -PassThru parameter is deprecated, use -Select '^SessionArn' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^SessionArn' instead. This parameter will be removed in a future version.")]
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
                context.Select = CreateSelectDelegate<Amazon.DeviceFarm.Model.GetTestGridSessionResponse, GetDFTestGridSessionCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.SessionArn;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ProjectArn = this.ProjectArn;
            context.SessionArn = this.SessionArn;
            context.SessionId = this.SessionId;
            
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
            var request = new Amazon.DeviceFarm.Model.GetTestGridSessionRequest();
            
            if (cmdletContext.ProjectArn != null)
            {
                request.ProjectArn = cmdletContext.ProjectArn;
            }
            if (cmdletContext.SessionArn != null)
            {
                request.SessionArn = cmdletContext.SessionArn;
            }
            if (cmdletContext.SessionId != null)
            {
                request.SessionId = cmdletContext.SessionId;
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
        
        private Amazon.DeviceFarm.Model.GetTestGridSessionResponse CallAWSServiceOperation(IAmazonDeviceFarm client, Amazon.DeviceFarm.Model.GetTestGridSessionRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Device Farm", "GetTestGridSession");
            try
            {
                #if DESKTOP
                return client.GetTestGridSession(request);
                #elif CORECLR
                return client.GetTestGridSessionAsync(request).GetAwaiter().GetResult();
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
            public System.String ProjectArn { get; set; }
            public System.String SessionArn { get; set; }
            public System.String SessionId { get; set; }
            public System.Func<Amazon.DeviceFarm.Model.GetTestGridSessionResponse, GetDFTestGridSessionCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.TestGridSession;
        }
        
    }
}
