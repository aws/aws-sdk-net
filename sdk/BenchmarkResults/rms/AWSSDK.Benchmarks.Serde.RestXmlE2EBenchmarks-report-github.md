```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.8655)
Unknown processor
.NET SDK 11.0.100-preview.2.26159.112
  [Host] : .NET 8.0.28 (8.0.2826.26413), X64 RyuJIT AVX2

Toolchain=InProcessEmitToolchain  

```
| Method                      | Mean           | Error       | StdDev      | Max            | P50            | P90            | P95            | Gen0    | Gen1   | Allocated |
|---------------------------- |---------------:|------------:|------------:|---------------:|---------------:|---------------:|---------------:|--------:|-------:|----------:|
| restXml_e2e_CopyObject      |    10,962.2 ns |    62.09 ns |    55.04 ns |    11,074.4 ns |    10,959.8 ns |    11,009.3 ns |    11,032.2 ns |  2.1515 | 1.0681 |  39.76 KB |
| restXml_e2e_PutObject_S     |    11,762.1 ns |    60.69 ns |    50.68 ns |    11,879.5 ns |    11,744.7 ns |    11,810.8 ns |    11,840.0 ns |  1.6022 | 0.7935 |  29.56 KB |
| restXml_e2e_PutObject_M     |   151,527.3 ns |   522.05 ns |   435.94 ns |   152,015.8 ns |   151,714.7 ns |   151,836.8 ns |   151,910.1 ns |  1.4648 | 0.7324 |  29.64 KB |
| restXml_e2e_PutObject_L     | 1,452,384.9 ns | 6,390.23 ns | 5,977.42 ns | 1,458,536.0 ns | 1,454,021.2 ns | 1,457,260.1 ns | 1,457,913.6 ns |       - |      - |  29.59 KB |
| restXml_e2e_GetObject_S     |     9,666.4 ns |    48.66 ns |    45.52 ns |     9,741.2 ns |     9,675.2 ns |     9,717.5 ns |     9,730.7 ns |  1.5564 | 0.7782 |  28.64 KB |
| restXml_e2e_GetObject_M     |    17,347.8 ns |   110.59 ns |   103.45 ns |    17,500.2 ns |    17,365.3 ns |    17,469.5 ns |    17,481.4 ns |  1.4954 | 0.7324 |  27.85 KB |
| restXml_e2e_GetObject_L     |    71,394.2 ns | 1,227.44 ns | 1,148.14 ns |    73,820.7 ns |    71,030.9 ns |    72,862.0 ns |    73,152.8 ns |  1.4648 | 0.6104 |  28.57 KB |
| restXml_e2e_PutMetricData_S |    10,813.7 ns |    54.58 ns |    48.38 ns |    10,912.7 ns |    10,820.7 ns |    10,863.1 ns |    10,882.6 ns |  2.2125 | 1.0986 |   40.8 KB |
| restXml_e2e_PutMetricData_M |    14,379.5 ns |    84.22 ns |    78.78 ns |    14,532.7 ns |    14,394.1 ns |    14,456.2 ns |    14,483.5 ns |  2.2430 | 1.1139 |  41.33 KB |
| restXml_e2e_GetMetricData_S |    17,792.4 ns |   168.47 ns |   157.59 ns |    18,124.3 ns |    17,752.9 ns |    18,017.6 ns |    18,094.1 ns |  4.0894 | 1.3428 |  75.28 KB |
| restXml_e2e_GetMetricData_M |    51,965.4 ns |   333.69 ns |   312.13 ns |    52,488.3 ns |    51,896.0 ns |    52,357.2 ns |    52,401.0 ns | 11.5356 | 2.2583 | 212.87 KB |
