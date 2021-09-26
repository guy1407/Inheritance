namespace Inheritance.Classes
{
   class Dog : Pet
   {
      #region Constructor
         public Dog()
         {
             
         }

         public Dog(string name) : base(name)
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
         System.Console.WriteLine("Skip...Skip...");
      }

      public void WiggleTail()
      {
         System.Console.WriteLine("Wiggle Wiggle...");
      }
      #endregion Methods

   }
}
