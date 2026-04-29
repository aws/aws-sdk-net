# Serde (Serialization/Deserialization) Performance Benchmarks

Benchmarks for measuring serialization and deserialization performance across AWS protocol types using standardized mock service models from the [AwsSdkPerformanceBenchmarkModels](https://code.amazon.com/packages/AwsSdkPerformanceBenchmarkModels) package.

## Protocols Tested

| Protocol | Service Client | Operations |
|----------|---------------|------------|
| REST JSON (restJson1) | RestJsonDataPlane | CopyObject, GetObject, PutObject, Healthcheck, GetMetricData, PutMetricData |
| AWS JSON 1.0 (awsJson1_0) | JsonRpc10DataPlane | Healthcheck, GetItem, PutItem, GetObject, PutObject, GetMetricData, PutMetricData |
| Smithy RPC V2 CBOR (rpcv2Cbor) | RpcCborDataPlane | GetItem, PutItem, GetObject, PutObject, GetMetricData, PutMetricData |
| REST XML (restXml) | RestXmlDataPlane | CopyObject, GetObject, PutObject, Healthcheck, GetMetricData, PutMetricData |
| AWS Query (awsQuery) | QueryDataPlane | Healthcheck, GetMetricData, PutMetricData |

## Test Case Variants

Each operation is tested with different payload sizes:
- **Baseline** — Minimal/empty request or response
- **S** (Small) — Small payload
- **M** (Medium) — Medium payload
- **L** (Large) — Large payload

## Measurement

- Each test case runs at least 1,000 iterations (up to 10,000 or 30 seconds)
- Warmup iterations are discarded (up to 50% of earliest data)
- Results reported in nanoseconds: mean, p50, p90, p95, p99, standard deviation
- Output in JSON format per the AwsSdkPerformanceBenchmarkModels specification

## Running

```bash
# From the repository root
dotnet run --configuration Release --project sdk/test/Performance/SerdeBenchmarks/SerdeBenchmarksRunner/SerdeBenchmarksRunner.csproj

# With instance type and output path
dotnet run --configuration Release --project sdk/test/Performance/SerdeBenchmarks/SerdeBenchmarksRunner/SerdeBenchmarksRunner.csproj -- --instance m7i.xlarge --output serde-results.json
```

## Output

Results are written to `serde-results.json` in the working directory, in the format specified by the AwsSdkPerformanceBenchmarkModels package README.
