using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;

namespace DotvvmApplication1.ViewModels
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


    public class DefaultViewModel : MasterPageViewModel
    {
		public string Title { get; set;}

        public List<ChartData> Data { get; private set; }

        public DefaultViewModel()
		{
			Title = "Hello from DotVVM!";
		}

        public override Task PreRender()
        {
            var now = DateTime.Now;
            DateTime dt;

            Data = new List<ChartData>();

            dt = now.AddHours(0);
            Data.Add(new ChartData { Temperature = 10, Date = dt });

            dt = now.AddHours(1);
            Data.Add(new ChartData { Temperature = 20, Date = dt });

            dt = now.AddHours(2);
            Data.Add(new ChartData { Temperature = 30, Date = dt });

            dt = now.AddHours(3);
            Data.Add(new ChartData { Temperature = 40, Date = dt });

            return base.PreRender();
        }
    }
}
