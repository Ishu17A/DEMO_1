using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo_1
{
    public  class BroadCast
    {
        public void broadcastemail(List<employee> list)
        {

            Console.WriteLine("Broad Cast email");

            MailMessage message = new MailMessage();
            Console.WriteLine("enter the msg body :");
            message.Body = Console.ReadLine();
            Console.WriteLine("enter the msg subject :");
            message.Subject = Console.ReadLine();
            foreach (employee employee in list)
            {

                message.From = new MailAddress("ishanbhanot177@gmail.com");
                message.To.Add(employee.email);

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Credentials = new System.Net.NetworkCredential("ishanbhanot177@gmail.com", "szyvxtppxjwljkpz");
                client.EnableSsl = true;

                Thread T1 = new Thread(delegate () { client.Send(message); });

                T1.Start();
                Thread.Sleep(1000);
                T1.Join();
                Console.WriteLine($"Email sent to {employee.email}");
            }


            return;

        }
    }
}
