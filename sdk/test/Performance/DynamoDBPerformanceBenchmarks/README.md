# DynamoDB Performance Benchmarks

## Run from CLI

From `DynamoDBPerformanceBenchmarks` directory:

- Run all benchmarks (mocked client):
  - `dotnet run -- --client mocked`
- Run all benchmarks (real AWS client):
  - `dotnet run -- --client aws`
- Run a specific benchmark type:
  - `dotnet run -- --client mocked --benchmarks DynamoDbContextLoadBenchmark`
- Filter by BenchmarkDotNet filter:
  - `dotnet run -- --client mocked --filter *DynamoDbContextLoadBenchmark*`

## Override benchmark parameters (CLI)

Use `--key=value` or `--key value`:

- `dotnet run -- --client mocked --itemSize Small --attributeCount Count10 --benchmarks TableGetItemBenchmark`

Supported keys:
- `--itemSize` (`Small`, `Large`)
- `--attributeCount` (`Count10`, `Count50`, `Count200`)
- `--expressionStyle` (`None`, `Simple`, `Compound`)
- `--objectComplexity` (`Flat`, `Nested`)
- `--converterUsage` (`Default`, `Custom`, `Mixed`) (context benchmarks)
- `--annotationStyle` (`Minimal`, `Standard`, `Advanced`, `PolymorphicFlatten`) (context benchmarks)

## Notes

- Real client benchmarks require valid AWS credentials and an accessible DynamoDB endpoint.
- Live benchmarks create `BenchmarkTable` if it does not exist.
- Mocked client benchmarks use the in-process HTTP mock handler.
