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

## Other files

There are other files that aren't covered above such as `start.sh` `storeBenchmarkOutput.ps1`. `start.sh` can be used to build the solution and run the benchmarks, and it will call `storeBenchmarkOutput.ps1` internally to publish the results to a `CloudWatch`