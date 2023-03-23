using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo_1
{
    public class SIngleEmail
    {

        public void emailsend(List<employee> list)
        {
            Console.WriteLine("select the index to send  email to selected email");
            Console.WriteLine("select the emp id:");
            var sendId = int.Parse(Console.ReadLine());
            var sendObj = list.FirstOrDefault(x => x.userid == sendId);
            var emailaddress = sendObj.email;


            MailMessage message = new MailMessage();

            message.From = new MailAddress("ishanbhanot177@gmail.com");
            message.To.Add(emailaddress);
            Console.WriteLine("enter the msg body :");
            message.Body = Console.ReadLine();
            Console.WriteLine("enter the msg subject :");
            message.Subject = Console.ReadLine();
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new System.Net.NetworkCredential("ishanbhanot177@gmail.com", "szyvxtppxjwljkpz");
            client.EnableSsl = true;

            Thread T1 = new Thread(delegate () { client.Send(message); });

            T1.Start();
            Thread.Sleep(1000);
            T1.Join();
            Console.WriteLine($"Email sent to {emailaddress}");

            return;
        }

    }
}
