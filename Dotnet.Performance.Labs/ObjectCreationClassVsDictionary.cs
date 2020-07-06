using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace Dotnet.Performance.Labs
{
    public class ObjectCreationClassVsDictionary : DefaultBenchmarkBase
    {

        [Benchmark]
        public void CreateClassObject()
        {
            var x = new MyClass() { No = 1, OrderNumber = "1" };

        }

        [Benchmark]
        public void CreateDicObject()
        {
            var x = new Dictionary<string, MyClass>() { { "", new MyClass() { No = 1, OrderNumber = "1" } } };
        }
    }

    class MyClass
    {
        public int No { get; set; }

        public string OrderNumber { get; set; }
    }
}
