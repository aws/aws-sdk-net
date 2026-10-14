# Serde (Serialization/Deserialization) Performance Benchmarks

Benchmarks for measuring serialization and deserialization performance across AWS protocol types using standardized mock service models from the AwsSdkPerformanceBenchmarkModels package.

## Test Suites

### `e2e` — Full Client Pipeline Benchmarks (default)

Tests the complete SDK client pipeline with a mocked HTTP handler:
- Credential resolution
- Request signing (SigV4)
- Request marshalling
- HTTP dispatch (mocked — no network I/O)
- Response unmarshalling
- Response object construction

This measures the true end-to-end cost of an SDK call without network latency. BenchmarkDotNet auto-determines warmup count, iteration count, and invocation count for statistically stable results.

### `serde` — Isolated Marshal/Unmarshal Benchmarks

Tests only the marshaller and unmarshaller components in isolation. Faster runtime (~12-18 min) using a constrained BDN configuration (5 warmup iterations, 5-20 measurement iterations).

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

## Running

```bash
# Run E2E benchmarks (default)
dotnet run -c Release --project sdk/test/Performance/SerdeBenchmarks/SerdeBenchmarksRunner/SerdeBenchmarksRunner.csproj -- --filter '*'

# Run E2E benchmarks (explicit)
dotnet run -c Release --project sdk/test/Performance/SerdeBenchmarks/SerdeBenchmarksRunner/SerdeBenchmarksRunner.csproj -- --suite e2e --filter '*'

# Run serde-only (marshal/unmarshal) benchmarks
dotnet run -c Release --project sdk/test/Performance/SerdeBenchmarks/SerdeBenchmarksRunner/SerdeBenchmarksRunner.csproj -- --suite serde --filter '*'

# Filter to a specific protocol
dotnet run -c Release --project sdk/test/Performance/SerdeBenchmarks/SerdeBenchmarksRunner/SerdeBenchmarksRunner.csproj -- --filter '*RestJson1*'

# Filter to a specific protocol (serde only)
dotnet run -c Release --project sdk/test/Performance/SerdeBenchmarks/SerdeBenchmarksRunner/SerdeBenchmarksRunner.csproj -- --suite serde --filter '*AwsQuery*'
```

## Regenerating the benchmark payloads

All three suites take their payloads from the `serde-benchmark` tagged `@httpRequestTests` / `@httpResponseTests` in the AwsSdkPerformanceBenchmarkModels models. Two files are generated from them; don't edit either by hand:

- `SerdeBenchmarksRunner/ModelFixtures.cs`: a request factory or response body (plus headers) for every model case, used by the `serde` and `e2e` suites. The `e2e` suite's CloudWatch cases on restJson1/restXml use the models' awsQuery params, re-targeted or re-encoded, because the models define CloudWatch only for awsQuery.
- `SerdeBenchmarksRunner/CpuTimeBenchmarks.cs`: the `--cpu-time` cases.

To regenerate them after the models change, run this (Python 3.8+, no extra packages):

```bash
cd sdk/test/Performance/SerdeBenchmarks
python generate_serde_benchmarks.py --model <path-to-AwsSdkPerformanceBenchmarkModels>/model
```

The script is not part of the build.

## Measurement

### E2E suite (default)
- BenchmarkDotNet Throughput mode with **auto-pilot** — BDN determines warmup count, iteration count, and invocation count automatically for statistically stable results
- Results reported in nanoseconds: mean, p50, p90, p95, max
- Memory allocation tracked via `[MemoryDiagnoser]`

### Serde suite
- BenchmarkDotNet Throughput mode with **constrained configuration**: 5 warmup iterations, 5-20 measurement iterations
- BDN automatically determines invocation counts for accurate measurement of fast micro-benchmarks (µs-scale serde operations)
- Results reported in nanoseconds: mean, p50, p90, p95, max
- Memory allocation tracked via `[MemoryDiagnoser]`

## Output

Results are written to `BenchmarkDotNet.Artifacts/results/` in CSV, GitHub Markdown, and HTML formats.

## CI/CD Integration

For CI/CD, the `--suite` argument is used by the `test.sh`/`test.ps1` scripts:
- **RELEASE / DRY_RUN builds** → `--suite e2e` (full pipeline regression detection)
