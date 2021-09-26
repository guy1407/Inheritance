namespace Inheritance.Classes
{
   class Cat:Pet
   {

      #region Constructor
         public Cat()
         {
             
         }

         public Cat(string name) : base(name)
         {
             
         }
      #endregion Constructor

      #region Methods

      public override void Talk()
      {
         System.Console.WriteLine($"Meow Meow... my name is {this.Name}");
      }

      public override void Walk()
      {
         System.Console.WriteLine("Jump... Jump...");
      }

      #endregion Methods

   }//class Cat:Pet
}//namespace Inheritance.Classes
