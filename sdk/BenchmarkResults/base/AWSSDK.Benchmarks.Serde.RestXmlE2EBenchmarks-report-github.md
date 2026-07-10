```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.8655)
Unknown processor
.NET SDK 11.0.100-preview.2.26159.112
  [Host] : .NET 8.0.28 (8.0.2826.26413), X64 RyuJIT AVX2

Toolchain=InProcessEmitToolchain  

```
| Method                      | Mean           | Error      | StdDev     | Max            | P50            | P90            | P95            | Gen0    | Gen1    | Gen2    | Allocated  |
|---------------------------- |---------------:|-----------:|-----------:|---------------:|---------------:|---------------:|---------------:|--------:|--------:|--------:|-----------:|
| restXml_e2e_CopyObject      |    10,961.9 ns |   196.6 ns |   174.3 ns |    11,277.9 ns |    10,906.1 ns |    11,191.6 ns |    11,225.6 ns |  2.1515 |  1.0681 |       - |   39.76 KB |
| restXml_e2e_PutObject_S     |    11,963.0 ns |   212.2 ns |   198.5 ns |    12,362.3 ns |    11,946.6 ns |    12,245.7 ns |    12,287.0 ns |  1.6022 |  0.7935 |       - |   29.56 KB |
| restXml_e2e_PutObject_M     |   151,593.4 ns |   706.3 ns |   660.7 ns |   152,772.8 ns |   151,544.2 ns |   152,502.2 ns |   152,743.6 ns |  1.4648 |  0.7324 |       - |   29.64 KB |
| restXml_e2e_PutObject_L     | 1,446,318.1 ns | 6,763.9 ns | 5,648.2 ns | 1,451,459.0 ns | 1,447,143.8 ns | 1,450,896.1 ns | 1,451,171.6 ns |       - |       - |       - |   29.59 KB |
| restXml_e2e_GetObject_S     |     9,827.4 ns |   135.4 ns |   126.7 ns |    10,032.6 ns |     9,826.2 ns |     9,992.3 ns |    10,027.2 ns |  1.5564 |  0.7782 |       - |   28.64 KB |
| restXml_e2e_GetObject_M     |    53,785.9 ns | 1,568.6 ns | 4,625.2 ns |    64,717.9 ns |    53,777.1 ns |    59,673.9 ns |    62,170.4 ns | 19.2871 | 17.8223 | 17.7612 |  127.85 KB |
| restXml_e2e_GetObject_L     |   140,891.4 ns | 2,800.7 ns | 4,679.4 ns |   150,214.5 ns |   140,062.3 ns |   146,472.1 ns |   149,150.9 ns | 98.6328 | 97.1680 | 97.1680 | 1052.75 KB |
| restXml_e2e_PutMetricData_S |    10,786.0 ns |   199.1 ns |   186.2 ns |    11,235.1 ns |    10,726.6 ns |    11,006.6 ns |    11,090.8 ns |  2.2125 |  1.0986 |       - |    40.8 KB |
| restXml_e2e_PutMetricData_M |    14,401.0 ns |   152.4 ns |   142.5 ns |    14,703.4 ns |    14,421.0 ns |    14,550.3 ns |    14,614.5 ns |  2.2430 |  1.1139 |       - |   41.33 KB |
| restXml_e2e_GetMetricData_S |    17,999.8 ns |   327.9 ns |   306.7 ns |    18,722.5 ns |    17,896.0 ns |    18,427.6 ns |    18,596.7 ns |  4.0894 |  1.3428 |       - |   75.28 KB |
| restXml_e2e_GetMetricData_M |    51,753.0 ns |   428.6 ns |   357.9 ns |    52,288.4 ns |    51,699.3 ns |    52,239.8 ns |    52,284.6 ns | 11.5356 |  2.2583 |       - |  212.87 KB |
