using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{
    public class Update
    {
        Validation vala = new Validation();
        public void update_data(List<employee> list)
        {
            Console.WriteLine("update operation");
            Console.WriteLine("enter the index you have to update ");
           /* var updateId = int.Parse(Console.ReadLine());*/
            var updateId = vala.index();
            var updateObj = list.FirstOrDefault(x => x.userid == updateId);
            Console.WriteLine("UserId Found");
            Console.WriteLine("Please Input the new values");
            Console.WriteLine("Enter Name");
            string nameInput = vala.checkname(Console.ReadLine());
            updateObj.name = nameInput;
            Console.WriteLine("ENTER DEPT.");
            string deptinput = vala.department( Console.ReadLine());
            updateObj.department = deptinput;
            Console.WriteLine("ENTER TECHNOLOGY");
            string technologyinput = vala.technology( Console.ReadLine());
            updateObj.technology = technologyinput;
            Console.WriteLine("ENTER COMPANYNAME");
            string companyinput = vala.checkcompanyname( Console.ReadLine());
            updateObj.company_name = companyinput;
            return;
        }

    }
}
