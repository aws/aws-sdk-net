#!/usr/bin/env bash
# Performance test wrapper for Linux.
# Runs the published SerdeBenchmarks DLL and converts BDN JSON output to
# the expected results format for CI performance test evaluation.
#
# Usage: ./test.sh [--suite serde|e2e]
# This script expects to be in the same directory as the published SerdeBenchmarksRunner.dll.
# Requires: dotnet runtime in PATH, jq installed.

set -e

SUITE="e2e"
PRODUCT_ID="dotnetv4"
while [[ $# -gt 0 ]]; do
    case "$1" in
        --suite) SUITE="$2"; shift 2 ;;
        --product-id) PRODUCT_ID="$2"; shift 2 ;;
        *) shift ;;
    esac
done

SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"

# Get build metadata (from build-metadata.json written by artifact step, or fallback)
if [ -f "$SCRIPT_DIR/build-metadata.json" ]; then
    COMMIT_ID="$(jq -r '.commitId' "$SCRIPT_DIR/build-metadata.json")"
    SDK_VERSION="$(jq -r '.productVersion' "$SCRIPT_DIR/build-metadata.json")"
else
    COMMIT_ID="unknown"
    SDK_VERSION="unknown"
fi

# Clean previous artifacts
rm -rf "$SCRIPT_DIR/BenchmarkDotNet.Artifacts"

# Run the published benchmark DLL with dotnet (BDN output goes to stderr)
dotnet "$SCRIPT_DIR/SerdeBenchmarksRunner.dll" --suite "$SUITE" --filter '*' --exporters JSON 1>&2

# Verify all benchmarks produced results (BDN exits 0 even when benchmarks crash)
RESULTS_DIR="$SCRIPT_DIR/BenchmarkDotNet.Artifacts/results"
TOTAL=$(find "$RESULTS_DIR" -name '*-report-full-compressed.json' -print0 2>/dev/null | xargs -0 cat 2>/dev/null | jq -s '[.[] | .Benchmarks[]] | length' 2>/dev/null || echo 0)
SUCCEEDED=$(find "$RESULTS_DIR" -name '*-report-full-compressed.json' -print0 2>/dev/null | xargs -0 cat 2>/dev/null | jq -s '[.[] | .Benchmarks[] | select(.Statistics != null)] | length' 2>/dev/null || echo 0)
if [ "$TOTAL" -eq 0 ]; then
    echo "ERROR: No benchmark results produced. Benchmarks likely failed." >&2
    exit 1
fi
if [ "$TOTAL" -ne "$SUCCEEDED" ]; then
    echo "ERROR: $((TOTAL - SUCCEEDED)) of $TOTAL benchmarks failed (no Statistics). Aborting." >&2
    exit 1
fi

EPOCH=$(date +%s)

# Convert BDN JSON to performance test results format.
# Emits two metrics per benchmark: latency (μs) and memory allocation (bytes).
# Note: BDN reports in nanoseconds. We convert to Microseconds here because
# the CI publisher converts Nanoseconds→Microseconds before CloudWatch publish,
# but the evaluator compares raw measurements against CloudWatch values without
# converting. Using Microseconds directly avoids this unit mismatch.
find "$RESULTS_DIR" -name "*-report-full-compressed.json" -print0 | xargs -0 cat | jq -s --arg productId "$PRODUCT_ID" --arg commitId "$COMMIT_ID" --arg sdkVersion "$SDK_VERSION" --argjson date "$EPOCH" '
{
    productId: $productId,
    commitId: $commitId,
    sdkVersion: $sdkVersion,
    results: [
        .[] | .Benchmarks[]? | select(.Statistics != null) |
        (
            {
                name: (.Method | gsub("_"; ".") | ascii_downcase),
                description: (.FullName // .Method),
                unit: "Microseconds",
                date: $date,
                dimensions: [
                    { name: "OS", value: "Linux" }
                ],
                measurements: [
                    .Statistics.Mean,
                    .Statistics.Median,
                    .Statistics.Percentiles.P50,
                    .Statistics.Percentiles.P90,
                    .Statistics.Percentiles.P95
                ] | map(select(. != null)) | map(. / 1000)
            }
        ),
        (
            {
                name: ((.Method | gsub("_"; ".") | ascii_downcase) + ".allocated"),
                description: ((.FullName // .Method) + " - Memory Allocated"),
                unit: "Bytes",
                date: $date,
                dimensions: [
                    { name: "OS", value: "Linux" }
                ],
                measurements: [
                    .Memory.BytesAllocatedPerOperation // 0
                ]
            }
        )
    ]
}'
