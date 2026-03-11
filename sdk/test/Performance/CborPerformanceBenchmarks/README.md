# CBOR Performance Benchmarks for AWS SDK for .NET

This project contains performance benchmarks for evaluating the CBOR protocol in the AWS SDK for .NET compared to the existing protocols.

Benchmarks are implemented using [BenchmarkDotNet](https://benchmarkdotnet.org/) and run against AWS service operations to measure request/response serialization, deserialization, and total request times.

## Project Structure

- `BaseBenchmarks.cs` — Shared benchmark base logic (setup, iteration, metrics recording).
- `CloudWatch.ListMetricsBenchmarks.cs` — Example benchmark for the CloudWatch `ListMetrics` API.
- `Program.cs` — Benchmark runner entry point.
- `PrepareBenchmarkServices.ps1` — Script to generate services with the required protocol implementations.

## Dual Protocol Setup

Benchmarks require two versions of the service clients:

1. **CBOR protocol** — Generated in the current repo (`aws-sdk-net`).
2. **Old protocols** — Generated in a parallel repo (`aws-sdk-net-old-protocols`).

The `PrepareBenchmarkServices.ps1` script ensures both repos are aligned and services are generated for testing.

## Running Benchmarks

1. Clone both repositories:

```
git clone https://github.com/aws/aws-sdk-net.git aws-sdk-net
git clone https://github.com/aws/aws-sdk-net.git aws-sdk-net-old-protocols
```
 Make sure they are in sibling directories.

2. Run the preparation script to generate protocol-specific services:
```
cd sdk/test/Performance/CborPerformanceBenchmarks/
./PrepareBenchmarkServices.ps1
```

This will update both repos with service projects configured for the benchmark.

3. Build and run the benchmarks:

```
cd CborPerformanceBenchmarksRunner/
dotnet build --configuration Release
dotnet run -c Release
```