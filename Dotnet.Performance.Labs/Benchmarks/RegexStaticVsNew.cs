using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using BenchmarkDotNet.Attributes;

namespace Dotnet.Performance.Labs.Benchmarks
{
    public class RegexStaticVsNew : DefaultBenchmarkBase
    {
        private static readonly string IgnoredPathsMatchPattern = $@"/(?:swagger|healthz)(?:/$|$|\s+|\W)";

        private List<string> _requestUrlPaths;

        public override void Setup()
        {
            _requestUrlPaths = new List<string>()
            {
                "https://google.com/swagger",
                "https://google.com/swagger/index",
                "https://google.com/healthz/index",
                "https://google.com/healthz/live",
                "https://google.com/healthz/ready"
            };


        }

        [Benchmark]
        public void StaticRegexStringMatch()
        {
            foreach (var url in _requestUrlPaths)
            {
                _ = Regex.IsMatch(url, IgnoredPathsMatchPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            }
        }

        [Benchmark]
        public void NewRegexStringMatch()
        {
            foreach (var url in _requestUrlPaths)
            {
                var regex = new Regex(IgnoredPathsMatchPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

                _ = regex.IsMatch(url);
            }
        }
    }
}