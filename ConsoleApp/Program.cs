namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello !");
            System.Console.WriteLine("Showing some animal inheritance stuff:");
            System.Console.WriteLine("--------------------------------------");

            //Pets have names:

            Inheritance.Classes.Cat c1 = new Inheritance.Classes.Cat();

            c1.Name = "Mitsy";

            c1.Talk();

            Inheritance.Classes.Cat c2 = new Inheritance.Classes.Cat("Bob");

            c2.Talk();

            ///////////////////////////////////

            Inheritance.Classes.Dog d1 = new Inheritance.Classes.Dog();

            d1.Name = "Hobo";

            d1.Talk();

            Inheritance.Classes.Dog d2 = new Inheritance.Classes.Dog("Fred");

            d2.Talk();

            
        }//Main
    }
}
