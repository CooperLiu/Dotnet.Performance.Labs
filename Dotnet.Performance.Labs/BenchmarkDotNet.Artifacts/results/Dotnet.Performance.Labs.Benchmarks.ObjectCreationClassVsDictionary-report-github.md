``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.900 (1909/November2018Update/19H2)
Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.301
  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  Job-QPWRKY : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT

Runtime=.NET Core 3.1  

```
|            Method |       Mean |     Error |    StdDev |     Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------ |-----------:|----------:|----------:|-----------:|-------:|------:|------:|----------:|
| CreateClassObject |   5.732 ns | 0.1575 ns | 0.1473 ns |   5.766 ns | 0.0153 |     - |     - |      32 B |
|   CreateDicObject | 119.100 ns | 2.3580 ns | 4.9738 ns | 116.637 ns | 0.1147 |     - |     - |     240 B |
