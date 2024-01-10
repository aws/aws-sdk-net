#!/bin/bash

dotnet build "./LambdaBenchmarksRunner/LambdaBenchmarksRunner.csproj" --configuration Release
dotnet run --project "./LambdaBenchmarksRunner/LambdaBenchmarksRunner.csproj" --configuration Release

pwsh -File "../storeBenchmarkOutput.ps1" "./BenchmarkDotNet.Artifacts/results/LambdaBenchmarksRunner.DynamoDBBenchmarksRunner-report.csv" AWS_Lambda
pwsh -File "../storeBenchmarkOutput.ps1" "./BenchmarkDotNet.Artifacts/results/LambdaBenchmarksRunner.S3BenchmarksRunner-report.csv" AWS_Lambda
pwsh -File "../storeBenchmarkOutput.ps1" "./BenchmarkDotNet.Artifacts/results/LambdaBenchmarksRunner.S3TransferUtilityBenchmarksRunner-report.csv" AWS_Lambda
