using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{


    [Serializable()]
    public class employee 
    {

        public string name { get; set; }
        public string company_name { get; set; }
        public string department { get; set; }
        public string technology { get; set; }

        public int userid { get; set; }

        public string email { get; set; }



        public employee( int id, string name , string company_name , string department , string technology , string email ) {

            this.name = name;
            this.company_name = company_name;
            this.department = department;
            this.technology = technology;
            this.userid = id;
            this.email = email;

        }



    }
}
