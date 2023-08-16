# Performance Benchmarks

## Motivation

The purpose of this solution is to provide performance benchmarks usinng [Benchmark Dotnet](https://github.com/dotnet/BenchmarkDotNet). 

## Structure

All of the benchmarks for these services test a real API call, so the request and responses are not mocked.

We also include benchmarks for just the marshalling and unmarshalling of both the RestJson and XML protocols, included in MarshallAndUnmarshallBenchmarks.cs

## How to run the benchmarks

The benchmarks can be run from a terminal of your choice with the dotnet cli installed. Inside the performance folder, the command to run the benchmarks is:
```
dotnet run --configuration Release performance.csproj
```

To run a subset of the benchmarks (for example just S3), go to Program.cs and comment all the other benchmarks. The Program.cs file should look like:
```
using AWSSDK.Benchmarks;
using BenchmarkDotNet.Running;

namespace AWSSDK.Benchmarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<S3Benchmarks>();
        }
    }
}
```

## How to view the results

BenchmarkDotNet stores the output of the benchmarks in performance\ECPerformanceBenchmarks\BenchmarkDotnet.Artifacts\results. There you can view the csv file that contains the appropriate headers and the results of each benchmark. The logs itself is another good place to view the full output of the benchmarks.

## Other files

There are other files that aren't covered above such as `start.sh` `storeOutput.ps1` and `before.sh`. `start.sh` and `before.sh` are scripts that are used internally within our own systems to run the performance benchmarks. `storeOutput.ps1` is used internally to publish this data to a cloudwatch namespace so we have metrics on the performance.