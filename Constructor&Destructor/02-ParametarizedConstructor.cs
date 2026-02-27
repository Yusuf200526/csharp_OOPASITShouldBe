using System;
using System.Runtime.CompilerServices;
using System.Threading;
class clsPerson
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public clsPerson(int Id, string Name, short Age) // parametarized constructor for real values. 
    {
        this.Id = Id;
        this.Name = Name;
        this.Age = Age;
    }


}
internal class Program
{
    static void Main(string[] args)
    {
        clsPerson Person1 = new clsPerson(1,"YusufShaabanArja",20);
        // clsPerson Person1= new clsPerson(); ❌ because it is parametarized. 

        Console.WriteLine("Id := {0}", Person1.Id);
        Console.WriteLine("Name := {0}", Person1.Name);
        Console.WriteLine("Age := {0}", Person1.Age);

        Console.ReadKey();
    }
    
}


  
