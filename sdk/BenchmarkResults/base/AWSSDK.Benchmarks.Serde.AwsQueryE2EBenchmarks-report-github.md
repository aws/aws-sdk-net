```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.8655)
Unknown processor
.NET SDK 11.0.100-preview.2.26159.112
  [Host] : .NET 8.0.28 (8.0.2826.26413), X64 RyuJIT AVX2

Toolchain=InProcessEmitToolchain  

```
| Method                       | Mean        | Error    | StdDev   | Max         | P50         | P90         | P95         | Gen0    | Gen1   | Allocated |
|----------------------------- |------------:|---------:|---------:|------------:|------------:|------------:|------------:|--------:|-------:|----------:|
| awsQuery_e2e_Healthcheck     | 10,565.2 ns | 172.8 ns | 161.7 ns | 10,876.2 ns | 10,586.6 ns | 10,767.4 ns | 10,823.8 ns |  2.1057 | 1.0529 |  38.97 KB |
| awsQuery_e2e_PutMetricData_S | 11,767.4 ns | 157.6 ns | 147.4 ns | 12,028.9 ns | 11,782.0 ns | 11,905.5 ns | 11,946.1 ns |  2.2278 | 1.1139 |  40.96 KB |
| awsQuery_e2e_PutMetricData_M | 17,565.8 ns | 177.1 ns | 147.9 ns | 17,934.8 ns | 17,554.1 ns | 17,707.2 ns | 17,807.2 ns |  2.7771 | 1.0376 |  51.15 KB |
| awsQuery_e2e_GetMetricData_S | 19,214.2 ns | 258.5 ns | 241.8 ns | 19,732.4 ns | 19,268.6 ns | 19,454.2 ns | 19,561.1 ns |  3.4790 | 1.1597 |  64.13 KB |
| awsQuery_e2e_GetMetricData_M | 63,277.7 ns | 636.8 ns | 564.5 ns | 64,478.0 ns | 63,209.9 ns | 63,827.4 ns | 64,093.2 ns | 11.3525 | 2.4414 | 209.54 KB |
