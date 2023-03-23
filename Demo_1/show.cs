using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{
    public  class show
    {

        public void show_details (List<employee> list) {

            Console.WriteLine("Show Table");
            Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", "ID", "Name", "DEPT.", "TECHNOLOGY", "COMPANY_NAME");
            foreach (var item in list)
            {
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", item.userid, item.name, item.department, item.technology, item.company_name);
            }
          return;
        }


    }
}
