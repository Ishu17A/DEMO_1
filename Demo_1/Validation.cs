using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo_1
{
    public  class Validation
    {

        public int checkid()
        {
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                    Console.WriteLine("enter the valid input pls");
            }           
            return id;
        }

        public string checkname(string name)
        {         
            while (!Regex.Match(name, "^[A-Za-z\\s]+$").Success)
            {
                Console.WriteLine("Invalid name");
               name  = Console.ReadLine();

            }
            return name;
        }

        public string checkcompanyname(string companyname)
        {
         while (!Regex.Match(companyname, "^[A-Za-z\\s]+$").Success)
         {
                Console.WriteLine("Invalid company_name");
                companyname = Console.ReadLine();

         }
            return companyname;

        }

        public string department(string department)
        {
            while (!Regex.Match(department, "^[A-Za-z\\s]+$").Success)
            {
                Console.WriteLine("Invalid department");
                department = Console.ReadLine();

            }
            return department;

        }


        public string technology(string technology)
        {


            while (!Regex.Match(technology, "^[A-Za-z\\s]+$").Success)
            {
                Console.WriteLine("Invalid technology");
                technology = Console.ReadLine();

            }
            return technology;

        }

        public string email(string email)
        {


            string pattern = @"^([a-z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            while (!Regex.Match(email, pattern).Success)
            {
                Console.WriteLine("Invalid email");
                email = Console.ReadLine();

            }
            return email;

        }


        public int index()
        {
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("enter the valid input pls");
            }
            return id;
        }











    }
}
