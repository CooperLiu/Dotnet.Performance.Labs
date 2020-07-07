using System;
using BenchmarkDotNet.Running;

namespace Dotnet.Performance.Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
