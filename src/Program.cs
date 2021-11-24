using BenchmarkDotNet.Running;
using System;

namespace BenchmarkTests
{
    class Program
    {
        static void Main(string[] args)
        {
              BenchmarkRunner.Run<DateParseBenchmarks>();

        }
    }
}
