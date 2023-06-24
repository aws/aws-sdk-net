# Find all dependency paths under a folder and copy each of them to the target folder
Function Copy-Dependencies
{
    [CmdletBinding()]
    Param
    (
        # The list of dependencies to copy
        #
        # Note, only dependencies of Core projects may currently be listed
        # Restoring the full slns just for copying was disruptive to later tests
        #
        # If ever modifying this list, you likely need to update buildtools/NoticeForZips.txt and
        # the corresponding copy-license-and-notice task as well.
        [Parameter()]
        [string[]]
        $DependencyNames = @("microsoft.bcl.asyncinterfaces", "system.runtime.compilerservices.unsafe", "system.threading.tasks.extensions", 
                             "awscrt", "awscrt-auth", "awscrt-http", "awscrt-checksums"),

        # The list of dependencies with additional targets
        # Each entry should contain the dependency name as a key, source and target as value
        [Parameter()]
        [hashtable]
        $DependenciesWithAditionalTargets = @{
            "awscrt" = @{Source = "netstandard2.0"; Target = "netcoreapp3.1"}
            "awscrt-auth" = @{Source = "netstandard2.0"; Target = "netcoreapp3.1"}
            "awscrt-http" = @{Source = "netstandard2.0"; Target = "netcoreapp3.1"}
            "awscrt-checksums" = @{Source = "netstandard2.0"; Target = "netcoreapp3.1"}
        },

        # The location to copy the built dlls to
        [Parameter(Mandatory=$true, Position=1)]
        [string]
        $Destination,

        # Absolute path to a temporary folder to restore the Core projects into prior the copy the dependencies from
        [Parameter(Mandatory=$true, Position=2)]
        [string]
        $TempRestoreFolder,

        # The build type. If not specified defaults to 'release'.
        [Parameter()]
        [string]
        $BuildType = "release",

        # The supported platforms in .NET SDK
        [Parameter()]
        [string[]]
        $AcceptedPlatforms =  @("net35","net45","netstandard2.0","netcoreapp3.1"),

        # The supported platforms in .NET SDK
        [Parameter()]
        [string[]]
        $ProjectFiles =  @("AWSSDK.Core.Net35.csproj", "AWSSDK.Core.Net45.csproj", "AWSSDK.Core.NetStandard.csproj", "AWSSDK.Extensions.CrtIntegration.Net35.csproj",
                           "AWSSDK.Extensions.CrtIntegration.Net45.csproj", "AWSSDK.Extensions.CrtIntegration.NetStandard.csproj")

    )

    Process
    {
        foreach ($project in $ProjectFiles) 
        {
            # Check two paths to support running in either the root or /buildtools folders
            if (Test-Path sdk/src/core/$project) {
                dotnet restore -f --packages $TempRestoreFolder sdk/src/core/$project
            }
            elseif (Test-Path ../sdk/src/core/$project) 
            {
                dotnet restore -f --packages $TempRestoreFolder ../sdk/src/core/$project
            }
            elseif (Test-Path extensions/src/AWSSDK.Extensions.CrtIntegration/$project) 
            {
                dotnet restore -f --packages $TempRestoreFolder extensions/src/AWSSDK.Extensions.CrtIntegration/$project
            }
            elseif (Test-Path ../extensions/src/AWSSDK.Extensions.CrtIntegration/$project) 
            {
                dotnet restore -f --packages $TempRestoreFolder ../extensions/src/AWSSDK.Extensions.CrtIntegration/$project
            }
        }

        foreach ($dependency in $DependencyNames) 
        {
            Write-Debug "Checking if $dependency exists in $TempRestoreFolder"
            if (Test-Path $TempRestoreFolder/$dependency) {
                $dependencyFolder = Get-Item -Path $TempRestoreFolder/$dependency
                $versions = Get-ChildItem -Path $dependencyFolder | Sort-Object -Property Name -Descending
                $max = $versions[0]
                $libPath = Join-Path $max.FullName lib
                if (Test-Path $libPath) 
                {
                    $targets = Get-Item -Path $libPath | Get-ChildItem
                    foreach ($target in $targets) 
                    {
                        $targetDllPath = Join-Path $target.FullName *.dll
                        if (($AcceptedPlatforms -match $target.Name) -And (Test-Path $targetDllPath)) 
                        {
                            $dllFile = Get-ChildItem -Path $targetDllPath
                            if (@($dllFile).Length -eq 1) 
                            {
                                Write-Debug "Copying $dllFile to $Destination for $target"
                                Copy-Dependency -SourceFile $dllFile -Destination $Destination -Platform $target.Name

                                if ($DependenciesWithAditionalTargets.ContainsKey($dependency) -And 
                                        $target.Name -eq $DependenciesWithAditionalTargets.$dependency.Source) 
                                {
                                    Copy-Dependency -SourceFile $dllFile -Destination $Destination -Platform $DependenciesWithAditionalTargets.$dependency.Target
                                }

                            } 
                            else 
                            {
                                throw "Multiple dll files found for dependency $dependency"
                            }
                        }
                        else 
                        {
                            Write-Debug "$target is not an accepted platform for $dependency"
                        }
                    }
                }
                else 
                {
                    throw "No lib folder found for dependency $dependency"
                }
            }
            else 
            {
                throw "Could not find dependency $dependency in packages $TempRestoreFolder"
            }
        }

        Write-Debug "Deleting $TempRestoreFolder"
        Remove-Item -Recurse -Force $TempRestoreFolder
    }
}

# Given the path of a dependency dll, copy it to the target folder for the correct platform
Function Copy-Dependency
{
    [CmdletBinding()]
    Param
    (
        # The path to the dll for the dependency
        [Parameter(Mandatory=$true, ValueFromPipelineByPropertyName=$true, Position=0)]
        [string]
        $SourceFile,

        # The location to copy the built dll to
        [Parameter(Mandatory=$true, Position=1)]
        [string]
        $Destination,

        # The platform to copy.
        [Parameter()]
        [string]
        $Platform
    )

    Process
    {
        Write-Verbose "Copying built SDK assemblies beneath $SourceFile to $Destination"
        if (!(Test-Path $Destination))
        {
            New-Item $Destination -ItemType Directory
        }
        $platformDestination = Join-Path $Destination $Platform
        if (!(Test-Path $platformDestination))
        {
            New-Item $platformDestination -ItemType Directory
        }             
        $assembly = Get-Item -Path $SourceFile
        Write-Debug "Checking if $assembly exists"
        if(!(Test-Path $assembly))
        {
            throw "Configured to copy $assembly but it was not found. Please check the path of the dependency."
        }

        Write-Host "Copying $($assembly.FullName) to $(Resolve-Path $platformDestination)"
        Copy-Item $assembly.FullName -Destination $(Resolve-Path $platformDestination)
    }
}

Copy-Dependencies -Destination ..\Deployment\assemblies $(Join-Path -Path $([System.IO.Path]::GetTempPath()) -ChildPath "/temp-nuget-packages")