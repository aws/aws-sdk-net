```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.8655)
Unknown processor
.NET SDK 11.0.100-preview.2.26159.112
  [Host] : .NET 8.0.28 (8.0.2826.26413), X64 RyuJIT AVX2

Toolchain=InProcessEmitToolchain  

```
| Method                    | Mean        | Error     | StdDev    | Max         | P50         | P90         | P95         | Gen0   | Gen1   | Allocated |
|-------------------------- |------------:|----------:|----------:|------------:|------------:|------------:|------------:|-------:|-------:|----------:|
| awsJson10_e2e_Healthcheck |  9,294.1 ns | 104.53 ns |  97.78 ns |  9,508.7 ns |  9,301.4 ns |  9,382.4 ns |  9,424.5 ns | 1.5564 | 0.7782 |   28.7 KB |
| awsJson10_e2e_PutItem_S   |  9,810.4 ns | 106.93 ns | 100.02 ns |  9,986.0 ns |  9,812.0 ns |  9,957.0 ns |  9,981.6 ns | 1.5564 | 0.7782 |  28.74 KB |
| awsJson10_e2e_PutItem_M   | 11,220.4 ns |  85.11 ns |  79.61 ns | 11,402.5 ns | 11,221.7 ns | 11,288.8 ns | 11,324.3 ns | 1.5564 | 0.7782 |  28.77 KB |
| awsJson10_e2e_PutItem_L   | 13,140.7 ns |  72.98 ns |  68.27 ns | 13,269.3 ns | 13,126.9 ns | 13,220.6 ns | 13,235.5 ns | 1.5564 | 0.7782 |  28.77 KB |
| awsJson10_e2e_GetItem_S   | 10,772.4 ns | 100.63 ns |  94.13 ns | 10,917.0 ns | 10,746.9 ns | 10,887.4 ns | 10,900.8 ns | 1.6479 | 0.8240 |  30.34 KB |
| awsJson10_e2e_GetItem_M   | 13,336.4 ns |  94.17 ns |  88.09 ns | 13,480.0 ns | 13,347.5 ns | 13,446.6 ns | 13,463.1 ns | 1.8921 | 0.9460 |  35.03 KB |
| awsJson10_e2e_GetItem_L   | 17,913.9 ns | 341.77 ns | 365.69 ns | 18,907.1 ns | 17,925.4 ns | 18,277.6 ns | 18,415.7 ns | 2.3499 | 1.1597 |  43.61 KB |
