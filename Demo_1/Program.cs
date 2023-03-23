using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Services;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Demo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Validation validation = new Validation();


            List<employee> list = new List<employee>();

            while (true) {


                Console.Write("1-Add" + "\n"
                    + "2-Delete" + "\n"
                    + "3-Update" + "\n"
                    + "4-show" + "\n"
                    + "5-show company by emp_id" + "\n"
                    + "6-show employee by company" + "\n"
                    + "7-Exit" + "\n"
                    + "8-Send the Email to selected person" + "\n"
                    + "9-send the Broadcast email" + "\n"
                    + "10-export data to csv" + "\n");
               

                int value = validation.checkid();

                switch (value)
                {
                        case 1 :
                        Add add = new Add();
                        add.add_details(list);
                        break;
                        case 2:
                        Console.WriteLine("delete");
                        Delete delete = new Delete();
                        delete.delete(list);
                        break;
                        case 3:
                        Console.WriteLine("update");
                        Update update = new Update();
                        update.update_data(list);
                        break;
                        case 4:
                        Console.WriteLine("show");
                        show show = new show();
                        show.show_details(list);
                        break;
                        case 5:
                        Console.WriteLine("show company by emp_id");
                        showcomp showcomany = new showcomp();
                        showcomany.showcompanyby_id(list);
                        break;
                        case 6:
                        showemployee showemployee = new showemployee();
                        showemployee.showemp(list);
                        break;
                        case 7:
                        Console.WriteLine("exit");
                        return;
                        case 8:
                        SIngleEmail emailbroadcast = new SIngleEmail();
                        emailbroadcast.emailsend(list);
                        break;
                        case 9:
                        BroadCast  broadcasgt = new BroadCast();
                        broadcasgt.broadcastemail(list);
                        break;
                        case 10:                   
                        Clsv  csv = new Clsv();
                        csv.csvexport(list);
                        break;


                          default:
                        Console.WriteLine("pls enter the valid input");
                        break;
                }


                Console.ReadLine();
            }

        }
    }
}
