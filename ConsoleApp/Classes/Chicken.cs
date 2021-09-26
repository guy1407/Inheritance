namespace Inheritance.Classes
{
   class Chicken : FarmAnimal
   {

      #region Methods

      public override void Talk()
      {
         System.Console.WriteLine("Puck Puck...");
      }

      public override void Walk()
      {
         System.Console.WriteLine("Right...Left...Right...Left...");
      }

      public override void Product()
      {
         System.Console.WriteLine("Lay egg...");
      }


      #endregion Methods

   }
}
