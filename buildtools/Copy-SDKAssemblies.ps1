# Script parameters
Param
(
    [string]$PublicKeyTokenToCheck,

    # The build type. If not specified defaults to 'release'.
    [Parameter()]
    [string]$BuildType = "release"
)

# Functions

Function Get-PublicKeyToken
{
    [CmdletBinding()]
	Param
	(
        # The assembly in question
        [Parameter(Mandatory=$true, ValueFromPipelineByPropertyName=$true, ValueFromPipeline=$true, Position=0)]
        [string]$AssemblyPath
	)
	
    $token = $null
    $token = [System.Reflection.Assembly]::LoadFrom($AssemblyPath).GetName().GetPublicKeyToken()
    if ( $token )
    {
        $key = ""
        foreach($b in $token)
        {
            $key += "{0:x2}" -f $b
        }
        return $key
    }
    else
    {
        Write-Error "NO TOKEN!! - $AssemblyPath"
    }
}

Function Copy-SdkAssemblies
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
        $Platforms = @("net35","net45", "pcl", "monoandroid", "Xamarin.iOS10", "windows8", "wpa81"),
        
        # The public key token that all assemblies should have. Optional.
        [Parameter()]
        [string]
        $PublicKeyToken = "",
		
		#added to support unity assemblies
		[Parameter()]
		[bool]
		$ValidatePublicKeyToken = $true
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
            $relativeSourcePath = "bin\$BuildType\$p"

            if (!(Join-Path $dir.FullName $relativeSourcePath | Test-Path))
            {
                continue
            }

            $platformDestination = Join-Path $Destination $p
            if (!(Test-Path $platformDestination))
            {
                New-Item $platformDestination -ItemType Directory
            }
                        
            $filter = "bin\$BuildType\$p\AWSSDK.$servicename.*"
			
			#unity sdk doesnot support all services currently
			$sourceDirectory = $null
			$sourceDirectory = [System.IO.Path]::Combine($dir.FullName, 'bin', $BuildType, $p)
			Write-Debug "Checking if $sourceDirectory exists"
			if(!(Test-Path $sourceDirectory))
			{
				continue
			}
			
            $files = gci -Path $dir.FullName -Filter $filter -ErrorAction Stop
			
            foreach ($a in $files)
            {
                $assemblyName = $a.Name
                $assemblyExtension = [System.IO.Path]::GetExtension($assemblyName).ToLower()
                if ($assemblyExtension -eq ".dll" -And $ValidatePublicKeyToken)
                {
                    $aToken = Get-PublicKeyToken -AssemblyPath $a.FullName
                    Write-Debug "File $assemblyName has token = $aToken"
                    if ($PublicKeyToken -ne $aToken)
                    {
                        $message = "File = {0}, Token = {1}, does not match Expected Token = {2}" -f $a.FullName, $aToken, $PublicKeyToken
                        Write-Error $message
                        return
                    }
                }
                Write-Verbose "Copying $assemblyName..."
                Copy-Item $a.FullName $platformDestination
            }
        }
    }
}

Function Copy-CoreClrSdkAssemblies
{
	[CmdletBinding()]
	Param
	(
		# The root folder containing the core runtime or a service
		[Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, Position = 0)]
		[string]$SourceRoot,
		# The location to copy the built dll and pdb to
		[Parameter(Mandatory = $true, Position = 1)]
		[string]$Destination,
		# The build type. If not specified defaults to 'release'.
		[Parameter()]
		[string]$BuildType = "release",
		# The platforms to copy. Defaults to all if not specified.
		[Parameter()]
		[string[]]$Platforms = @("netstandard1.5"),
		# The public key token that all assemblies should have. Optional.
		[Parameter()]
		[string]$PublicKeyToken = ""
	)
	
	Process
	{
		Write-Verbose "Copying built CoreCLR SDK assemblies beneath $SourceRoot to $Destination"
		
		if (!(Test-Path $Destination))
		{
			New-Item $Destination -ItemType Directory
		}
		
		$assemblyFoldersPattern = Join-Path $SourceRoot "*.Dnx"
		$assemblyFolderRoots = gci $assemblyFoldersPattern
		foreach ($afr in $assemblyFolderRoots)
		{
			foreach ($p in $Platforms)
			{
				$sourceFolder = Join-Path $afr (Join-Path $BuildType $p)
				$targetFolder = Join-Path $Destination $p

                if (!(Test-Path $targetFolder))
                {
                    New-Item $targetFolder -ItemType Directory
                }

				Write-Verbose "Copying from $sourceFolder to $targetFolder..."
				
				$files = gci $sourceFolder
				
				foreach ($f in $files)
				{
					Copy-Item -Path $f.FullName -Destination $targetFolder
				}
			}
		}
	}
}

Write-Verbose "Copying $BuildType SDK assemblies to deployment folders for BCL/PCL platforms"
$args = @{
	"Destination" = "..\Deployment\assemblies"
	"PublicKeyToken" = $PublicKeyTokenToCheck
	"BuildType" = $BuildType
}

Copy-SDKAssemblies -SourceRoot ..\sdk\src\Core -Destination ..\Deployment\assemblies -PublicKeyToken $PublicKeyTokenToCheck -Platforms @("net35","net45","pcl","monoandroid","Xamarin.iOS10","windows8","wpa81") -BuildType $BuildType

#for unity the assemblies are not signed, so we copy them seperately and override the check
Copy-SDKAssemblies -SourceRoot ..\sdk\src\Core -Destination ..\Deployment\assemblies -Platforms @("unity", "netstandard1.3") -BuildType $BuildType -ValidatePublicKeyToken $false

$services = gci ..\sdk\src\services
foreach ($s in $services)
{
    Copy-SDKAssemblies -SourceRoot $s.FullName -Destination ..\Deployment\assemblies -PublicKeyToken $PublicKeyTokenToCheck  -BuildType $BuildType
	Copy-SDKAssemblies -SourceRoot $s.FullName -Destination ..\Deployment\assemblies -Platforms @("unity", "netstandard1.3") -ValidatePublicKeyToken $false  -BuildType $BuildType
}

Write-Verbose "Copying $BuildType SDK assemblies to deployment folders for CoreCLR platforms"
$args = @{
	"Destination" = "..\Deployment\assemblies"
	"PublicKeyToken" = $PublicKeyTokenToCheck
	"BuildType" = $BuildType
}
#Copy-CoreClrSdkAssemblies -SourceRoot ..\sdk\artifacts\bin @args -Verbose

