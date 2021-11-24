using System;

namespace BenchmarkTests
{
    public class DateParser
    {
        public int GetYearFromDate(string dateTimeAsString)
        {
            var dateTime = DateTime.Parse(dateTimeAsString);
            return dateTime.Year;
        }

        public int GetYearFromSplit(string dateTimeAsString)
        {
            var splitOnHyphen = dateTimeAsString.Split('-');

            return int.Parse(splitOnHyphen[0]);
        }

        public int GetYearFromSubstring(string dateTimeAsString)
        {
            var indexOnHyphen = dateTimeAsString.IndexOf('-');
            return int.Parse(dateTimeAsString.Substring(0, indexOnHyphen));
        }

        public int GetYearFromSpan(ReadOnlySpan<char> dateTimeAsSpan)
        {
            var indexOnHyphen = dateTimeAsSpan.IndexOf('-');

            return int.Parse(dateTimeAsSpan.Slice(0, indexOnHyphen));

        }

        public int GetYearFromSpanWiThManualConversion(ReadOnlySpan<char> dateTimeAsSpan)
        {
            var indexOnHyphen = dateTimeAsSpan.IndexOf('-');
            var yearAsSpan = dateTimeAsSpan.Slice(0, indexOnHyphen);

            var temp = 0;

            for (int i = 0; i < yearAsSpan.Length; i++)
            {
                temp = temp * 10 + (yearAsSpan[i] - '0');
            }
          
            return temp;
        }

    }
}
