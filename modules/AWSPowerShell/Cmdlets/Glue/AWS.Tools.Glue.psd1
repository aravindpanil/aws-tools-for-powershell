#
# Module manifest for module 'AWS.Tools.Glue'
#

@{
    # Script module or binary module file associated with this manifest
    RootModule = 'AWS.Tools.Glue.dll'

    # Supported PSEditions
    CompatiblePSEditions = @('Core', 'Desktop')

    # Version number of this module.
    ModuleVersion = '0.0.0.0'

    # ID used to uniquely identify this module
    GUID = '4c852a13-4bb9-4d9b-891e-10d7c65b8922'

    # Author of this module
    Author = 'Amazon.com, Inc'

    # Company or vendor of this module
    CompanyName = 'Amazon.com, Inc'

    # Copyright statement for this module
    Copyright = 'Copyright 2012-2020 Amazon.com, Inc. or its affiliates. All Rights Reserved.'

    # Description of the functionality provided by this module
    Description = 'The Glue module of AWS Tools for PowerShell lets developers and administrators manage AWS Glue from the PowerShell scripting environment. In order to manage each AWS service, install the corresponding module (e.g. AWS.Tools.EC2, AWS.Tools.S3...).
The module AWS.Tools.Installer (https://www.powershellgallery.com/packages/AWS.Tools.Installer/) makes it easier to install, update and uninstall the AWS.Tools modules.
This version of AWS Tools for PowerShell is compatible with Windows PowerShell 5.1+ and PowerShell Core 6+ on Windows, Linux and macOS. When running on Windows PowerShell, .NET Framework 4.7.2 or newer is required. Alternative modules AWSPowerShell.NetCore and AWSPowerShell, provide support for all AWS services from a single module and also support older versions of Windows PowerShell and .NET Framework.'

    # Minimum version of the PowerShell engine required by this module
    PowerShellVersion = '5.1'

    # Name of the PowerShell host required by this module
    PowerShellHostName = ''

    # Minimum version of the PowerShell host required by this module
    PowerShellHostVersion = ''

    # Minimum version of the .NET Framework required by this module
    DotNetFrameworkVersion = '4.7.2'

    # Minimum version of the common language runtime (CLR) required by this module
    CLRVersion = ''

    # Processor architecture (None, X86, Amd64, IA64) required by this module
    ProcessorArchitecture = ''

    # Modules that must be imported into the global environment prior to importing this module
    RequiredModules = @(
        @{
            ModuleName = 'AWS.Tools.Common';
            RequiredVersion = '0.0.0.0';
            Guid = 'e5b05bf3-9eee-47b2-81f2-41ddc0501b86' }
    )

    # Assemblies that must be loaded prior to importing this module.
    RequiredAssemblies = @(
        'AWSSDK.Glue.dll'
    )

    # Script files (.ps1) that are run in the caller's environment prior to importing this module
    ScriptsToProcess = @(

    )

    # Type files (.ps1xml) to be loaded when importing this module
    TypesToProcess = @(

    )

    # Format files (.ps1xml) to be loaded when importing this module
    FormatsToProcess = @(
        'AWS.Tools.Glue.Format.ps1xml'
    )

    # Modules to import as nested modules of the module specified in ModuleToProcess
    NestedModules = @(
        'AWS.Tools.Glue.Completers.psm1',
        'AWS.Tools.Glue.Aliases.psm1'
    )

    # Functions to export from this module
    FunctionsToExport = ''

    # Cmdlets to export from this module
    CmdletsToExport = @(
        'Add-GLUEResourceTag', 
        'Find-GLUETable', 
        'Get-GLUECatalogImportStatus', 
        'Get-GLUEClassifier', 
        'Get-GLUEClassifierList', 
        'Get-GLUEConnection', 
        'Get-GLUEConnectionList', 
        'Get-GLUECrawler', 
        'Get-GLUECrawlerBatch', 
        'Get-GLUECrawlerList', 
        'Get-GLUECrawlerMetricList', 
        'Get-GLUECrawlerNameList', 
        'Get-GLUEDatabase', 
        'Get-GLUEDatabaseList', 
        'Get-GLUEDataCatalogEncryptionSetting', 
        'Get-GLUEDataflowGraph', 
        'Get-GLUEDevEndpoint', 
        'Get-GLUEDevEndpointBatch', 
        'Get-GLUEDevEndpointList', 
        'Get-GLUEDevEndpointNameList', 
        'Get-GLUEJob', 
        'Get-GLUEJobBatch', 
        'Get-GLUEJobBookmark', 
        'Get-GLUEJobList', 
        'Get-GLUEJobNameList', 
        'Get-GLUEJobRun', 
        'Get-GLUEJobRunList', 
        'Get-GLUEMapping', 
        'Get-GLUEMLTaskRun', 
        'Get-GLUEMLTaskRunList', 
        'Get-GLUEMLTransform', 
        'Get-GLUEMLTransformList', 
        'Get-GLUEPartition', 
        'Get-GLUEPartitionBatch', 
        'Get-GLUEPartitionList', 
        'Get-GLUEPlan', 
        'Get-GLUEResourcePolicy', 
        'Get-GLUESecurityConfiguration', 
        'Get-GLUESecurityConfigurationList', 
        'Get-GLUETable', 
        'Get-GLUETableList', 
        'Get-GLUETableVersion', 
        'Get-GLUETableVersionList', 
        'Get-GLUETag', 
        'Get-GLUETrigger', 
        'Get-GLUETriggerBatch', 
        'Get-GLUETriggerList', 
        'Get-GLUETriggerNameList', 
        'Get-GLUEUserDefinedFunction', 
        'Get-GLUEUserDefinedFunctionList', 
        'Get-GLUEWorkflow', 
        'Get-GLUEWorkflowBatch', 
        'Get-GLUEWorkflowList', 
        'Get-GLUEWorkflowRun', 
        'Get-GLUEWorkflowRunList', 
        'Get-GLUEWorkflowRunProperty', 
        'Import-GLUECatalog', 
        'New-GLUEClassifier', 
        'New-GLUEConnection', 
        'New-GLUECrawler', 
        'New-GLUEDatabase', 
        'New-GLUEDevEndpoint', 
        'New-GLUEJob', 
        'New-GLUEMLTransform', 
        'New-GLUEPartition', 
        'New-GLUEPartitionBatch', 
        'New-GLUEScript', 
        'New-GLUESecurityConfiguration', 
        'New-GLUETable', 
        'New-GLUETrigger', 
        'New-GLUEUserDefinedFunction', 
        'New-GLUEWorkflow', 
        'Remove-GLUEClassifier', 
        'Remove-GLUEConnection', 
        'Remove-GLUEConnectionBatch', 
        'Remove-GLUECrawler', 
        'Remove-GLUEDatabase', 
        'Remove-GLUEDevEndpoint', 
        'Remove-GLUEJob', 
        'Remove-GLUEMLTransform', 
        'Remove-GLUEPartition', 
        'Remove-GLUEPartitionBatch', 
        'Remove-GLUEResourcePolicy', 
        'Remove-GLUEResourceTag', 
        'Remove-GLUESecurityConfiguration', 
        'Remove-GLUETable', 
        'Remove-GLUETableBatch', 
        'Remove-GLUETableVersion', 
        'Remove-GLUETableVersionBatch', 
        'Remove-GLUETrigger', 
        'Remove-GLUEUserDefinedFunction', 
        'Remove-GLUEWorkflow', 
        'Reset-GLUEJobBookmark', 
        'Set-GLUEDataCatalogEncryptionSetting', 
        'Set-GLUEResourcePolicy', 
        'Start-GLUECrawler', 
        'Start-GLUECrawlerSchedule', 
        'Start-GLUEExportLabelsTaskRun', 
        'Start-GLUEImportLabelsTaskRun', 
        'Start-GLUEJobRun', 
        'Start-GLUEMLEvaluationTaskRun', 
        'Start-GLUEMLLabelingSetGenerationTaskRun', 
        'Start-GLUETrigger', 
        'Start-GLUEWorkflowRun', 
        'Stop-GLUECrawler', 
        'Stop-GLUECrawlerSchedule', 
        'Stop-GLUEJobRunBatch', 
        'Stop-GLUEMLTaskRun', 
        'Stop-GLUETrigger', 
        'Update-GLUEClassifier', 
        'Update-GLUEConnection', 
        'Update-GLUECrawler', 
        'Update-GLUECrawlerSchedule', 
        'Update-GLUEDatabase', 
        'Update-GLUEDevEndpoint', 
        'Update-GLUEJob', 
        'Update-GLUEMLTransform', 
        'Update-GLUEPartition', 
        'Update-GLUETable', 
        'Update-GLUETrigger', 
        'Update-GLUEUserDefinedFunction', 
        'Update-GLUEWorkflow', 
        'Write-GLUEWorkflowRunProperty')

    # Variables to export from this module
    VariablesToExport = '*'

    # Aliases to export from this module
    AliasesToExport = @(
        'Get-GLUECrawlerMetricsList')

    # List of all modules packaged with this module
    ModuleList = @()

    # List of all files packaged with this module
    FileList = @(
        'AWS.Tools.Glue.dll-Help.xml'
    )

    # Private data to pass to the module specified in ModuleToProcess
    PrivateData = @{

        PSData = @{
            Tags = @('AWS', 'cloud', 'Windows', 'PSEdition_Desktop', 'PSEdition_Core', 'Linux', 'MacOS', 'Mac')
            LicenseUri = 'https://aws.amazon.com/apache-2-0/'
            ProjectUri = 'https://github.com/aws/aws-tools-for-powershell'
            IconUri = 'https://sdk-for-net.amazonwebservices.com/images/AWSLogo128x128.png'
            ReleaseNotes = 'https://github.com/aws/aws-tools-for-powershell/blob/master/CHANGELOG.md'
        }
    }
}
