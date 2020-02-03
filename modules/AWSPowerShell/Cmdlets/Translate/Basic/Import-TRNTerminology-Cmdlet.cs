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
using Amazon.Translate;
using Amazon.Translate.Model;

namespace Amazon.PowerShell.Cmdlets.TRN
{
    /// <summary>
    /// Creates or updates a custom terminology, depending on whether or not one already exists
    /// for the given terminology name. Importing a terminology with the same name as an existing
    /// one will merge the terminologies based on the chosen merge strategy. Currently, the
    /// only supported merge strategy is OVERWRITE, and so the imported terminology will overwrite
    /// an existing terminology of the same name.
    /// 
    ///  
    /// <para>
    /// If you import a terminology that overwrites an existing one, the new terminology take
    /// up to 10 minutes to fully propagate and be available for use in a translation due
    /// to cache policies with the DataPlane service that performs the translations.
    /// </para>
    /// </summary>
    [Cmdlet("Import", "TRNTerminology", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.Translate.Model.TerminologyProperties")]
    [AWSCmdlet("Calls the Amazon Translate ImportTerminology API operation.", Operation = new[] {"ImportTerminology"}, SelectReturnType = typeof(Amazon.Translate.Model.ImportTerminologyResponse))]
    [AWSCmdletOutput("Amazon.Translate.Model.TerminologyProperties or Amazon.Translate.Model.ImportTerminologyResponse",
        "This cmdlet returns an Amazon.Translate.Model.TerminologyProperties object.",
        "The service call response (type Amazon.Translate.Model.ImportTerminologyResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class ImportTRNTerminologyCmdlet : AmazonTranslateClientCmdlet, IExecutor
    {
        
        #region Parameter Description
        /// <summary>
        /// <para>
        /// <para>The description of the custom terminology being imported.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String Description { get; set; }
        #endregion
        
        #region Parameter TerminologyData_File
        /// <summary>
        /// <para>
        /// <para>The file containing the custom terminology data. Your version of the AWS SDK performs
        /// a Base64-encoding on this field before sending a request to the AWS service. Users
        /// of the SDK should not perform Base64-encoding themselves.</para>
        /// </para>
        /// <para>The cmdlet will automatically convert the supplied parameter of type string, string[], System.IO.FileInfo or System.IO.Stream to byte[] before supplying it to the service.</para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Amazon.PowerShell.Common.MemoryStreamParameterConverter]
        public byte[] TerminologyData_File { get; set; }
        #endregion
        
        #region Parameter TerminologyData_Format
        /// <summary>
        /// <para>
        /// <para>The data format of the custom terminology. Either CSV or TMX.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.Translate.TerminologyDataFormat")]
        public Amazon.Translate.TerminologyDataFormat TerminologyData_Format { get; set; }
        #endregion
        
        #region Parameter EncryptionKey_Id
        /// <summary>
        /// <para>
        /// <para>The Amazon Resource Name (ARN) of the encryption key being used to encrypt the custom
        /// terminology.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String EncryptionKey_Id { get; set; }
        #endregion
        
        #region Parameter MergeStrategy
        /// <summary>
        /// <para>
        /// <para>The merge strategy of the custom terminology being imported. Currently, only the OVERWRITE
        /// merge strategy is supported. In this case, the imported terminology will overwrite
        /// an existing terminology of the same name.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.Translate.MergeStrategy")]
        public Amazon.Translate.MergeStrategy MergeStrategy { get; set; }
        #endregion
        
        #region Parameter Name
        /// <summary>
        /// <para>
        /// <para>The name of the custom terminology being imported.</para>
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
        
        #region Parameter EncryptionKey_Type
        /// <summary>
        /// <para>
        /// <para>The type of encryption key used by Amazon Translate to encrypt custom terminologies.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.Translate.EncryptionKeyType")]
        public Amazon.Translate.EncryptionKeyType EncryptionKey_Type { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'TerminologyProperties'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Translate.Model.ImportTerminologyResponse).
        /// Specifying the name of a property of type Amazon.Translate.Model.ImportTerminologyResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "TerminologyProperties";
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
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Import-TRNTerminology (ImportTerminology)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Translate.Model.ImportTerminologyResponse, ImportTRNTerminologyCmdlet>(Select) ??
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
            context.Description = this.Description;
            context.EncryptionKey_Id = this.EncryptionKey_Id;
            context.EncryptionKey_Type = this.EncryptionKey_Type;
            context.MergeStrategy = this.MergeStrategy;
            #if MODULAR
            if (this.MergeStrategy == null && ParameterWasBound(nameof(this.MergeStrategy)))
            {
                WriteWarning("You are passing $null as a value for parameter MergeStrategy which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.Name = this.Name;
            #if MODULAR
            if (this.Name == null && ParameterWasBound(nameof(this.Name)))
            {
                WriteWarning("You are passing $null as a value for parameter Name which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.TerminologyData_File = this.TerminologyData_File;
            #if MODULAR
            if (this.TerminologyData_File == null && ParameterWasBound(nameof(this.TerminologyData_File)))
            {
                WriteWarning("You are passing $null as a value for parameter TerminologyData_File which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.TerminologyData_Format = this.TerminologyData_Format;
            #if MODULAR
            if (this.TerminologyData_Format == null && ParameterWasBound(nameof(this.TerminologyData_Format)))
            {
                WriteWarning("You are passing $null as a value for parameter TerminologyData_Format which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            System.IO.MemoryStream _TerminologyData_FileStream = null;
            
            try
            {
                var cmdletContext = context as CmdletContext;
                // create request
                var request = new Amazon.Translate.Model.ImportTerminologyRequest();
                
                if (cmdletContext.Description != null)
                {
                    request.Description = cmdletContext.Description;
                }
                
                 // populate EncryptionKey
                var requestEncryptionKeyIsNull = true;
                request.EncryptionKey = new Amazon.Translate.Model.EncryptionKey();
                System.String requestEncryptionKey_encryptionKey_Id = null;
                if (cmdletContext.EncryptionKey_Id != null)
                {
                    requestEncryptionKey_encryptionKey_Id = cmdletContext.EncryptionKey_Id;
                }
                if (requestEncryptionKey_encryptionKey_Id != null)
                {
                    request.EncryptionKey.Id = requestEncryptionKey_encryptionKey_Id;
                    requestEncryptionKeyIsNull = false;
                }
                Amazon.Translate.EncryptionKeyType requestEncryptionKey_encryptionKey_Type = null;
                if (cmdletContext.EncryptionKey_Type != null)
                {
                    requestEncryptionKey_encryptionKey_Type = cmdletContext.EncryptionKey_Type;
                }
                if (requestEncryptionKey_encryptionKey_Type != null)
                {
                    request.EncryptionKey.Type = requestEncryptionKey_encryptionKey_Type;
                    requestEncryptionKeyIsNull = false;
                }
                 // determine if request.EncryptionKey should be set to null
                if (requestEncryptionKeyIsNull)
                {
                    request.EncryptionKey = null;
                }
                if (cmdletContext.MergeStrategy != null)
                {
                    request.MergeStrategy = cmdletContext.MergeStrategy;
                }
                if (cmdletContext.Name != null)
                {
                    request.Name = cmdletContext.Name;
                }
                
                 // populate TerminologyData
                var requestTerminologyDataIsNull = true;
                request.TerminologyData = new Amazon.Translate.Model.TerminologyData();
                System.IO.MemoryStream requestTerminologyData_terminologyData_File = null;
                if (cmdletContext.TerminologyData_File != null)
                {
                    _TerminologyData_FileStream = new System.IO.MemoryStream(cmdletContext.TerminologyData_File);
                    requestTerminologyData_terminologyData_File = _TerminologyData_FileStream;
                }
                if (requestTerminologyData_terminologyData_File != null)
                {
                    request.TerminologyData.File = requestTerminologyData_terminologyData_File;
                    requestTerminologyDataIsNull = false;
                }
                Amazon.Translate.TerminologyDataFormat requestTerminologyData_terminologyData_Format = null;
                if (cmdletContext.TerminologyData_Format != null)
                {
                    requestTerminologyData_terminologyData_Format = cmdletContext.TerminologyData_Format;
                }
                if (requestTerminologyData_terminologyData_Format != null)
                {
                    request.TerminologyData.Format = requestTerminologyData_terminologyData_Format;
                    requestTerminologyDataIsNull = false;
                }
                 // determine if request.TerminologyData should be set to null
                if (requestTerminologyDataIsNull)
                {
                    request.TerminologyData = null;
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
            finally
            {
                if( _TerminologyData_FileStream != null)
                {
                    _TerminologyData_FileStream.Dispose();
                }
            }
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.Translate.Model.ImportTerminologyResponse CallAWSServiceOperation(IAmazonTranslate client, Amazon.Translate.Model.ImportTerminologyRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Translate", "ImportTerminology");
            try
            {
                #if DESKTOP
                return client.ImportTerminology(request);
                #elif CORECLR
                return client.ImportTerminologyAsync(request).GetAwaiter().GetResult();
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
            public System.String Description { get; set; }
            public System.String EncryptionKey_Id { get; set; }
            public Amazon.Translate.EncryptionKeyType EncryptionKey_Type { get; set; }
            public Amazon.Translate.MergeStrategy MergeStrategy { get; set; }
            public System.String Name { get; set; }
            public byte[] TerminologyData_File { get; set; }
            public Amazon.Translate.TerminologyDataFormat TerminologyData_Format { get; set; }
            public System.Func<Amazon.Translate.Model.ImportTerminologyResponse, ImportTRNTerminologyCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.TerminologyProperties;
        }
        
    }
}
