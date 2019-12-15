using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;
using MorrisJSDotVVM.Model;

namespace MorrisJSDotVVM.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
		public string Title { get; set;}

        public List<ChartData> Data { get; private set; }

        public DefaultViewModel()
		{
			Title = "Hello from DotVVM!";

            //var now = DateTime.Now;
            //DateTime dt;

            //Data = new List<ChartData>();

            //dt = now.AddHours(0);
            //Data.Add(new ChartData { Temperature = 10, Date = dt });

            //dt = now.AddHours(1);
            //Data.Add(new ChartData { Temperature = 20, Date = dt });

            //dt = now.AddHours(2);
            //Data.Add(new ChartData { Temperature = 30, Date = dt });

            //dt = now.AddHours(3);
            //Data.Add(new ChartData { Temperature = 40, Date = dt });
        }

        public int Count
        {
            get;
            set;
        }
        public void Counter()
        {
            Count++;
        }
    }
}
