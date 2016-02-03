# Script parameters
Param(
    [switch]
	$forceCreate=$true,
	[string]
    $settingsRelativePath = "..\sdk\test\Unity\Unity3DTests\Assets\Resources\settings.json"
)

#functions
function WriteSettingsFile($settings)
{
	if ($forceCreate -and (Test-Path $settings))
	{
		Write-Host "Removing existing settings file..."
		Remove-Item -Path $settings
	}

	if (Test-Path $settings)
	{
		Write-Host "Settings file $settings already exists, exiting"
		return
	}

	Write-Host "Setting up resources..."
	$accessKey = (Get-AWSCredentials -ProfileName default).GetCredentials().AccessKey
	$secretKey = (Get-AWSCredentials -ProfileName default).GetCredentials().SecretKey
	$region = (Get-DefaultAWSRegion).Region
	$accountId = ""
	
	Write-Host "Writing settings file $settings ..."
	$data = @{
		"AccessKeyId" = $accessKey
		"SecretAccessKey" = $secretKey
		"RegionEndpoint" = $region
		"AccountId" = $accountId
	}

	# -Compress makes the file harder to read, but must be used to avoid errors stemming from double quotes
	# https://connect.microsoft.com/PowerShell/feedback/details/735978/convertto-json-in-psv3-beta-does-not-support-values-containing-double-quotes
	ConvertTo-Json $data -Compress | Set-Content $settings
}

$ErrorActionPreference = "Stop"
$scriptLocation = Split-Path -Parent $MyInvocation.MyCommand.Definition
Write-Host "script location $scriptLocation"
Write-Host "settings relative path is $settingsRelativePath"

$settingsFullPath = Join-Path $scriptLocation $settingsRelativePath
Write-Host "Will be writing settings to $settingsFullPath"

Write-Host "Initializing AWS PS Tools..."
Initialize-AWSDefaults

Write-Host "forceCreate is $forceCreate"

Write-Host "Writing settings file to $settingsFullPath"
WriteSettingsFile($settingsFullPath)
