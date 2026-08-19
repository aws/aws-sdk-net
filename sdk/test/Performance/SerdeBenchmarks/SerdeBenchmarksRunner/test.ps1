# Performance test wrapper for Windows.
# Runs the published SerdeBenchmarks binary and converts BDN JSON output to
# the expected results format for CI performance test evaluation.
#
# Usage: .\test.ps1 --suite serde|e2e
# This script expects to be in the same directory as the published SerdeBenchmarksRunner.dll.

$ErrorActionPreference = 'Stop'

# Parse --suite and --product-id from args
$suite = "e2e"
$productId = "dotnetv4"
for ($i = 0; $i -lt $args.Count; $i++) {
    if ($args[$i] -eq "--suite" -and ($i + 1) -lt $args.Count) {
        $suite = $args[$i + 1]
    }
    if ($args[$i] -eq "--product-id" -and ($i + 1) -lt $args.Count) {
        $productId = $args[$i + 1]
    }
}

$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path

# Get build metadata (from build-metadata.json written by artifact step, or fallback)
$metadataPath = Join-Path $ScriptDir "build-metadata.json"
if (Test-Path $metadataPath) {
    $metadata = Get-Content $metadataPath | ConvertFrom-Json
    $CommitId = $metadata.commitId
    $SdkVersion = $metadata.productVersion
} else {
    $CommitId = "unknown"
    $SdkVersion = "unknown"
}

# Clean previous artifacts
Remove-Item -Recurse -Force "$ScriptDir\BenchmarkDotNet.Artifacts" -ErrorAction SilentlyContinue

# Run the published benchmark DLL with dotnet (redirect all output to stderr to keep stdout clean for JSON)
$null = & dotnet "$ScriptDir\SerdeBenchmarksRunner.dll" --suite $suite --filter '*' --exporters JSON 2>&1 | ForEach-Object { [Console]::Error.WriteLine($_) }
if ($LASTEXITCODE -ne 0) { throw "Benchmark execution failed with exit code $LASTEXITCODE" }

# Find JSON result files
$ResultsDir = Join-Path $ScriptDir "BenchmarkDotNet.Artifacts\results"
$JsonFiles = Get-ChildItem -Path $ResultsDir -Filter "*-report-full-compressed.json" -ErrorAction SilentlyContinue

if (-not $JsonFiles -or $JsonFiles.Count -eq 0) {
    throw "ERROR: No benchmark results produced. Benchmarks likely failed."
}

# Verify all benchmarks produced results (BDN skips crashed benchmarks silently)
$totalBenchmarks = 0
$failedBenchmarks = 0
foreach ($file in $JsonFiles) {
    $data = Get-Content $file.FullName | ConvertFrom-Json
    foreach ($b in $data.Benchmarks) {
        $totalBenchmarks++
        if ($null -eq $b.Statistics) { $failedBenchmarks++ }
    }
}
if ($failedBenchmarks -gt 0) {
    throw "ERROR: $failedBenchmarks of $totalBenchmarks benchmarks failed (no Statistics). Aborting."
}

$Epoch = [int][double]::Parse((Get-Date -UFormat %s))

# Parse all BDN JSON files and build output with latency + memory metrics
$AllResults = @()
foreach ($file in $JsonFiles) {
    $bdnData = Get-Content $file.FullName | ConvertFrom-Json
    foreach ($benchmark in $bdnData.Benchmarks) {
        if ($null -eq $benchmark.Statistics) { continue }

        $name = $benchmark.Method -replace '_', '.'
        $name = $name.ToLowerInvariant()

        # Latency metric (convert ns → μs to match CloudWatch storage unit)
        $measurements = @()
        if ($benchmark.Statistics.Mean) { $measurements += $benchmark.Statistics.Mean / 1000 }
        if ($benchmark.Statistics.Median) { $measurements += $benchmark.Statistics.Median / 1000 }
        if ($benchmark.Statistics.Percentiles.P50) { $measurements += $benchmark.Statistics.Percentiles.P50 / 1000 }
        if ($benchmark.Statistics.Percentiles.P90) { $measurements += $benchmark.Statistics.Percentiles.P90 / 1000 }
        if ($benchmark.Statistics.Percentiles.P95) { $measurements += $benchmark.Statistics.Percentiles.P95 / 1000 }

        $AllResults += @{
            name         = $name
            description  = if ($benchmark.FullName) { $benchmark.FullName } else { $benchmark.Method }
            unit         = "Microseconds"
            date         = $Epoch
            dimensions   = @( @{ name = "OS"; value = "Windows" } )
            measurements = $measurements
        }

        # Memory allocation metric
        $allocatedBytes = 0
        if ($benchmark.Memory -and $benchmark.Memory.BytesAllocatedPerOperation) {
            $allocatedBytes = $benchmark.Memory.BytesAllocatedPerOperation
        }

        $AllResults += @{
            name         = "$name.allocated"
            description  = "$(if ($benchmark.FullName) { $benchmark.FullName } else { $benchmark.Method }) - Memory Allocated"
            unit         = "Bytes"
            date         = $Epoch
            dimensions   = @( @{ name = "OS"; value = "Windows" } )
            measurements = @($allocatedBytes)
        }
    }
}

# Build output
$output = @{
    productId  = $productId
    commitId   = $CommitId
    sdkVersion = $SdkVersion
    results    = $AllResults
}

# Output JSON to stdout (CI captures via pipe to output.json)
$output | ConvertTo-Json -Depth 10 -Compress
