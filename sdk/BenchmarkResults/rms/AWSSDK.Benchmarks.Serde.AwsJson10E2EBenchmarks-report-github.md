```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.8655)
Unknown processor
.NET SDK 11.0.100-preview.2.26159.112
  [Host] : .NET 8.0.28 (8.0.2826.26413), X64 RyuJIT AVX2

Toolchain=InProcessEmitToolchain  

```
| Method                    | Mean        | Error     | StdDev   | Max         | P50         | P90         | P95         | Gen0   | Gen1   | Allocated |
|-------------------------- |------------:|----------:|---------:|------------:|------------:|------------:|------------:|-------:|-------:|----------:|
| awsJson10_e2e_Healthcheck |  9,198.4 ns |  57.42 ns | 53.71 ns |  9,291.0 ns |  9,190.1 ns |  9,255.9 ns |  9,270.1 ns | 1.5564 | 0.7782 |   28.7 KB |
| awsJson10_e2e_PutItem_S   |  9,813.8 ns |  39.67 ns | 35.17 ns |  9,866.8 ns |  9,818.8 ns |  9,852.8 ns |  9,862.9 ns | 1.5564 | 0.7782 |  28.74 KB |
| awsJson10_e2e_PutItem_M   | 10,820.1 ns |  51.46 ns | 48.14 ns | 10,932.8 ns | 10,818.9 ns | 10,868.0 ns | 10,888.8 ns | 1.5564 | 0.7782 |  28.77 KB |
| awsJson10_e2e_PutItem_L   | 12,688.7 ns |  66.73 ns | 55.72 ns | 12,812.0 ns | 12,685.0 ns | 12,731.1 ns | 12,764.5 ns | 1.5564 | 0.7782 |  28.77 KB |
| awsJson10_e2e_GetItem_S   | 10,684.2 ns | 103.92 ns | 97.20 ns | 10,810.9 ns | 10,668.3 ns | 10,809.2 ns | 10,810.3 ns | 1.6479 | 0.8240 |  30.34 KB |
| awsJson10_e2e_GetItem_M   | 13,087.8 ns |  59.77 ns | 52.98 ns | 13,204.7 ns | 13,084.6 ns | 13,147.3 ns | 13,170.2 ns | 1.8921 | 0.9460 |  35.03 KB |
| awsJson10_e2e_GetItem_L   | 17,032.9 ns |  75.01 ns | 70.17 ns | 17,141.7 ns | 17,050.4 ns | 17,123.0 ns | 17,130.6 ns | 2.3499 | 1.1597 |  43.61 KB |
