#$ErrorActionPreference = "Stop"
$OriginalDirectory = Get-Location
$OutputDirectory = Join-Path -Path $OriginalDirectory.Path -ChildPath "..\Deployment\nuget"

Write-Output "Writing NuGet packages to " + $OutputDirectory

If (Test-Path $OutputDirectory)
{
    Write-Output "Cleaning existing package folder"
	Remove-Item $OutputDirectory -Recurse -Force
}

New-Item $OutputDirectory -type directory

$nuspecs = Get-ChildItem -Recurse ..\*.nuspec
foreach($nuspec in $nuspecs) 
{
	Write-Output "Create package: " + $nuspec.FullName
    Set-Location $nuspec.DirectoryName
    try
    {
        $command = "$OriginalDirectory\..\sdk\.nuget\NuGet.exe pack $nuspec -verbosity detailed -OutputDirectory $OutputDirectory -BasePath ."
        Invoke-Expression $command
        if($LASTEXITCODE -ne 0)
        {
            return $LASTEXITCODE
        }
    }
    finally
    {
        Set-Location $OriginalDirectory
    }
}