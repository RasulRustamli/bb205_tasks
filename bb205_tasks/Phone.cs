using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb205_tasks
{
    internal class Phone
    {
        public int Id { get; set; }
      

        public string Name { get; set; }
        public string BrandName { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"id:{Id},name:{Name}, BrandName:{BrandName},Price:{Price}");
        }



    }
}
