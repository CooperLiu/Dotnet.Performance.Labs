using BenchmarkDotNet.Attributes;
using Dotnet.Performance.Labs.Configs;

namespace Dotnet.Performance.Labs
{
    [Config(typeof(DefaultConfig))]
    public abstract class DefaultBenchmarkBase
    {
        [GlobalSetup]
        public virtual void Setup()
        {
        }
    }
}
