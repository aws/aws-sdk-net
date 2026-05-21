# Performance Benchmarks

## Motivation

The purpose of this solution is to provide performance benchmarks using [Benchmark Dotnet](https://github.com/dotnet/BenchmarkDotNet) for the .Net SDK on Lambda. 

## Structure

`LambdaBenchmarks` project contains the functions should be benchmarked. 
`LambdaBenchmarksRunner` project contains a console application that goes over the following steps:
* Setup: 
    * Deploy `LambdaBenchmarks` functions to Lambda.
    * Created the resources needed to run the benchmarks (ex: S3 bucket, DynamoDB table).
* Benchmark: Invoke the function that was deployed in the Setup phase.
* Cleanup:
    * Delete the lambda function that was used in this test.
    * Remove any resources that were created in the Setup phase.

## How to run the benchmarks

The lambda functions are using `LambdaBenchmarksTestRole` as the function-role, which should be created beforehand manually.

The benchmarks can be run from a terminal of your choice with the dotnet cli installed. Inside the performance folder, the command to run the benchmarks is:
```
dotnet run --configuration Release performance.csproj
```

To run a subset of the benchmarks (for example just DynamoDB), go to Program.cs and comment all the other benchmarks. The Program.cs file should look like:
```
using AWSSDK.Benchmarks;
using LambdaBenchmarksRunner;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<DynamoDBBenchmarksRunner>();
```

The variations of the benchmarks can be found in `LambdaBenchmarkBase.cs` as properties marked with `Params` attribute.

```
    [Params(256, 512, 1024)]
    public virtual int MemorySize { get; set; }

    [Params("dotnet6")] // only one runtime for now but it is possible to add more in the future
    public virtual string LambdaRuntime { get; set; }

    [Params("x86_64", "arm64")]
    public virtual string Architecture { get; set; }

    [Params(true, false)]
    public virtual bool ForceColdStart { get; set; }
```


## How to view the results

BenchmarkDotNet stores the output of the benchmarks in `BenchmarkDotnet.Artifacts\results` folder. There you can view the csv file that contains the appropriate headers and the results of each benchmark. The logs itself is another good place to view the full output of the benchmarks.

## Cold Start Benchmarks

The `ColdStartBenchmarksRunner` and `ColdStartInitDurationRunner` measure Lambda cold start total duration (INIT + INVOKE) for three services:
- **STS** — `GetCallerIdentity`
- **S3** — `ListBuckets`
- **EC2** — `DescribeRegions`

Each is tested on both `x86_64` and `arm64` architectures with 512MB memory in us-east-1.

### Prerequisites

1. **Deploy the cold start Lambda functions** using the provided script:
   ```powershell
   # From the LambdaBenchmarks directory
   .\Deploy-LambdaColdStart.ps1 -Region us-east-1
   ```
   This deploys 6 Lambda functions (3 services × 2 architectures) with the naming convention `dotnet-perf-{service}-coldstart-{arch}`.

2. **AWS credentials** must be configured with permissions for Lambda (invoke, update-function-configuration, get-function-configuration).

### Running Cold Start Benchmarks

```bash
# Run only cold start benchmarks
dotnet run -c Release --project LambdaBenchmarksRunner/LambdaBenchmarksRunner.csproj -- --filter *ColdStart*
```

The benchmark:
- Forces a cold start each iteration by updating the function's environment variable
- Waits for the update to complete
- Invokes the function with `LogType=Tail`
- Confirms the invocation was a cold start by checking for `Init Duration` in the REPORT line
- Records the total `Duration` (INIT + INVOKE) from the REPORT line as the benchmark metric
- Runs 100 measurement iterations with 5 warmup iterations per benchmark (network operation)

### Configuration

The cold start benchmark uses `[SimpleJob(RunStrategy.Monitoring, warmupCount: 5, iterationCount: 100, invocationCount: 1)]`:
- `InvocationCount=1` — one Lambda invocation per iteration
- `IterationCount=100` — 100 cold start measurements (meets the minimum 100 for network operations)
- `WarmupCount=5` — 5 warmup iterations discarded

Parameters:
- `Architecture`: `x64`, `arm64`
- `FunctionPrefix`: `dotnet-perf` (must match Deploy-LambdaColdStart.ps1)

### Why BenchmarkDotNet cannot measure Total Duration correctly

The benchmark metric is the **total Duration (INIT + INVOKE)** reported by Lambda in the REPORT log line. This includes the INIT phase (runtime bootstrap, assembly loading) plus the first INVOKE (SDK client construction, HTTP stack setup, first-time JIT, credential resolution, and the actual API call). The presence of `Init Duration` in the REPORT line confirms the invocation was a cold start.

This is fundamentally different from what BenchmarkDotNet measures:

- **BenchmarkDotNet measures:** The wall-clock time of the `[Benchmark]` method, which includes: updating the function configuration → waiting for the update to complete → invoking the function → receiving the response → parsing the log. This total time is dominated by the config update/wait overhead (~3-5 seconds), not the actual cold start (~1,200-1,700ms).

- **What we need:** The total Duration extracted from the REPORT line in `LogResult` (using `LogType="Tail"`). This is Lambda's internal measurement of the full cold start execution time (INIT + INVOKE). The INIT phase alone does not capture the SDK's first-call overhead.

BenchmarkDotNet has no mechanism to report a custom metric (like a value extracted from a response) as the primary benchmark result. It always reports the method execution time.

### Custom Runner for Total Duration (recommended)

Use the `coldstart-initduration` command to get the total Duration metric:

```bash
dotnet run -c Release --project LambdaBenchmarksRunner/LambdaBenchmarksRunner.csproj -- coldstart-initduration --iterations 100 --region us-east-1
```

This custom runner (`ColdStartInitDurationRunner.cs`) extracts the total Duration (INIT + INVOKE) from Lambda's LogResult for confirmed cold starts, and reports mean, p50, p90, p99, std_dev statistics.

### Cleanup

After benchmarking, delete the Lambda functions:
```powershell
# Delete all 6 cold start functions
aws lambda delete-function --function-name dotnet-perf-sts-coldstart-x64 --region us-east-1
aws lambda delete-function --function-name dotnet-perf-sts-coldstart-arm64 --region us-east-1
aws lambda delete-function --function-name dotnet-perf-s3-coldstart-x64 --region us-east-1
aws lambda delete-function --function-name dotnet-perf-s3-coldstart-arm64 --region us-east-1
aws lambda delete-function --function-name dotnet-perf-ec2-coldstart-x64 --region us-east-1
aws lambda delete-function --function-name dotnet-perf-ec2-coldstart-arm64 --region us-east-1
```

## Other files

There are other files that aren't covered above such as `start.sh` `storeBenchmarkOutput.ps1`. `start.sh` can be used to build the solution and run the benchmarks, and it will call `storeBenchmarkOutput.ps1` internally to publish the results to a `CloudWatch`
