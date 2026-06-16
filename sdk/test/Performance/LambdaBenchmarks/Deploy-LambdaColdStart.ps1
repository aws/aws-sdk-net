<#
.SYNOPSIS
    Deploys Lambda functions for cold start benchmarks.

.DESCRIPTION
    This script deploys Lambda functions for cold start benchmarking.

    The template requires cold start benchmarks for three Lambda functions, each sending
    a single request to a different AWS service:
      1. STS  — GetCallerIdentity
      2. S3   — ListBuckets (use an account with no buckets)
      3. EC2  — DescribeRegions

    Each function is deployed for BOTH architectures:
      - x86_64 (Intel)
      - arm64  (Graviton)

    Three compilation modes are supported:
      - Standard: Default `dotnet publish` (no R2R, no AOT)
      - R2R:      ReadyToRun pre-compilation (`<PublishReadyToRun>true</PublishReadyToRun>`)
      - NativeAOT: Ahead-of-time native compilation (`<PublishAot>true</PublishAot>`)

    Function naming convention:
      - Standard:  dotnet-perf-{svc}-coldstart-{arch}
      - R2R:       dotnet-perf-{svc}-coldstart-r2r-{arch}
      - NativeAOT: dotnet-perf-{svc}-coldstart-aot-{arch}

    Lambda settings (per template):
      - Memory: 512 MB
      - Region: us-east-1
      - Runtime: dotnet8 (Standard/R2R) or provided.al2023 (NativeAOT)
      - Timeout: 30 seconds

    After deployment, use the ColdStartInitDurationRunner to execute the cold start measurements.
    Use Cleanup-Lambda.ps1 to delete all functions when done.

.PARAMETER Region
    The AWS region. Default: us-east-1

.PARAMETER FunctionPrefix
    Prefix for Lambda function names. Default: dotnet-perf

.PARAMETER CompilationMode
    The compilation mode: Standard, R2R, or NativeAOT. Default: Standard

.PARAMETER RoleArn
    The ARN of an IAM role for the Lambda functions. The role needs:
      - AWSLambdaBasicExecutionRole (for CloudWatch Logs)
      - sts:GetCallerIdentity (for STS function)
      - s3:ListAllMyBuckets (for S3 function)
      - ec2:DescribeRegions (for EC2 function)
    If not provided, the script will attempt to create a role named 'dotnet-perf-lambda-role'.

.EXAMPLE
    .\Deploy-LambdaColdStart.ps1 -Region us-east-1

.EXAMPLE
    .\Deploy-LambdaColdStart.ps1 -Region us-east-1 -CompilationMode R2R

.EXAMPLE
    .\Deploy-LambdaColdStart.ps1 -Region us-east-1 -CompilationMode NativeAOT
#>
param(
    [string]$Region = "us-east-1",
    [string]$FunctionPrefix = "dotnet-perf",
    [ValidateSet("Standard", "R2R", "NativeAOT")]
    [string]$CompilationMode = "Standard",
    [string]$RoleArn = "",
    [string]$LambdaProjectPath = ""
)

# Note: We don't use $ErrorActionPreference = "Stop" globally because AWS CLI
# writes to stderr for expected conditions (e.g., role/function not found),
# which PowerShell treats as terminating errors.

# Determine function name suffix based on compilation mode
$modeSuffix = switch ($CompilationMode) {
    "Standard" { "" }
    "R2R"      { "-r2r" }
    "NativeAOT" { "-aot" }
}

# Determine Lambda runtime based on compilation mode
$lambdaRuntime = switch ($CompilationMode) {
    "Standard" { "dotnet8" }
    "R2R"      { "dotnet8" }
    "NativeAOT" { "provided.al2023" }
}

# NativeAOT requires self-contained deployment
$selfContained = ($CompilationMode -eq "NativeAOT")

Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Deploying Lambda Cold Start Benchmark Functions" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "  Region:           $Region"
Write-Host "  Function Prefix:  $FunctionPrefix"
Write-Host "  Compilation Mode: $CompilationMode"
Write-Host "  Lambda Runtime:   $lambdaRuntime"
Write-Host "  Mode Suffix:      '$modeSuffix'"
Write-Host ""

# ============================================================================
# Step 1: Create or verify IAM role
# ============================================================================

$roleName = "dotnet-perf-lambda-coldstart-role"

if ($RoleArn -eq "") {
    Write-Host "No RoleArn provided. Checking for existing role '$roleName'..." -ForegroundColor Yellow

    $existingRole = aws iam get-role --role-name $roleName --region $Region 2>$null | ConvertFrom-Json
    if ($null -ne $existingRole) {
        $RoleArn = $existingRole.Role.Arn
        Write-Host "  Found existing role: $RoleArn"
    } else {
        Write-Host "  Creating IAM role '$roleName'..."

        # Write trust policy to a temp file (avoids PowerShell JSON escaping issues with AWS CLI)
        $trustPolicyFile = Join-Path ([System.IO.Path]::GetTempPath()) "lambda-trust-policy.json"
        $trustPolicyJson = '{"Version":"2012-10-17","Statement":[{"Effect":"Allow","Principal":{"Service":"lambda.amazonaws.com"},"Action":"sts:AssumeRole"}]}'
        [System.IO.File]::WriteAllText($trustPolicyFile, $trustPolicyJson)

        $roleResultJson = aws iam create-role `
            --role-name $roleName `
            --assume-role-policy-document "file://$trustPolicyFile" `
            --region $Region 2>&1

        Remove-Item $trustPolicyFile -ErrorAction SilentlyContinue

        if ($LASTEXITCODE -ne 0) {
            Write-Host "  ERROR: Failed to create IAM role. Output: $roleResultJson" -ForegroundColor Red
            exit 1
        }

        $roleResult = $roleResultJson | ConvertFrom-Json
        $RoleArn = $roleResult.Role.Arn
        Write-Host "  Created role: $RoleArn"

        # Attach basic Lambda execution policy
        Write-Host "  Attaching AWSLambdaBasicExecutionRole..."
        aws iam attach-role-policy `
            --role-name $roleName `
            --policy-arn "arn:aws:iam::aws:policy/service-role/AWSLambdaBasicExecutionRole"

        # Write benchmark policy to a temp file
        $benchmarkPolicyFile = Join-Path ([System.IO.Path]::GetTempPath()) "lambda-benchmark-policy.json"
        $benchmarkPolicyJson = '{"Version":"2012-10-17","Statement":[{"Effect":"Allow","Action":["sts:GetCallerIdentity","s3:ListAllMyBuckets","ec2:DescribeRegions"],"Resource":"*"}]}'
        [System.IO.File]::WriteAllText($benchmarkPolicyFile, $benchmarkPolicyJson)

        Write-Host "  Attaching benchmark permissions policy..."
        aws iam put-role-policy `
            --role-name $roleName `
            --policy-name "ColdStartBenchmarkPermissions" `
            --policy-document "file://$benchmarkPolicyFile"

        Remove-Item $benchmarkPolicyFile -ErrorAction SilentlyContinue

        # Wait for role to propagate
        Write-Host "  Waiting 10 seconds for IAM role propagation..."
        Start-Sleep -Seconds 10
    }
}

Write-Host "  Using role: $RoleArn"
Write-Host ""

# ============================================================================
# Step 2: Create temporary Lambda project, build, and package
# ============================================================================

$tempDir = Join-Path ([System.IO.Path]::GetTempPath()) "dotnet-perf-lambda-coldstart-$(Get-Random)"
New-Item -ItemType Directory -Path $tempDir -Force | Out-Null

Write-Host "Building Lambda functions in: $tempDir" -ForegroundColor Yellow

# Helper function to generate csproj content based on compilation mode
function Get-CsprojContent {
    param(
        [string]$ProjectName,
        [string]$ServicePackage,
        [string]$CompilationMode
    )

    $propertyGroupExtra = ""
    $itemGroupExtra = ""

    switch ($CompilationMode) {
        "R2R" {
            $propertyGroupExtra = "    <PublishReadyToRun>true</PublishReadyToRun>"
        }
        "NativeAOT" {
            $propertyGroupExtra = @"
    <PublishAot>true</PublishAot>
    <StripSymbols>true</StripSymbols>
"@
            # NativeAOT Lambda needs Amazon.Lambda.RuntimeSupport for the bootstrap
            $itemGroupExtra = @"
    <PackageReference Include="Amazon.Lambda.RuntimeSupport" Version="1.*" />
"@
        }
    }

    # For NativeAOT, OutputType must be Exe (for the bootstrap entry point)
    $outputType = if ($CompilationMode -eq "NativeAOT") { "Exe" } else { "Library" }

    return @"
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>
    <AWSProjectType>Lambda</AWSProjectType>
    <OutputType>$outputType</OutputType>
$propertyGroupExtra
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="Amazon.Lambda.Core" Version="2.*" />
    <PackageReference Include="Amazon.Lambda.Serialization.SystemTextJson" Version="2.*" />
    <PackageReference Include="$ServicePackage" Version="4.*" />
$itemGroupExtra
  </ItemGroup>
</Project>
"@
}

# Helper function to generate Function.cs content
function Get-FunctionContent {
    param(
        [string]$ServiceNamespace,
        [string]$ClientClass,
        [string]$RequestClass,
        [string]$ResponseExpression,
        [string]$CompilationMode
    )

    $bootstrapCode = ""
    if ($CompilationMode -eq "NativeAOT") {
        # NativeAOT requires an explicit bootstrap with Amazon.Lambda.RuntimeSupport
        $bootstrapCode = @"

public class Program
{
    public static async Task Main(string[] args)
    {
        var handler = new Function();
        await Amazon.Lambda.RuntimeSupport.LambdaBootstrapBuilder
            .Create<object, string>(handler.FunctionHandler, new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer())
            .Build()
            .RunAsync();
    }
}
"@
    }

    return @"
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using $ServiceNamespace;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ColdStartBenchmark;

public class Function
{
    public async Task<string> FunctionHandler(object input, ILambdaContext context)
    {
        var client = new $ClientClass();
        var response = await client.${RequestClass};
        return $ResponseExpression;
    }
}
$bootstrapCode
"@
}

# --- Create service projects ---
$services = @()

# Helper to create a service project directory with csproj and Function.cs
function New-ServiceProject {
    param(
        [string]$ServiceName,
        [string]$ProjectName,
        [string]$ServicePackage,
        [string]$FunctionCsContent,
        [string]$CompilationMode,
        [string]$TempDir
    )

    $svcDir = Join-Path $TempDir $ServiceName
    New-Item -ItemType Directory -Path $svcDir -Force | Out-Null

    # Generate csproj
    $csprojContent = Get-CsprojContent -ProjectName $ProjectName -ServicePackage $ServicePackage -CompilationMode $CompilationMode
    $csprojContent | Set-Content (Join-Path $svcDir "$ProjectName.csproj")

    # Write Function.cs
    $FunctionCsContent | Set-Content (Join-Path $svcDir "Function.cs")

    # For NativeAOT, handler is the bootstrap executable itself
    $handler = if ($CompilationMode -eq "NativeAOT") {
        "bootstrap"
    } else {
        "${ProjectName}::ColdStartBenchmark.Function::FunctionHandler"
    }

    return @{
        Name = $ServiceName
        Dir = $svcDir
        Project = "$ProjectName.csproj"
        Handler = $handler
    }
}

# NativeAOT bootstrap suffix
$aotBootstrap = ""
if ($CompilationMode -eq "NativeAOT") {
    $aotBootstrap = @"

public class Program
{
    public static async Task Main(string[] args)
    {
        var handler = new ColdStartBenchmark.Function();
        await Amazon.Lambda.RuntimeSupport.LambdaBootstrapBuilder
            .Create<object, string>(handler.FunctionHandler, new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer())
            .Build()
            .RunAsync();
    }
}
"@
}

# --- STS ---
$stsFunctionCs = @"
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ColdStartBenchmark;

public class Function
{
    public async Task<string> FunctionHandler(object input, ILambdaContext context)
    {
        var client = new AmazonSecurityTokenServiceClient();
        var response = await client.GetCallerIdentityAsync(new GetCallerIdentityRequest());
        return response.Arn;
    }
}
$aotBootstrap
"@
$services += New-ServiceProject -ServiceName "sts" -ProjectName "StsColdStart" -ServicePackage "AWSSDK.SecurityToken" -FunctionCsContent $stsFunctionCs -CompilationMode $CompilationMode -TempDir $tempDir

# --- S3 ---
$s3FunctionCs = @"
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Amazon.S3;
using Amazon.S3.Model;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ColdStartBenchmark;

public class Function
{
    public async Task<string> FunctionHandler(object input, ILambdaContext context)
    {
        var client = new AmazonS3Client();
        var response = await client.ListBucketsAsync(new ListBucketsRequest());
        return `$"Found {response.Buckets.Count} buckets";
    }
}
$aotBootstrap
"@
$services += New-ServiceProject -ServiceName "s3" -ProjectName "S3ColdStart" -ServicePackage "AWSSDK.S3" -FunctionCsContent $s3FunctionCs -CompilationMode $CompilationMode -TempDir $tempDir

# --- EC2 ---
$ec2FunctionCs = @"
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Amazon.EC2;
using Amazon.EC2.Model;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ColdStartBenchmark;

public class Function
{
    public async Task<string> FunctionHandler(object input, ILambdaContext context)
    {
        var client = new AmazonEC2Client();
        var response = await client.DescribeRegionsAsync(new DescribeRegionsRequest());
        return `$"Found {response.Regions.Count} regions";
    }
}
$aotBootstrap
"@
$services += New-ServiceProject -ServiceName "ec2" -ProjectName "Ec2ColdStart" -ServicePackage "AWSSDK.EC2" -FunctionCsContent $ec2FunctionCs -CompilationMode $CompilationMode -TempDir $tempDir

# ============================================================================
# Step 3: Build and package each function
# ============================================================================

$architectures = @(
    @{ Suffix = "x64";   LambdaArch = "x86_64"; RuntimeId = "linux-x64" },
    @{ Suffix = "arm64"; LambdaArch = "arm64";  RuntimeId = "linux-arm64" }
)

foreach ($svc in $services) {
    Write-Host "--- Building $($svc.Name) function ($CompilationMode) ---" -ForegroundColor Yellow

    foreach ($arch in $architectures) {
        $functionName = "$FunctionPrefix-$($svc.Name)-coldstart$modeSuffix-$($arch.Suffix)"
        $publishDir = Join-Path $svc.Dir "publish-$($arch.Suffix)"
        $zipPath = Join-Path $tempDir "$functionName.zip"

        Write-Host "  Building for $($arch.LambdaArch) ($CompilationMode)..."
        # Reset LASTEXITCODE before build (AWS CLI stderr can pollute it in Windows PowerShell 5.1)
        $global:LASTEXITCODE = 0

        $publishArgs = @(
            "publish", $svc.Dir,
            "-c", "Release",
            "-r", $arch.RuntimeId,
            "-o", $publishDir
        )

        if ($selfContained) {
            $publishArgs += "--self-contained", "true"
        } else {
            $publishArgs += "--self-contained", "false"
        }

        $buildOutput = & dotnet @publishArgs 2>&1
        $buildExitCode = $LASTEXITCODE

        if ($buildExitCode -ne 0) {
            Write-Host "  ERROR: Failed to build $functionName (exit code: $buildExitCode)" -ForegroundColor Red
            Write-Host "  Build output:" -ForegroundColor Red
            $buildOutput | ForEach-Object { Write-Host "    $_" }
            exit 1
        }

        # For NativeAOT, verify the bootstrap binary exists
        if ($CompilationMode -eq "NativeAOT") {
            $bootstrapPath = Join-Path $publishDir "bootstrap"
            if (-not (Test-Path $bootstrapPath)) {
                # On Windows cross-compile, the output might be named differently
                $exeName = (Get-ChildItem $publishDir -Filter "*.exe" | Select-Object -First 1)
                if ($null -eq $exeName) {
                    $exeName = (Get-ChildItem $publishDir -Filter "$($svc.Project -replace '.csproj','')" | Select-Object -First 1)
                }
                if ($null -ne $exeName) {
                    Copy-Item $exeName.FullName $bootstrapPath
                }
            }
        }

        # Create zip package
        Write-Host "  Packaging $functionName..."
        if (Test-Path $zipPath) { Remove-Item $zipPath }

        # Use .NET to create zip since Compress-Archive can be slow
        Add-Type -AssemblyName System.IO.Compression.FileSystem
        [System.IO.Compression.ZipFile]::CreateFromDirectory($publishDir, $zipPath)

        # Create or update Lambda function
        Write-Host "  Deploying $functionName ($($arch.LambdaArch), $CompilationMode)..."

        $existingFunc = aws lambda get-function --function-name $functionName --region $Region 2>$null
        if ($LASTEXITCODE -eq 0) {
            # Update existing function
            aws lambda update-function-code `
                --function-name $functionName `
                --zip-file "fileb://$zipPath" `
                --region $Region `
                --no-cli-pager | Out-Null

            aws lambda wait function-updated --function-name $functionName --region $Region

            $archValue = $arch.LambdaArch
            $updateArgs = @(
                "lambda", "update-function-configuration",
                "--function-name", $functionName,
                "--handler", $svc.Handler,
                "--runtime", $lambdaRuntime,
                "--memory-size", "512",
                "--timeout", "30",
                "--architectures", $archValue,
                "--region", $Region,
                "--no-cli-pager"
            )
            & aws @updateArgs | Out-Null
        } else {
            # Create new function
            $archValue = $arch.LambdaArch
            $createArgs = @(
                "lambda", "create-function",
                "--function-name", $functionName,
                "--runtime", $lambdaRuntime,
                "--handler", $svc.Handler,
                "--role", $RoleArn,
                "--zip-file", "fileb://$zipPath",
                "--memory-size", "512",
                "--timeout", "30",
                "--architectures", $archValue,
                "--region", $Region,
                "--no-cli-pager"
            )
            & aws @createArgs | Out-Null
        }

        if ($LASTEXITCODE -ne 0) {
            Write-Error "Failed to deploy $functionName"
            exit 1
        }

        Write-Host "  Waiting for $functionName to be active..."
        aws lambda wait function-active-v2 --function-name $functionName --region $Region

        Write-Host "  ✓ $functionName deployed" -ForegroundColor Green
    }
}

# ============================================================================
# Step 4: Verify all functions
# ============================================================================

Write-Host ""
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "Verifying Deployed Functions ($CompilationMode)" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan

$allFunctions = @()
foreach ($svc in $services) {
    foreach ($arch in $architectures) {
        $functionName = "$FunctionPrefix-$($svc.Name)-coldstart$modeSuffix-$($arch.Suffix)"
        $allFunctions += $functionName
    }
}

$allOk = $true
foreach ($functionName in $allFunctions) {
    $funcInfo = aws lambda get-function --function-name $functionName --region $Region 2>$null | ConvertFrom-Json
    if ($null -ne $funcInfo) {
        $state = $funcInfo.Configuration.State
        $runtime = $funcInfo.Configuration.Runtime
        $memory = $funcInfo.Configuration.MemorySize
        $funcArch = $funcInfo.Configuration.Architectures -join ","
        Write-Host "  ✓ $functionName — State: $state, Runtime: $runtime, Memory: ${memory}MB, Arch: $funcArch" -ForegroundColor Green
    } else {
        Write-Host "  ✗ $functionName — NOT FOUND" -ForegroundColor Red
        $allOk = $false
    }
}

# Cleanup temp directory
Write-Host ""
Write-Host "Cleaning up temp build directory..."
Remove-Item -Recurse -Force $tempDir -ErrorAction SilentlyContinue

# Summary
Write-Host ""
if ($allOk) {
    Write-Host "========================================" -ForegroundColor Green
    Write-Host "All 6 Lambda functions ($CompilationMode) deployed successfully!" -ForegroundColor Green
    Write-Host "========================================" -ForegroundColor Green
} else {
    Write-Host "========================================" -ForegroundColor Red
    Write-Host "Some functions failed to deploy. Check errors above." -ForegroundColor Red
    Write-Host "========================================" -ForegroundColor Red
}

Write-Host ""
Write-Host "Next steps:" -ForegroundColor Yellow
Write-Host "  1. Run cold start benchmarks:"
$modeArg = if ($modeSuffix -ne "") { " --mode-suffix $modeSuffix" } else { "" }
Write-Host "     dotnet run -c Release --project sdk/test/Performance/LambdaBenchmarks/LambdaBenchmarksRunner/LambdaBenchmarksRunner.csproj -- coldstart-initduration --iterations 100 --region $Region --prefix $FunctionPrefix$modeArg"
Write-Host ""
Write-Host "  2. After collecting results, clean up:"
Write-Host "     .\Cleanup-Lambda.ps1 -Region $Region"
Write-Host ""
Write-Host "  3. Fill in the Lambda Cold Start Times section of report.md"
