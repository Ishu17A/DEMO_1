using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{
    public  class Clsv
    {
        public void csvexport(List<employee> list)
        {
            string root = Environment.CurrentDirectory;
           
            string projectDirectory = Directory.GetParent(root).Parent.FullName;
            

         
           
            
            Console.WriteLine("enter the file name :");
            string input = Console.ReadLine();
            string path = projectDirectory + "\\Output" + "\\" + input;
            Console.WriteLine(path);
            /*string root = @"D:\";*/
            
          /*  string file1 = Console.ReadLine();
            string path = root + file1*/;
            using (FileStream file = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine($"ID  , Name  , DEPT ,  TECHNOLOGY ,  OMPANY_NAME ,  email");
                    foreach (var item in list)
                    {
                        writer.WriteLine($"{item.userid},{item.name},{item.department},{item.technology},{item.company_name},{item.email}");
                    }
                }


            }

        }


    }



}
