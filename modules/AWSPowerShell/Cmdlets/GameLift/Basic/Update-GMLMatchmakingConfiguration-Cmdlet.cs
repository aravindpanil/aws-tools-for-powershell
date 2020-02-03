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
    /// Updates settings for a FlexMatch matchmaking configuration. These changes affect all
    /// matches and game sessions that are created after the update. To update settings, specify
    /// the configuration name to be updated and provide the new settings. 
    /// 
    ///  
    /// <para><b>Learn more</b></para><para><a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-configuration.html">
    /// Design a FlexMatch Matchmaker</a></para><para><b>Related operations</b></para><ul><li><para><a>CreateMatchmakingConfiguration</a></para></li><li><para><a>DescribeMatchmakingConfigurations</a></para></li><li><para><a>UpdateMatchmakingConfiguration</a></para></li><li><para><a>DeleteMatchmakingConfiguration</a></para></li><li><para><a>CreateMatchmakingRuleSet</a></para></li><li><para><a>DescribeMatchmakingRuleSets</a></para></li><li><para><a>ValidateMatchmakingRuleSet</a></para></li><li><para><a>DeleteMatchmakingRuleSet</a></para></li></ul>
    /// </summary>
    [Cmdlet("Update", "GMLMatchmakingConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.GameLift.Model.MatchmakingConfiguration")]
    [AWSCmdlet("Calls the Amazon GameLift Service UpdateMatchmakingConfiguration API operation.", Operation = new[] {"UpdateMatchmakingConfiguration"}, SelectReturnType = typeof(Amazon.GameLift.Model.UpdateMatchmakingConfigurationResponse))]
    [AWSCmdletOutput("Amazon.GameLift.Model.MatchmakingConfiguration or Amazon.GameLift.Model.UpdateMatchmakingConfigurationResponse",
        "This cmdlet returns an Amazon.GameLift.Model.MatchmakingConfiguration object.",
        "The service call response (type Amazon.GameLift.Model.UpdateMatchmakingConfigurationResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class UpdateGMLMatchmakingConfigurationCmdlet : AmazonGameLiftClientCmdlet, IExecutor
    {
        
        #region Parameter AcceptanceRequired
        /// <summary>
        /// <para>
        /// <para>A flag that indicates whether a match that was created with this configuration must
        /// be accepted by the matched players. To require acceptance, set to TRUE.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? AcceptanceRequired { get; set; }
        #endregion
        
        #region Parameter AcceptanceTimeoutSecond
        /// <summary>
        /// <para>
        /// <para>The length of time (in seconds) to wait for players to accept a proposed match. If
        /// any player rejects the match or fails to accept before the timeout, the ticket continues
        /// to look for an acceptable match.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("AcceptanceTimeoutSeconds")]
        public System.Int32? AcceptanceTimeoutSecond { get; set; }
        #endregion
        
        #region Parameter AdditionalPlayerCount
        /// <summary>
        /// <para>
        /// <para>The number of player slots in a match to keep open for future players. For example,
        /// assume that the configuration's rule set specifies a match for a single 12-person
        /// team. If the additional player count is set to 2, only 10 players are initially selected
        /// for the match.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Int32? AdditionalPlayerCount { get; set; }
        #endregion
        
        #region Parameter BackfillMode
        /// <summary>
        /// <para>
        /// <para>The method that is used to backfill game sessions created with this matchmaking configuration.
        /// Specify MANUAL when your game manages backfill requests manually or does not use the
        /// match backfill feature. Specify AUTOMATIC to have GameLift create a <a>StartMatchBackfill</a>
        /// request whenever a game session has one or more open slots. Learn more about manual
        /// and automatic backfill in <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-backfill.html">Backfill
        /// Existing Games with FlexMatch</a>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.GameLift.BackfillMode")]
        public Amazon.GameLift.BackfillMode BackfillMode { get; set; }
        #endregion
        
        #region Parameter CustomEventData
        /// <summary>
        /// <para>
        /// <para>Information to add to all events related to the matchmaking configuration. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String CustomEventData { get; set; }
        #endregion
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>A descriptive label that is associated with matchmaking configuration.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter GameProperty
        /// <summary>
        /// <para>
        /// <para>A set of custom properties for a game session, formatted as key-value pairs. These
        /// properties are passed to a game server process in the <a>GameSession</a> object with
        /// a request to start a new game session (see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a Game Session</a>). This information is added to the new <a>GameSession</a> object
        /// that is created for a successful match. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("GameProperties")]
        public Amazon.GameLift.Model.GameProperty[] GameProperty { get; set; }
        #endregion
        
        #region Parameter GameSessionData
        /// <summary>
        /// <para>
        /// <para>A set of custom game session properties, formatted as a single string value. This
        /// data is passed to a game server process in the <a>GameSession</a> object with a request
        /// to start a new game session (see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a Game Session</a>). This information is added to the new <a>GameSession</a> object
        /// that is created for a successful match. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String GameSessionData { get; set; }
        #endregion
        
        #region Parameter GameSessionQueueArn
        /// <summary>
        /// <para>
        /// <para>Amazon Resource Name (<a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>)
        /// that is assigned to a GameLift game session queue resource and uniquely identifies
        /// it. ARNs are unique across all Regions. These queues are used when placing game sessions
        /// for matches that are created with this matchmaking configuration. Queues can be located
        /// in any Region.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("GameSessionQueueArns")]
        public System.String[] GameSessionQueueArn { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>A unique identifier for a matchmaking configuration to update. You can use either
        /// the configuration name or ARN value. </para>
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
        public System.String Name { get; set; }
        #endregion
        
        #region Parameter NotificationTarget
        /// <summary>
        /// <para>
        /// <para>An SNS topic ARN that is set up to receive matchmaking notifications. See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/match-notification.html">
        /// Setting up Notifications for Matchmaking</a> for more information.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String NotificationTarget { get; set; }
        #endregion
        
        #region Parameter RequestTimeoutSecond
        /// <summary>
        /// <para>
        /// <para>The maximum duration, in seconds, that a matchmaking ticket can remain in process
        /// before timing out. Requests that fail due to timing out can be resubmitted as needed.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("RequestTimeoutSeconds")]
        public System.Int32? RequestTimeoutSecond { get; set; }
        #endregion
        
        #region Parameter RuleSetName
        /// <summary>
        /// <para>
        /// <para>A unique identifier for a matchmaking rule set to use with this configuration. You
        /// can use either the rule set name or ARN value. A matchmaking configuration can only
        /// use rule sets that are defined in the same Region.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String RuleSetName { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'Configuration'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.GameLift.Model.UpdateMatchmakingConfigurationResponse).
        /// Specifying the name of a property of type Amazon.GameLift.Model.UpdateMatchmakingConfigurationResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "Configuration";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Name parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Name' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Name' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Name), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Update-GMLMatchmakingConfiguration (UpdateMatchmakingConfiguration)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.GameLift.Model.UpdateMatchmakingConfigurationResponse, UpdateGMLMatchmakingConfigurationCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Name;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AcceptanceRequired = this.AcceptanceRequired;
            context.AcceptanceTimeoutSecond = this.AcceptanceTimeoutSecond;
            context.AdditionalPlayerCount = this.AdditionalPlayerCount;
            context.BackfillMode = this.BackfillMode;
            context.CustomEventData = this.CustomEventData;
            context.Description = this.Description;
            if (this.GameProperty != null)
            {
                context.GameProperty = new List<Amazon.GameLift.Model.GameProperty>(this.GameProperty);
            }
            context.GameSessionData = this.GameSessionData;
            if (this.GameSessionQueueArn != null)
            {
                context.GameSessionQueueArn = new List<System.String>(this.GameSessionQueueArn);
            }
            context.Name = this.Name;
            #if MODULAR
            if (this.Name == null && ParameterWasBound(nameof(this.Name)))
            {
                WriteWarning("You are passing $null as a value for parameter Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.NotificationTarget = this.NotificationTarget;
            context.RequestTimeoutSecond = this.RequestTimeoutSecond;
            context.RuleSetName = this.RuleSetName;
            
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
            var request = new Amazon.GameLift.Model.UpdateMatchmakingConfigurationRequest();
            
            if (cmdletContext.AcceptanceRequired != null)
            {
                request.AcceptanceRequired = cmdletContext.AcceptanceRequired.Value;
            }
            if (cmdletContext.AcceptanceTimeoutSecond != null)
            {
                request.AcceptanceTimeoutSeconds = cmdletContext.AcceptanceTimeoutSecond.Value;
            }
            if (cmdletContext.AdditionalPlayerCount != null)
            {
                request.AdditionalPlayerCount = cmdletContext.AdditionalPlayerCount.Value;
            }
            if (cmdletContext.BackfillMode != null)
            {
                request.BackfillMode = cmdletContext.BackfillMode;
            }
            if (cmdletContext.CustomEventData != null)
            {
                request.CustomEventData = cmdletContext.CustomEventData;
            }
            if (cmdletContext.Description != null)
            {
                request.Description = cmdletContext.Description;
            }
            if (cmdletContext.GameProperty != null)
            {
                request.GameProperties = cmdletContext.GameProperty;
            }
            if (cmdletContext.GameSessionData != null)
            {
                request.GameSessionData = cmdletContext.GameSessionData;
            }
            if (cmdletContext.GameSessionQueueArn != null)
            {
                request.GameSessionQueueArns = cmdletContext.GameSessionQueueArn;
            }
            if (cmdletContext.Name != null)
            {
                request.Name = cmdletContext.Name;
            }
            if (cmdletContext.NotificationTarget != null)
            {
                request.NotificationTarget = cmdletContext.NotificationTarget;
            }
            if (cmdletContext.RequestTimeoutSecond != null)
            {
                request.RequestTimeoutSeconds = cmdletContext.RequestTimeoutSecond.Value;
            }
            if (cmdletContext.RuleSetName != null)
            {
                request.RuleSetName = cmdletContext.RuleSetName;
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
        
        private Amazon.GameLift.Model.UpdateMatchmakingConfigurationResponse CallAWSServiceOperation(IAmazonGameLift client, Amazon.GameLift.Model.UpdateMatchmakingConfigurationRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon GameLift Service", "UpdateMatchmakingConfiguration");
            try
            {
                #if DESKTOP
                return client.UpdateMatchmakingConfiguration(request);
                #elif CORECLR
                return client.UpdateMatchmakingConfigurationAsync(request).GetAwaiter().GetResult();
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
            public System.Boolean? AcceptanceRequired { get; set; }
            public System.Int32? AcceptanceTimeoutSecond { get; set; }
            public System.Int32? AdditionalPlayerCount { get; set; }
            public Amazon.GameLift.BackfillMode BackfillMode { get; set; }
            public System.String CustomEventData { get; set; }
            public System.String Description { get; set; }
            public List<Amazon.GameLift.Model.GameProperty> GameProperty { get; set; }
            public System.String GameSessionData { get; set; }
            public List<System.String> GameSessionQueueArn { get; set; }
            public System.String Name { get; set; }
            public System.String NotificationTarget { get; set; }
            public System.Int32? RequestTimeoutSecond { get; set; }
            public System.String RuleSetName { get; set; }
            public System.Func<Amazon.GameLift.Model.UpdateMatchmakingConfigurationResponse, UpdateGMLMatchmakingConfigurationCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.Configuration;
        }
        
    }
}
