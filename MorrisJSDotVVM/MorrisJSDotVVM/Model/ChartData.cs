using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorrisJSDotVVM.Model
{
    public class ChartData
    {
        public float Temperature { get; set; }
        public DateTime Date { get; set; }
        public long DateFormatted => (long)(Date - new DateTime(1970, 1, 1)).TotalMilliseconds;
        public override string ToString()
        {
            return $"Temperature: {Temperature}";
        }
    }
}
