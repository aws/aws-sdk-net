# EC2 Performance Benchmarks

## Motivation

The purpose of this solution is to provide performance benchmarks using [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet).

## Structure

The benchmarks are organized into the following categories:

### Endpoint Resolution Benchmarks (`EndpointResolutionBenchmarks.cs`)
Measures the time to resolve endpoints for S3 and Lambda services. Tests increasingly complex rule evaluation paths including:
- S3 vanilla virtual addressing
- S3 path style addressing
- S3 Express One Zone (Data Plane with short zone name)
- S3 Access Point ARN resolution
- S3 Outposts ARN resolution
- Lambda standard endpoint resolution
- Lambda GovCloud with FIPS and DualStack

These benchmarks are local (no network I/O) and measure pure endpoint resolution performance.

### Marshalling and Unmarshalling Benchmarks (`MarshallAndUnmarshallBenchmarks.cs`)
Tests serialization and deserialization performance for:
- JSON protocol (DynamoDB PutItem request/response)
- XML/Query protocol (EC2 RunInstances request/response)

These benchmarks are local (no network I/O) and use generated sample data.

### Service API Benchmarks
Real API call benchmarks for the following services:
- **S3** (`S3Benchmarks.cs`) — PutObject, GetObject operations
- **DynamoDB** (`DynamoBenchmarks.cs`) — Low-level API, Document Model, and Object Persistence Model operations
- **SQS** (`SQSBenchmarks.cs`) — SendMessage, ReceiveMessage operations
- **SNS** (`SNSBenchmarks.cs`) — Publish operations
- **CloudWatch** (`CloudwatchBenchmarks.cs`) — PutMetricData operations
- **CloudWatch Logs** (`CloudwatchLogsBenchmarks.cs`) — PutLogEvents operations

These benchmarks require AWS credentials and make real API calls.

## Prerequisites

- .NET 8.0 SDK
- AWS credentials configured (for service API benchmarks)
- BenchmarkDotNet (included as project dependency)

### End-to-End Benchmarks (DynamoDB Latency, S3 Throughput)

The DynamoDB and S3 throughput benchmarks are **self-contained**: they automatically create and clean up their own AWS resources during `[GlobalSetup]` and `[GlobalCleanup]`.

Optionally, you can provide pre-existing resources via environment variables to skip auto-provisioning:

| Variable | Required | Description | Example |
|----------|----------|-------------|---------|
| `DYNAMODB_BENCHMARK_TABLE` | Optional | Existing DynamoDB table (pk=string, provisioned) | `dotnet-sdk-benchmark` |
| `S3_BENCHMARK_BUCKET` | Optional | Existing S3 Express One Zone directory bucket | `my-bucket--use1-az4--x-s3` |

If not set, the benchmarks will create temporary resources automatically and delete them when complete.

Helper scripts are also provided for manual setup/teardown:
```powershell
# Create resources manually (optional)
.\Setup-DynamoDBTable.ps1 -TableName my-table -Region us-east-1
.\Setup-S3ExpressBucket.ps1 -BucketName my-team-benchmark--use1-az4--x-s3 -Region us-east-1

# Cleanup (optional, only needed if using pre-created resources)
.\Cleanup-DynamoDBTable.ps1 -TableName my-table -Region us-east-1
.\Cleanup-S3ExpressBucket.ps1 -BucketName my-team-benchmark--use1-az4--x-s3 -Region us-east-1
```

## How to Run

### All Benchmarks
```bash
dotnet run --configuration Release --project Performance.csproj
```

### Specific Benchmark Class
Use the `--filter` flag to run specific benchmarks:
```bash
# Endpoint resolution only (no AWS credentials needed)
dotnet run -c Release --project Performance.csproj -- --filter '*EndpointResolution*'

# Marshalling/Unmarshalling only (no AWS credentials needed)
dotnet run -c Release --project Performance.csproj -- --filter '*Marshall*'

# S3 benchmarks only
dotnet run -c Release --project Performance.csproj -- --filter '*S3*'

# DynamoDB benchmarks only
dotnet run -c Release --project Performance.csproj -- --filter '*Dynamo*'
```

## How to View Results

BenchmarkDotNet stores output in `BenchmarkDotNet.Artifacts/results/`. The CSV files contain headers and results for each benchmark. The log files contain the full output including statistical analysis.

## Target Framework

This project targets `net8.0` only. The `ServiceClientGenerator` dependency requires .NET 8.0.
