#!/bin/bash


cd /perf-test/sdk/test/Performance/EC2PerformanceBenchmarks
dotnet build ./Performance.csproj  --configuration Release

dotnet run --project ./Performance.csproj --configuration Release --framework net8.0

export DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=1
pwsh -File "/perf-test/sdk/test/Performance/storeBenchmarkOutput.ps1" /perf-test/sdk/test/Performance/EC2PerformanceBenchmarks/BenchmarkDotNet.Artifacts/results/AWSSDK.Benchmarks.S3Benchmarks-report.csv
pwsh -File "/perf-test/sdk/test/Performance/storeBenchmarkOutput.ps1" /perf-test/sdk/test/Performance/EC2PerformanceBenchmarks/BenchmarkDotNet.Artifacts/results/AWSSDK.Benchmarks.DynamoBenchmarks-report.csv
pwsh -File "/perf-test/sdk/test/Performance/storeBenchmarkOutput.ps1" /perf-test/sdk/test/Performance/EC2PerformanceBenchmarks/BenchmarkDotNet.Artifacts/results/AWSSDK.Benchmarks.SQSBenchmarks-report.csv
pwsh -File "/perf-test/sdk/test/Performance/storeBenchmarkOutput.ps1" /perf-test/sdk/test/Performance/EC2PerformanceBenchmarks/BenchmarkDotNet.Artifacts/results/AWSSDK.Benchmarks.SNSBenchmarks-report.csv
pwsh -File "/perf-test/sdk/test/Performance/storeBenchmarkOutput.ps1" /perf-test/sdk/test/Performance/EC2PerformanceBenchmarks/BenchmarkDotNet.Artifacts/results/AWSSDK.Benchmarks.CloudwatchBenchmarks-report.csv
pwsh -File "/perf-test/sdk/test/Performance/storeBenchmarkOutput.ps1" /perf-test/sdk/test/Performance/EC2PerformanceBenchmarks/BenchmarkDotNet.Artifacts/results/AWSSDK.Benchmarks.CloudwatchLogsBenchmarks-report.csv
