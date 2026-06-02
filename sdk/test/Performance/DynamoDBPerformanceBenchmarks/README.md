# DynamoDB Performance Benchmarks

## Motivation

These benchmarks measure performance for common DynamoDB API patterns using both the `Table` API and the `DynamoDBContext` API. The suite focuses on serialization, expression handling, and the impact of different table structures and context model annotations.

## Structure

The DynamoDB benchmark suite supports both live and mocked execution. Live benchmarks test real API calls with the AWS SDK client, while mocked benchmarks use an in-process HTTP handler to measure client-side and serialization costs.

- Entry point:
  - `Program.cs` parses CLI arguments, applies parameter overrides, selects benchmark types, and configures BenchmarkDotNet.
- Execution modes:
  - Live mode (`--client aws|real|live`) runs real DynamoDB API calls with `AmazonDynamoDBClient`.
  - Mocked mode (`--client mocked`) uses an in-process HTTP mock handler (`MockDynamoDbClientFactory`) so requests/responses are simulated and client-side costs can be measured in isolation.
- Benchmark categories:
  - `Benchmarks/Table` covers `Table` API operations (`GetItem`, `PutItem`, `Query`, `Scan`, `DeleteItem`).
  - `Benchmarks/DynamoDbContext` covers `DynamoDBContext` object-mapping operations (`Load`, `Save`, `Query`, `Scan`, `Delete`).
- Shared benchmark infrastructure:
  - `Common` contains runtime options, benchmark state setup, response generation, and reusable helpers used by both mocked and live benchmarks.
- Model and payload matrix:
  - Benchmarks vary item size, attribute count, expression style, object complexity, converter usage, and annotation style to compare different table shapes and `DynamoDBContext` mapping strategies.

## How to run the benchmarks

The benchmarks can be run from a terminal of your choice with the dotnet CLI installed. From the `DynamoDBPerformanceBenchmarks` directory:

- Run all benchmarks (mocked client) (shows interactive menu):
  - `dotnet run -c Release -- --client mocked`
- Run all benchmarks (real AWS client):
  - `dotnet run -c Release -- --client aws`
- Run a specific benchmark type:
  - `dotnet run -c Release -- --client mocked --benchmarks DynamoDbContextLoadBenchmark`
- Filter by BenchmarkDotNet filter:
  - `dotnet run -c Release -- --client mocked --filter *DynamoDbContextLoadBenchmark*`

## Benchmark selection behavior

- `--filter` is passed directly to BenchmarkDotNet and runs immediately.
- `--benchmarks` is resolved by the runner and may prompt interactively when multiple matches are found.

## Available benchmark classes

Mocked client:
- `DynamoDbContextDeleteBenchmark` - Measures `DynamoDBContext.Delete*` object deletion patterns with mocked responses.
- `DynamoDbContextLoadBenchmark` - Measures `DynamoDBContext.Load*` object retrieval patterns with mocked responses.
- `DynamoDbContextQueryBenchmark` - Measures `DynamoDBContext.Query*` patterns and expression usage with mocked responses.
- `DynamoDbContextSaveBenchmark` - Measures `DynamoDBContext.Save*` object persistence patterns with mocked responses.
- `DynamoDbContextScanBenchmark` - Measures `DynamoDBContext.Scan*` patterns with mocked responses.
- `TableDeleteItemBenchmark` - Measures low-level `Table.DeleteItem*` operations with mocked responses.
- `TableGetItemBenchmark` - Measures low-level `Table.GetItem*` operations with mocked responses.
- `TablePutItemBenchmark` - Measures low-level `Table.PutItem*` operations with mocked responses.
- `TableQueryBenchmark` - Measures low-level `Table.Query*` operations with mocked responses.
- `TableScanBenchmark` - Measures low-level `Table.Scan*` operations with mocked responses.

Live client:
- `RealDynamoDbContextDeleteBenchmark` - Measures `DynamoDBContext.Delete*` object deletion patterns against a live DynamoDB endpoint.
- `RealDynamoDbContextLoadBenchmark` - Measures `DynamoDBContext.Load*` object retrieval patterns against a live DynamoDB endpoint.
- `RealDynamoDbContextQueryBenchmark` - Measures `DynamoDBContext.Query*` patterns and expression usage against a live DynamoDB endpoint.
- `RealDynamoDbContextSaveBenchmark` - Measures `DynamoDBContext.Save*` object persistence patterns against a live DynamoDB endpoint.
- `RealDynamoDbContextScanBenchmark` - Measures `DynamoDBContext.Scan*` patterns against a live DynamoDB endpoint.
- `RealTableDeleteItemBenchmark` - Measures low-level `Table.DeleteItem*` operations against a live DynamoDB endpoint.
- `RealTableGetItemBenchmark` - Measures low-level `Table.GetItem*` operations against a live DynamoDB endpoint.
- `RealTablePutItemBenchmark` - Measures low-level `Table.PutItem*` operations against a live DynamoDB endpoint.
- `RealTableQueryBenchmark` - Measures low-level `Table.Query*` operations against a live DynamoDB endpoint.
- `RealTableScanBenchmark` - Measures low-level `Table.Scan*` operations against a live DynamoDB endpoint.

## Override benchmark parameters (CLI)

Use `--key=value` or `--key value`:

- `dotnet run -c Release -- --client mocked --itemSize Small --attributeCount Count10 --benchmarks TableGetItemBenchmark`

Supported keys:
- `--itemSize` (`Small`, `Large`)
- `--attributeCount` (`Count10`, `Count50`, `Count200`)
- `--expressionStyle` (`None`, `Simple`, `Compound`)
- `--objectComplexity` (`Flat`, `Nested`)
- `--converterUsage` (`Default`, `Custom`, `Mixed`) (context benchmarks)
- `--annotationStyle` (`Minimal`, `Standard`, `Advanced`, `PolymorphicFlatten`) (context benchmarks)

## How to view results

BenchmarkDotNet outputs results to `BenchmarkDotNet.Artifacts/results` under the benchmark project directory.

## Live benchmark cleanup and teardown

Live benchmark runs provision and use a shared DynamoDB table named `BenchmarkTable`.

Resources created/used during live runs:
- DynamoDB table: `BenchmarkTable`
- Key schema:
  - Partition key: `PartitionKey` (`S`)
  - Sort key: `SortKey` (`S`)
- Billing mode: `PAY_PER_REQUEST`
- Seeded benchmark items written by the benchmark state setup

Cleanup behavior:
- The table is created on demand in `GlobalSetup` through `DynamoDbBenchmarkTableManager.EnsureTableExistsAsync`.
- The table is deleted automatically in `GlobalCleanup` for live benchmark base classes:
  - `Common/DynamoDBContext/LiveDynamoDbContextBenchmark.cs`
  - `Common/Table/LiveDynamoDbTableBenchmark.cs`
- `GlobalCleanup` calls `DynamoDbBenchmarkTableManager.DeleteTableAsync` to remove `BenchmarkTable` after the benchmark class run completes.

## Notes

- Real client benchmarks require valid AWS credentials and an accessible DynamoDB endpoint.
- Live benchmarks create `BenchmarkTable` if it does not exist and clean it up automatically in `GlobalCleanup`.
- Mocked client benchmarks use the in-process HTTP mock handler.
