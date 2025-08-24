# Setup script for DocFX documentation generation with Material theme
# This script demonstrates how to use the new DocFX integration

param(
    [string]$SDKAssembliesRoot = "",
    [string]$OutputFolder = "./docs-output",
    [string]$Platform = "net472",
    [switch]$Verbose,
    [switch]$Clean,
    [switch]$TestMode
)

Write-Host "Setting up DocFX documentation generation with Material theme..." -ForegroundColor Green

# Check if DocFX is installed
try {
    $docfxVersion = & docfx --version 2>$null
    Write-Host "DocFX version: $docfxVersion" -ForegroundColor Green
} catch {
    Write-Host "DocFX not found. Installing DocFX..." -ForegroundColor Yellow
    dotnet tool install -g docfx
}

# Check if Git is available (needed for Material theme setup)
try {
    $gitVersion = & git --version 2>$null
    Write-Host "Git version: $gitVersion" -ForegroundColor Green
} catch {
    Write-Host "Warning: Git not found. Material theme setup may fail." -ForegroundColor Yellow
}

# Build the documentation generator
Write-Host "Building documentation generator..." -ForegroundColor Yellow
dotnet build AWSSDKDocGenerator.sln -c Release

if ($LASTEXITCODE -ne 0) {
    Write-Host "Failed to build documentation generator" -ForegroundColor Red
    exit 1
}

# Prepare command line arguments
$args = @()
$args += "-usedocfx"

if ($SDKAssembliesRoot) {
    $args += "-sdkassembliesroot"
    $args += $SDKAssembliesRoot
}

if ($OutputFolder) {
    $args += "-outputfolder"
    $args += $OutputFolder
}

if ($Platform) {
    $args += "-platform"
    $args += $Platform
}

if ($Verbose) {
    $args += "-verbose"
}

if ($Clean) {
    $args += "-clean"
}

if ($TestMode) {
    $args += "-testmode"
}

# Run the documentation generator with DocFX
Write-Host "Running documentation generator with DocFX..." -ForegroundColor Yellow
Write-Host "Command: SDKDocGenerator.exe $($args -join ' ')" -ForegroundColor Cyan

$generatorPath = "SDKDocGenerator\bin\Release\SDKDocGenerator.exe"
if (Test-Path $generatorPath) {
    & $generatorPath @args
} else {
    Write-Host "Documentation generator not found at: $generatorPath" -ForegroundColor Red
    Write-Host "Please build the solution first." -ForegroundColor Red
    exit 1
}

if ($LASTEXITCODE -eq 0) {
    Write-Host "Documentation generation completed successfully!" -ForegroundColor Green
    if ($OutputFolder -and (Test-Path $OutputFolder)) {
        Write-Host "Documentation available at: $OutputFolder" -ForegroundColor Green
    }
} else {
    Write-Host "Documentation generation failed with exit code: $LASTEXITCODE" -ForegroundColor Red
}
