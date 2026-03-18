using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class clsPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }


        clsPerson(int Id, string Name, string PhoneNumber, string Email, string Address)
        {
            this.Id = Id;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Address = Address;
        }


        public static clsPerson Find(int Id)
        {
            // we simulate that we are dealing with database 

            if (Id == 123) return new clsPerson(123, "Yusuf", "09242332423", "csfkj@gmail.com", "Aleppo");
            else return null;
        }

        public static clsPerson Find(int Id, string Name)
        {


            // we simulate that we are dealing with database 

            if (Id == 123&& Name=="Yusuf") return new clsPerson(123, "Yusuf", "09242332423", "csfkj@gmail.com", "Aleppo");
            else return null;


        }



    }


    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson Person1 = clsPerson.Find(123);
            if(Person1 !=null)
            {
                Console.WriteLine("Id: {0} ", Person1.Id);
            }

            clsPerson Person2 = clsPerson.Find(123, "Yusuf");
            if (Person2!=null)
            {
                Console.WriteLine("Id: {0} ", Person1.Id);
            }

            clsPerson Person3 = clsPerson.Find(2342);

            if (Person3==null)
            {
                Console.WriteLine("this object does not exist in the system ");
            }

        }
    }
}
