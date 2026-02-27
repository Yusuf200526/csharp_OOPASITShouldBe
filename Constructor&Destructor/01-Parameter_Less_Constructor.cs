using System;
using System.Runtime.CompilerServices;
using System.Threading;
class clsPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public clsPerson() // paramterLess construtor .
        // used to initialize the variables when creating objects from this class . 
    {
        Id = -1;
        Name = "Empty";
        Age = 0;
    }


}
internal class Program
{
    static void Main(string[] args)
    {
        clsPerson Person1 = new clsPerson();

        Console.WriteLine("Id := {0}", Person1.Id);
        Console.WriteLine("Name := {0}", Person1.Name);
        Console.WriteLine("Age := {0}", Person1.Age);

        Console.ReadKey();
    }
    
}
