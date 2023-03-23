using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{
    public class showcomp
    {

        Validation vala = new Validation();
        public void showcompanyby_id(List<employee> list)
        {

            Console.WriteLine("enter the emp_id index");
           /* var index = int.Parse(Console.ReadLine());*/
            var index = vala.checkid();
            var updateObj = list.FirstOrDefault(x => x.userid == index);
            Console.WriteLine(updateObj.company_name);

            return;
        }
    }
}
