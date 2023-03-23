using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{
    public class showemployee
    {


        public void showemp(List<employee> list)
        {
            Console.WriteLine("show employee by company");
            var company_name = Console.ReadLine();
            var updateObj = list.FirstOrDefault(x => x.company_name == company_name);
            Console.WriteLine( updateObj.name);
         
            return;
        }

    }
}
