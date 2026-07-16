```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.8655)
Unknown processor
.NET SDK 11.0.100-preview.2.26159.112
  [Host] : .NET 8.0.28 (8.0.2826.26413), X64 RyuJIT AVX2

Toolchain=InProcessEmitToolchain  

```
| Method                       | Mean        | Error     | StdDev    | Max         | P50         | P90         | P95         | Gen0    | Gen1   | Allocated |
|----------------------------- |------------:|----------:|----------:|------------:|------------:|------------:|------------:|--------:|-------:|----------:|
| awsQuery_e2e_Healthcheck     | 10,732.7 ns |  87.00 ns |  77.13 ns | 10,885.2 ns | 10,743.4 ns | 10,799.5 ns | 10,831.2 ns |  2.1057 | 1.0529 |  38.93 KB |
| awsQuery_e2e_PutMetricData_S | 12,112.7 ns |  81.26 ns |  76.01 ns | 12,193.9 ns | 12,151.2 ns | 12,179.6 ns | 12,184.5 ns |  2.2278 | 1.1139 |  40.93 KB |
| awsQuery_e2e_PutMetricData_M | 18,113.0 ns | 124.50 ns |  97.20 ns | 18,285.6 ns | 18,104.5 ns | 18,225.8 ns | 18,253.5 ns |  2.7771 | 0.9155 |  51.12 KB |
| awsQuery_e2e_GetMetricData_S | 19,284.4 ns | 131.37 ns | 122.89 ns | 19,471.8 ns | 19,278.3 ns | 19,451.9 ns | 19,468.2 ns |  3.4790 | 1.1597 |  64.11 KB |
| awsQuery_e2e_GetMetricData_M | 63,442.3 ns | 308.34 ns | 273.33 ns | 63,972.1 ns | 63,420.4 ns | 63,848.6 ns | 63,931.8 ns | 11.3525 | 2.4414 |  209.5 KB |
