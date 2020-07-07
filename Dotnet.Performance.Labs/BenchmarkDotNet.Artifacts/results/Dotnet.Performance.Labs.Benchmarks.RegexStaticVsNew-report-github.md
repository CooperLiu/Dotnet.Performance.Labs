``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.900 (1909/November2018Update/19H2)
Intel Core i7-7500U CPU 2.70GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.301
  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  Job-BXUKNP : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT

Runtime=.NET Core 3.1  

```
|                 Method |         Mean |      Error |     StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------- |-------------:|-----------:|-----------:|--------:|-------:|------:|----------:|
| StaticRegexStringMatch |     2.763 μs |  0.0495 μs |  0.0463 μs |  0.2480 |      - |     - |     520 B |
|    NewRegexStringMatch | 3,242.451 μs | 49.5259 μs | 43.9034 μs | 11.7188 | 3.9063 |     - |   25914 B |
