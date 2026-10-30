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

# ops/CPU-sec: all 71 --cpu-time cases with the in-process stub (the default transport)
dotnet run -c Release --project sdk/test/Performance/SerdeBenchmarks/SerdeBenchmarksRunner/SerdeBenchmarksRunner.csproj -- --cpu-time

# ops/CPU-sec through the real HTTP client to a loopback fixture server (see below)
dotnet run -c Release --project sdk/test/Performance/SerdeBenchmarks/SerdeBenchmarksRunner/SerdeBenchmarksRunner.csproj -- --cpu-time --transport https
```

`--cpu-time` options:

| Option | Default | Meaning |
|---|---|---|
| `--warmup N` | 100000 | Warmup iterations per case, not measured |
| `--min-iterations N`, `--min-cpu-seconds S` | 50000, 5 | Stop measuring a case after N iterations or S seconds of process CPU, whichever comes first |
| `--transport stub\|https` | `stub` | `stub`: the in-process `MockHttpHandler`. `https`: see [HTTPS loopback mode](#https-loopback-mode) |
| `--https-server IP:PORT` | `127.0.0.1:18443` | The fixture server's HTTPS address (https only; loopback addresses only) |
| `--fixture-control IP:PORT` | `127.0.0.1:18080` | The fixture server's control address (https only; loopback addresses only) |
| `--case-filter REGEX` | (all) | Run only the cases whose name matches |
| `--threads N` | 1 | Concurrent workers per case on the shared client. See [Concurrency regression check](#concurrency-regression-check---threads-n). Not the cross-SDK metric when N > 1 |
| `--breakdown` | off | Per-stage pipeline timing. See [Pipeline breakdown](#pipeline-breakdown---breakdown). Requires `--threads 1` and `--transport stub` |
| `--breakdown-csv PATH` | — | Append the breakdown rows to a CSV file |

An invalid or missing value, an option used without the one it depends on, or a `--case-filter` that matches no case exits with code 2. The run banner prints the transport used.

Don't pin the process to one core (`taskset -c N`): the runtime's JIT and GC threads then share it, and early cases run up to 2x slow.

## HTTPS loopback mode

`--cpu-time --transport https` sends every call through a real `SocketsHttpHandler` (HTTP/1.1 over TLS, keep-alive) to a fixture server running as a separate process on the same host, so the server's CPU is not part of the measurement. The server must:

- serve HTTPS (HTTP/1.1, keep-alive) on `--https-server` and answer every request with the current fixture;
- accept `POST /fixture` on the plaintext `--fixture-control` address, where the body is a complete HTTP/1.1 response (status line, headers, a `Content-Length` that matches the body, the body), and answer `204`.

The smithy-java e2e benchmark `FixtureServer` ([smithy-lang/smithy-java](https://github.com/smithy-lang/smithy-java), `benchmarks/e2e-benchmarks`) implements this. For example, with its jar built from that module (it needs Java 21 or later; its TLS library is bundled for Linux):

```bash
java -cp smithy-java-e2e-benchmark.jar software.amazon.smithy.java.benchmarks.fixture.FixtureServer \
  --listen 127.0.0.1:18443 --control 127.0.0.1:18080 &
dotnet run -c Release --project sdk/test/Performance/SerdeBenchmarks/SerdeBenchmarksRunner/SerdeBenchmarksRunner.csproj -- --cpu-time --transport https
```

- **Fixtures:** before each case, the harness posts that case's canned response: the stub's status, body and headers, plus `Content-Type`, `Content-Length` and `x-amzn-RequestId`.
- **Redirect:** only the socket is redirected, via `SocketsHttpHandler.ConnectCallback`. Endpoint resolution, the URL, the `Host` header, TLS SNI and SigV4 signing stay those of the real endpoint.
- **Client settings:** the `SocketsHttpHandler` and `HttpClient` are configured from the service client's config the same way the SDK configures its own default client. The only differences are the `ConnectCallback` and the certificate check below.
- **Certificate:** not verified, since the server's certificate is expected to be self-signed.
- **Fail fast:** the run stops right away if either address doesn't accept connections, or if the control address doesn't answer `204`.
- **CPU/wall ratio:** above 1 in this mode, because socket I/O completes on other threads.
- **Platform:** use Linux. On other systems the loopback cost is larger and noisier.

## Concurrency regression check (`--threads N`)

`--threads N` with N > 1 checks that SDK state shared between calls (signing-key cache, HMAC pool, User-Agent and `Uri` caches, thread-static buffers) holds up under concurrency. **It is a regression check, not the cross-SDK metric:** compare N > 1 runs only with runs at the same N on the same machine.

```bash
dotnet run -c Release --project sdk/test/Performance/SerdeBenchmarks/SerdeBenchmarksRunner/SerdeBenchmarksRunner.csproj -- --cpu-time --threads 4
```

`--threads 1` (the default) runs the single-threaded loop unchanged. With N > 1:

- N `Task.Run` workers share the case's client and request. The thread-pool minimum is raised to N + 1 so they all start at once.
- Warmup is `--warmup` iterations in total across the workers, then a forced GC.
- The run stops at `--min-iterations` × N total ops or `--min-cpu-seconds` × N process CPU, checked by each worker every 100 of its iterations. Every completed op is counted.
- Ops/CPU-s is total ops / process CPU seconds; Ops/Wall-s is aggregate throughput. CPU/Wall should be about N; well below N means workers were blocked or starved.
- The 12 cases whose request holds a `MemoryStream` (`*_PutItemRequest_BinaryData_*`, `*_PutObject_*`) are skipped, since concurrent calls would race on the stream position. The geomean then covers 59 cases.

Keep N at or below the number of idle cores; beyond that the result measures time-slicing as much as contention.

## Pipeline breakdown (`--breakdown`)

`--breakdown` inserts a probe handler above the pipeline and below every handler, using `RuntimePipelineCustomizerRegistry`. For each case it reports every handler's time and allocated bytes in each direction, with the mocked transport separately. Each probe adds about 0.03 µs on x86 and 0.04 µs on ARM (the smallest stage's reading on metal), so trivial handlers read slightly high. Use the breakdown to see where time goes, not as an ops/CPU-sec number. It needs the default `--transport stub`, because the in-process `MockHttpHandler` stamps the transport stage; with `--transport https` the run exits with code 2.

## Sampling profile (Linux, `profiling/profile.sh`)

To see where time goes inside a stage, or CPU on other threads such as the GC, profile one case with `perf`:

```bash
cd sdk/test/Performance/SerdeBenchmarks
BIN=$(mktemp -d)
dotnet build SerdeBenchmarksRunner/SerdeBenchmarksRunner.csproj -c Release -o "$BIN"
FLAMEGRAPH_DIR=<clone of https://github.com/brendangregg/FlameGraph> \
    profiling/profile.sh "$BIN" awsJson1_0_GetItemOutput_S
```

This recipe has been tested on awsJson cases. rpcv2Cbor cases currently fail to load `System.Formats.Cbor` from a runner built this way.

The script runs the case under `perf record -g` with the default warmup until 30 seconds of CPU, and keeps only samples from 0.5 seconds after tiered compilation finishes (in the first 5 seconds, about half the samples are JIT and unoptimized code). It writes to `./profile-<case>/`:

- `<case>.summary.txt`: thread shares, where the CPU was (managed code, GC, OpenSSL, ...), the pipeline stage of each benchmark-thread sample, and the hottest methods inside each stage.
- `<case>.folded` (all threads) and `<case>.main.folded` (benchmark thread): collapsed stacks. Open them in [speedscope](https://www.speedscope.app), or with `FLAMEGRAPH_DIR` set the script also renders `<case>.svg` and `<case>.main.svg`.

The run sets `DOTNET_PerfMapEnabled=1` so `perf` can name JIT-compiled methods, and `DOTNET_EnableWriteXorExecute=0`, without which .NET 8 and later keep JIT code in a mapping `perf` cannot resolve. Both change the runtime: read the profile as shares, and never report the runner's numbers from a profiled run.

`perf` needs `kernel.perf_event_paranoid` at 2 or lower to profile your own processes. Two gaps in attribution:

- Without runtime symbols, GC and allocation samples show as raw `libcoreclr.so` addresses. To fix that, put the symbols in `perf`'s build-id cache:

  ```bash
  dotnet tool install -g dotnet-symbol
  CLR=$DOTNET_ROOT/shared/Microsoft.NETCore.App/<version>/libcoreclr.so
  SYM=$(mktemp -d)
  dotnet-symbol --symbols -o "$SYM" $CLR
  BID=$(readelf -n $CLR | awk '/Build ID/{print $3}')
  mkdir -p ~/.debug/.build-id/${BID:0:2}/${BID:2}
  cp "$SYM/libcoreclr.so.dbg" ~/.debug/.build-id/${BID:0:2}/${BID:2}/debug
  ```

- `libcrypto` has no frame pointers, so its samples lose their managed caller ("native, caller lost" in the summary). With SigV4 they are almost all signing.

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
