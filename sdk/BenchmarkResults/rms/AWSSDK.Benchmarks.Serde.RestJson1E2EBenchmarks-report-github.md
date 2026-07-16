```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.8655)
Unknown processor
.NET SDK 11.0.100-preview.2.26159.112
  [Host] : .NET 8.0.28 (8.0.2826.26413), X64 RyuJIT AVX2

Toolchain=InProcessEmitToolchain  

```
| Method                            | Mean         | Error     | StdDev    | Max          | P50          | P90          | P95          | Gen0   | Gen1   | Allocated |
|---------------------------------- |-------------:|----------:|----------:|-------------:|-------------:|-------------:|-------------:|-------:|-------:|----------:|
| restJson1_e2e_CopyObject_Baseline |   9,829.7 ns |  40.39 ns |  33.73 ns |   9,873.6 ns |   9,840.9 ns |   9,861.0 ns |   9,866.2 ns | 1.5869 | 0.7935 |  30.28 KB |
| restJson1_e2e_CopyObject_M        |  12,159.3 ns | 100.18 ns |  93.71 ns |  12,381.0 ns |  12,128.0 ns |  12,254.2 ns |  12,294.6 ns | 2.0294 | 1.0071 |  37.42 KB |
| restJson1_e2e_PutObject_S         |   9,774.5 ns |  62.97 ns |  49.16 ns |   9,834.9 ns |   9,780.8 ns |   9,827.6 ns |   9,831.1 ns | 1.3885 | 0.6866 |  25.68 KB |
| restJson1_e2e_PutObject_M         |  32,577.5 ns | 114.35 ns | 106.96 ns |  32,807.9 ns |  32,579.1 ns |  32,701.5 ns |  32,741.4 ns | 1.3428 | 0.6714 |  25.77 KB |
| restJson1_e2e_PutObject_L         | 244,501.0 ns | 236.82 ns | 209.94 ns | 244,817.8 ns | 244,531.9 ns | 244,693.1 ns | 244,743.1 ns | 0.9766 | 0.4883 |  25.71 KB |
| restJson1_e2e_GetObject_S         |   9,660.0 ns |  50.50 ns |  47.24 ns |   9,757.0 ns |   9,633.7 ns |   9,710.4 ns |   9,725.2 ns | 1.4343 | 0.7172 |  26.51 KB |
| restJson1_e2e_GetObject_M         |  17,579.7 ns | 186.54 ns | 174.49 ns |  17,983.4 ns |  17,574.7 ns |  17,764.3 ns |  17,835.7 ns | 1.3733 | 0.6714 |  25.71 KB |
| restJson1_e2e_GetObject_L         |  71,094.4 ns | 588.29 ns | 491.25 ns |  72,306.2 ns |  71,003.9 ns |  71,591.9 ns |  71,898.9 ns | 1.3428 | 0.6104 |  26.43 KB |
| restJson1_e2e_PutMetricData_S     |   9,838.0 ns |  78.50 ns |  73.43 ns |   9,973.9 ns |   9,855.6 ns |   9,904.8 ns |   9,930.1 ns | 1.3275 | 0.6561 |  24.45 KB |
| restJson1_e2e_PutMetricData_M     |  14,754.7 ns | 158.50 ns | 148.26 ns |  14,959.4 ns |  14,656.4 ns |  14,947.0 ns |  14,952.5 ns | 1.3275 | 0.6561 |  24.48 KB |
| restJson1_e2e_PutMetricData_L     |  63,141.1 ns |  76.95 ns |  60.08 ns |  63,270.1 ns |  63,144.5 ns |  63,197.8 ns |  63,232.0 ns | 1.2207 | 0.6104 |  24.48 KB |
| restJson1_e2e_GetMetricData_S     |  11,001.1 ns |  40.58 ns |  35.97 ns |  11,041.4 ns |  11,016.9 ns |  11,037.2 ns |  11,041.2 ns | 1.6174 | 0.8087 |  29.88 KB |
| restJson1_e2e_GetMetricData_M     |  17,143.8 ns |  88.66 ns |  78.60 ns |  17,278.9 ns |  17,130.2 ns |  17,244.9 ns |  17,267.4 ns | 1.9531 | 0.9766 |  36.44 KB |
| restJson1_e2e_GetMetricData_L     |  71,731.0 ns | 179.42 ns | 159.05 ns |  72,071.6 ns |  71,711.3 ns |  71,904.8 ns |  71,979.1 ns | 5.2490 | 1.7090 |   97.5 KB |
