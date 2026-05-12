# PowerShell script to download and extract AWS SDK DLLs for compatibility testing
param(
    [string]$ZipUrl = "https://sdk-for-net.amazonwebservices.com/latest/v4/aws-sdk-net8.0.zip",
    [string]$OutputDir = "DownloadedDlls"
)

$ErrorActionPreference = "Stop"

Write-Output "Checking for AWS SDK DLLs in $OutputDir..."

# Check if DLLs already exist
if (Test-Path "$OutputDir\AWSSDK.S3.dll") {
    Write-Output "DLLs already downloaded. Skipping download."
    exit 0
}

# Create output directory if it doesn't exist
if (-not (Test-Path $OutputDir)) {
    New-Item -ItemType Directory -Path $OutputDir | Out-Null
}

$zipFile = Join-Path $OutputDir "temp-aws-sdk.zip"

try {
    Write-Output "Downloading AWS SDK from: $ZipUrl"
    
    # Download the ZIP file
    Invoke-WebRequest -Uri $ZipUrl -OutFile $zipFile -UseBasicParsing
    
    Write-Output "Download complete. Extracting..."
    
    $extracted = $false
    
    # Check if we're on Linux/Unix
    if ($IsLinux -or $IsMacOS) {
        # Try to use unzip (most common on Linux)
        $unzip = Get-Command unzip -ErrorAction SilentlyContinue
        if ($unzip) {
            Write-Output "Using unzip for faster extraction..."
            try {
                & unzip -q -o "$zipFile" -d "$OutputDir"
                if ($LASTEXITCODE -eq 0) {
                    $extracted = $true
                }
            }
            catch {
                Write-Output "unzip extraction failed, trying other methods..."
            }
        }
        
        # If unzip failed or not available, try 7z
        if (-not $extracted) {
            $sevenZ = Get-Command 7z -ErrorAction SilentlyContinue
            if ($sevenZ) {
                Write-Output "Using 7z for faster extraction..."
                try {
                    & 7z x "$zipFile" "-o$OutputDir" -y | Out-Null
                    if ($LASTEXITCODE -eq 0) {
                        $extracted = $true
                    }
                }
                catch {
                    Write-Output "7z extraction failed, falling back to Expand-Archive..."
                }
            }
        }
    }
    else {
        # Windows - Try to find 7-Zip
        $sevenZipPaths = @(
            "$env:ProgramFiles\7-Zip\7z.exe",
            "${env:ProgramFiles(x86)}\7-Zip\7z.exe",
            "$env:ProgramW6432\7-Zip\7z.exe"
        )
        
        $sevenZip = $sevenZipPaths | Where-Object { Test-Path $_ } | Select-Object -First 1
        
        if ($sevenZip) {
            Write-Output "Using 7-Zip for faster extraction..."
            try {
                & $sevenZip x "$zipFile" "-o$OutputDir" -y | Out-Null
                if ($LASTEXITCODE -eq 0) {
                    $extracted = $true
                }
            }
            catch {
                Write-Output "7-Zip extraction failed, falling back to Expand-Archive..."
            }
        }
    }
    
    # Fallback to PowerShell's built-in Expand-Archive if no other tool worked
    if (-not $extracted) {
        Write-Output "Using built-in Expand-Archive (slower)..."
        Expand-Archive -Path $zipFile -DestinationPath $OutputDir -Force
    }
    
    Write-Output "Extraction complete."
    
    # Count DLLs
    $dllCount = (Get-ChildItem -Path $OutputDir -Filter "*.dll" -Recurse).Count
    Write-Output "Found $dllCount DLL files in $OutputDir"
}
catch {
    Write-Output "Error downloading/extracting DLLs: $_"
    exit 1
}
finally {
    # Clean up ZIP file
    if (Test-Path $zipFile) {
        Remove-Item $zipFile -Force
    }
}

exit 0