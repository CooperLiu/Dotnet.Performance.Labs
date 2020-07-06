using System;
using BenchmarkDotNet.Running;

namespace Dotnet.Performance.Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            var summary = BenchmarkRunner.Run<ObjectCreationClassVsDictionary>();
        }
    }
}
