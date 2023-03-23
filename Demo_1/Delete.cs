using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{
    public  class Delete
    {

        Validation vala = new Validation();
        public void delete (List<employee> list) {

            Console.WriteLine("Delete Operation");
            Console.WriteLine("enter the index you want to remove : ");

            var index = vala.index();
            var itemToRemove = list.Single(r => r.userid == index);
            list.Remove(itemToRemove);


            return;
        }


    }
}
