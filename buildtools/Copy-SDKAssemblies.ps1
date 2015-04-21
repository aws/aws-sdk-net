Function Copy-SDKAssemblies
{
    [CmdletBinding()]
    Param
    (
        # The root folder containing the core runtime or a service
        [Parameter(Mandatory=$true, ValueFromPipelineByPropertyName=$true, Position=0)]
        [string]
        $SourceRoot,

        # The location to copy the built dll and pdb to
        [Parameter(Mandatory=$true, Position=1)]
        [string]
        $Destination,

        # The build type. If not specified defaults to 'release'.
        [Parameter()]
        [string]
        $BuildType = "release",

        # The platforms to copy. Defaults to all if not specified.
        [Parameter()]
        [string[]]
        $Platforms = @("net35","net45","portable","winrt","wp8")
    )

    Process
    {
        Write-Verbose "Copying built SDK assemblies beneath $SourceRoot to $Destination"

        if (!(Test-Path $Destination))
        {
            New-Item $Destination -ItemType Directory
        }

        $dir = Get-Item $SourceRoot
        $servicename = $dir.Name

        foreach ($p in $Platforms)
        {
            $platformDestination = Join-Path $Destination $p
            if (!(Test-Path $platformDestination))
            {
                New-Item $platformDestination -ItemType Directory
            }
                        
            $filter = "bin\$BuildType\$p\AWSSDK.$servicename.*"
            $assemblies = gci -Path $dir.FullName -Filter $filter

            foreach ($a in $assemblies)
            {
                $assemblyName = $a.Name
                Write-Verbose "Copying $assemblyName..."
                Copy-Item $a.FullName $platformDestination
            }
        }
    }
}

Copy-SDKAssemblies -SourceRoot ..\sdk\src\Core -Destination ..\Deployment\sdk\assemblies

$services = gci ..\sdk\src\services
foreach ($s in $services)
{
    Copy-SDKAssemblies -SourceRoot $s.FullName -Destination ..\Deployment\sdk\assemblies
}

Write-Verbose "Copying assembly versions manifest..."
Copy-Item ..\generator\ServiceModels\_sdk-versions.json ..\Deployment\sdk\assemblies\_sdk-versions.json


