```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.8655)
Unknown processor
.NET SDK 11.0.100-preview.2.26159.112
  [Host] : .NET 8.0.28 (8.0.2826.26413), X64 RyuJIT AVX2

Toolchain=InProcessEmitToolchain  

```
| Method                  | Mean        | Error     | StdDev    | Max         | P50         | P90         | P95         | Gen0   | Gen1   | Allocated |
|------------------------ |------------:|----------:|----------:|------------:|------------:|------------:|------------:|-------:|-------:|----------:|
| rpcV2Cbor_e2e_PutItem_S | 10,729.7 ns | 146.10 ns | 136.66 ns | 10,942.3 ns | 10,697.9 ns | 10,925.4 ns | 10,931.0 ns | 1.7242 | 0.8545 |  31.74 KB |
| rpcV2Cbor_e2e_PutItem_M | 11,905.0 ns |  70.40 ns |  58.79 ns | 11,997.0 ns | 11,914.9 ns | 11,975.1 ns | 11,986.4 ns | 1.7242 | 0.8545 |  31.77 KB |
| rpcV2Cbor_e2e_PutItem_L | 14,789.7 ns |  66.45 ns |  58.90 ns | 14,888.7 ns | 14,793.9 ns | 14,852.2 ns | 14,867.8 ns | 1.7242 | 0.8545 |  31.77 KB |
| rpcV2Cbor_e2e_GetItem_S | 12,080.9 ns |  83.73 ns |  74.23 ns | 12,229.7 ns | 12,083.6 ns | 12,164.0 ns | 12,195.5 ns | 2.0905 | 1.0376 |  38.45 KB |
| rpcV2Cbor_e2e_GetItem_M | 16,203.5 ns | 173.14 ns | 153.48 ns | 16,457.7 ns | 16,173.9 ns | 16,428.2 ns | 16,442.2 ns | 3.0212 | 1.0071 |  56.02 KB |
| rpcV2Cbor_e2e_GetItem_L | 23,559.1 ns | 193.92 ns | 181.39 ns | 23,922.3 ns | 23,522.5 ns | 23,761.2 ns | 23,821.4 ns | 4.8828 | 1.6174 |  89.82 KB |
