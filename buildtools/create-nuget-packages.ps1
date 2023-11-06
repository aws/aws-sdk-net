param(
    # List of packages (delimited by ";" or ",") that should be created.
    [string] $PackageList = ""
)

$OriginalDirectory = Get-Location
$OutputDirectory = Join-Path -Path $OriginalDirectory.Path -ChildPath "..\Deployment\nuget"

Write-Output "Writing NuGet packages to " + $OutputDirectory
If (Test-Path $OutputDirectory)
{
    Write-Output "Cleaning existing package folder"
	Remove-Item $OutputDirectory -Recurse -Force
}

New-Item $OutputDirectory -type directory
$allNuspecs = Get-ChildItem -Recurse ..\sdk\src\*.nuspec

# When performing a partial build, we want to create packages of only services that changed
if (![string]::IsNullOrEmpty($PackageList))
{
    $nuspecs = New-Object System.Collections.ArrayList
    foreach ($nuspec in $allNuspecs)
    {
        foreach ($package in $PackageList.split(@(';',',')))
        {
            if ($nuspec.Directory.Name -contains $package)
            {
                $nuspecs.Add($nuspec)
            }
        }
    }
}
else
{
    $nuspecs = $allNuspecs
}

foreach ($nuspec in $nuspecs) 
{
	Write-Output "Create package: " + $nuspec.FullName
    Set-Location $nuspec.DirectoryName
    try
    {
        $command = "$OriginalDirectory\..\sdk\.nuget\NuGet.exe pack $nuspec -verbosity detailed -OutputDirectory $OutputDirectory -BasePath ."
        Invoke-Expression $command
        if ($LASTEXITCODE -ne 0)
        {
            return $LASTEXITCODE
        }
    }
    finally
    {
        Set-Location $OriginalDirectory
    }
}