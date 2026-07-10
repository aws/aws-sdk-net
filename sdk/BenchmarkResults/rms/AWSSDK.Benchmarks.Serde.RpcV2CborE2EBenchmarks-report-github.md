```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.8655)
Unknown processor
.NET SDK 11.0.100-preview.2.26159.112
  [Host] : .NET 8.0.28 (8.0.2826.26413), X64 RyuJIT AVX2

Toolchain=InProcessEmitToolchain  

```
| Method                  | Mean        | Error     | StdDev    | Max         | P50         | P90         | P95         | Gen0   | Gen1   | Allocated |
|------------------------ |------------:|----------:|----------:|------------:|------------:|------------:|------------:|-------:|-------:|----------:|
| rpcV2Cbor_e2e_PutItem_S | 10,673.8 ns |  53.91 ns |  50.43 ns | 10,737.5 ns | 10,684.6 ns | 10,733.8 ns | 10,735.1 ns | 1.7242 | 0.8545 |  31.74 KB |
| rpcV2Cbor_e2e_PutItem_M | 11,950.1 ns |  82.59 ns |  77.25 ns | 12,138.4 ns | 11,915.0 ns | 12,037.6 ns | 12,070.1 ns | 1.7242 | 0.8545 |  31.77 KB |
| rpcV2Cbor_e2e_PutItem_L | 14,953.8 ns |  60.17 ns |  53.34 ns | 15,042.4 ns | 14,957.3 ns | 15,016.4 ns | 15,031.3 ns | 1.7242 | 0.8545 |  31.77 KB |
| rpcV2Cbor_e2e_GetItem_S | 12,243.8 ns | 131.44 ns | 116.52 ns | 12,444.9 ns | 12,231.5 ns | 12,418.8 ns | 12,441.6 ns | 2.0905 | 1.0376 |  38.45 KB |
| rpcV2Cbor_e2e_GetItem_M | 16,234.1 ns | 130.34 ns | 115.54 ns | 16,442.5 ns | 16,247.7 ns | 16,332.9 ns | 16,375.5 ns | 3.0212 | 1.0071 |  56.02 KB |
| rpcV2Cbor_e2e_GetItem_L | 23,716.3 ns | 136.83 ns | 127.99 ns | 23,983.3 ns | 23,737.7 ns | 23,831.0 ns | 23,877.3 ns | 4.8828 | 1.6174 |  89.82 KB |
