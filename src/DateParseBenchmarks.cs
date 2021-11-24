using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkTests
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn()]
    public class DateParseBenchmarks
    {

        private const string DateTime = "2021-12-13";
        private static readonly DateParser Parser = new DateParser();

        [Benchmark(Baseline = true)]
        public void GetYearFromDateTime()
        {
            Parser.GetYearFromDate(DateTime);
        }

        [Benchmark]
        public void GetYearFromSplit()
        {
            Parser.GetYearFromSplit(DateTime);
        }

        [Benchmark]
        public void GetYearFromSubstring()
        {
            Parser.GetYearFromSubstring(DateTime);
        }

        [Benchmark]
        public void GetYearFromSpan()
        {
            Parser.GetYearFromSpan(DateTime);
        }

        [Benchmark]
        public void GetYearFromSpanWithManualConversion()
        {
            Parser.GetYearFromSpanWiThManualConversion(DateTime);
        }
    }
}
