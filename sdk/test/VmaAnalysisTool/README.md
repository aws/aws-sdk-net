# VMA Analysis Tool

A command-line tool for analyzing Virtual Memory Area (VMA) impact of different ArrayPool chunk sizes in multipart downloads.

## Purpose

This tool helps determine optimal chunk size parameters for the AWS SDK for .NET's multipart download feature to prevent Linux VMA limit exhaustion (default limit: 65,536 VMAs).

## Building

```bash
cd sdk/test/VmaAnalysisTool
dotnet build
```

## Usage

### Show Help

```bash
dotnet run -- --help
```

### Available Commands

| Command | Description |
|---------|-------------|
| `quick` | Run a quick test to verify the tool works |
| `chunk-sweep` | Test impact of different chunk sizes |
| `concurrency-sweep` | Test impact of different concurrency levels |
| `maxinmem-sweep` | Test impact of different MaxInMemoryParts values |
| `vma-limit` | Test configurations near VMA limits |
| `compare` | Compare dynamic vs fixed chunk sizing |
| `optimal` | Find optimal chunk sizes for various scenarios |
| `full-matrix` | Run complete test matrix (warning: slow!) |
| `single` | Run a single test with specific parameters |
| `calculate` | Calculate recommended chunk size for given parameters |
| `info` | Show system VMA information |

### Quick Start

```bash
# Run a quick test to verify everything works
dotnet run -- quick

# View system VMA information
dotnet run -- info

# Calculate recommended chunk size for your scenario
dotnet run -- calculate --part-size 10 --max-in-memory 100 --concurrent 10
```

### Sweep Tests

```bash
# Test different chunk sizes with fixed parameters
dotnet run -- chunk-sweep --part-size 10 --max-in-memory 100 --concurrent 10

# Test different concurrency levels
dotnet run -- concurrency-sweep --part-size 10 --max-in-memory 100 --chunk-size 64

# Test different MaxInMemoryParts values
dotnet run -- maxinmem-sweep --part-size 10 --concurrent 10 --chunk-size 64
```

### Single Test

```bash
# Run a single specific configuration
dotnet run -- single --part-size 10 --chunk-size 512 --max-in-memory 100 --concurrent 10 --total-parts 500
```

### Compare Dynamic vs Fixed

```bash
# Compare dynamic chunk sizing vs fixed 64KB
dotnet run -- compare
```

### Export Results

```bash
# Export results to CSV for further analysis
dotnet run -- chunk-sweep --export-csv results.csv
```

### Full Analysis

```bash
# Find optimal parameters (takes several minutes)
dotnet run -- optimal --export-csv optimal_analysis.csv

# Run complete test matrix (warning: can take hours!)
dotnet run -- full-matrix --confirm --export-csv full_matrix.csv
```

## Parameters

| Parameter | Description | Default |
|-----------|-------------|---------|
| `--part-size` | Part size in MB | 10 |
| `--chunk-size` | Chunk size in KB | 64 |
| `--max-in-memory` | MaxInMemoryParts | 100 |
| `--concurrent` | ConcurrentServiceRequests | 10 |
| `--total-parts` | Total parts to simulate | 500 |
| `--target-vma` | Target maximum VMAs | 50000 |
| `--safety-factor` | Safety factor for calculation | 2.5 |
| `--verbose` | Enable verbose output | false |
| `--export-csv` | Export results to CSV file | - |

## Understanding Results

### VMA Status

- ✓ **SAFE**: Peak VMA count below safe threshold (50,000)
- ⚠ **WARNING**: Peak VMA count at 80-100% of safe threshold
- ⚠ **UNSAFE**: Peak VMA count exceeds safe threshold but below limit
- ✗ **EXCEEDED LIMIT**: Peak VMA count exceeds Linux limit (65,536)

### Key Metrics

- **Est. VMA**: Calculated maximum VMA count (MaxInMemoryParts × ChunksPerPart)
- **Peak VMA**: Actual peak VMA count observed during simulation
- **Peak Chunks**: Maximum concurrent chunks allocated
- **Safety Margin**: Percentage below safe threshold

## Formula for Dynamic Chunk Size

```
ChunkSize = min(
    max(PartSize / TargetChunksPerPart, MIN_CHUNK_SIZE),
    MAX_CHUNK_SIZE
)

where:
TargetChunksPerPart = MaxSafeVMAs / (MaxInMemoryParts × ConcurrentRequests × SafetyFactor)

Constants:
- MaxSafeVMAs: 50,000 (leaves 15K headroom below 65K limit)
- SafetyFactor: 2.5 (accounts for other application VMAs)
- MIN_CHUNK_SIZE: 64KB (ArrayPool efficiency)
- MAX_CHUNK_SIZE: 16MB (avoid excessive memory per chunk)
```

## Example Analysis

```
=== CHUNK SIZE CALCULATION ===

Input Parameters:
  Part Size:                  10 MB
  MaxInMemoryParts:           100
  ConcurrentServiceRequests:  10
  Target Max VMAs:            50,000
  Safety Factor:              2.5

Calculated Values:
  Recommended Chunk Size:     512KB
  Chunks per Part:            20
  Max Concurrent Chunks:      2,000
  Estimated Peak VMAs:        2,000
  Safety Margin:              96.0%

Formula:
  TargetChunksPerPart = 50000 / (100 × 10 × 2.5) = 20
  ChunkSize = 10MB / 20 = 512KB
```

## Platform Notes

### Linux
- Real VMA tracking via `/proc/self/maps`
- Accurate peak VMA measurements
- Recommended for final validation

### Windows/macOS
- Estimation mode based on ArrayPool allocations
- Useful for development and preliminary testing
- May not reflect exact Linux behavior

### Running on Linux (Docker)

```bash
# Build and run in Docker for accurate Linux VMA tracking
docker run -it --rm -v $(pwd):/app -w /app mcr.microsoft.com/dotnet/sdk:8.0 \
    dotnet run --project /app -- optimal
```

## Recommendations Based on Analysis

After running the full analysis, use the recommendations to:

1. **Configure TransferUtilityConfig**:
   ```csharp
   var config = new TransferUtilityConfig
   {
       ConcurrentServiceRequests = 10,
       // Future: AutomaticChunkSizing will use calculated values
   };
   ```

2. **Set MaxInMemoryParts appropriately**:
   - Low memory: 50-100
   - Standard: 100-500
   - High memory: 500-1024

3. **Understand trade-offs**:
   - Larger chunks = fewer VMAs but more memory per chunk
   - More concurrency = higher VMA count
   - Higher MaxInMemoryParts = higher VMA count
