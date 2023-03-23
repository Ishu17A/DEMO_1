using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{
   public  class Add
   {
      Validation valadd = new Validation();
        public void add_details(List<employee> list)
        {
            Console.WriteLine("add operation");

            Console.WriteLine("enter the Name :");      
            var name = valadd.checkname(Console.ReadLine());
            

            Console.WriteLine("enter the company name :");
            var company_name = valadd.checkcompanyname( Console.ReadLine());

            Console.WriteLine("enter the department :");
            var department = valadd.department(Console.ReadLine());


            Console.WriteLine("enter the technology :");
            var technology = valadd.technology(Console.ReadLine());


            Console.WriteLine("enter the email :");
            var email = valadd.email(Console.ReadLine());

            int userid = 0;

            if (list.Count == 0)
            {
                userid = 1;
            }
            else
            {
                userid = list.Max(emp => emp.userid);
                userid++;
            }

            employee add_to = new employee(userid, name, company_name, department, technology , email);

            list.Add(add_to);
        }
    }
}
