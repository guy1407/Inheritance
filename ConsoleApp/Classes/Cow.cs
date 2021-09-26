namespace Inheritance.Classes
{
   class Cow : FarmAnimal
   {

      #region Variables

      private string msCowNumber = string.Empty;

      #endregion Variables

      #region Properties

      public string CowNumber
      {
         get
         {
            return msCowNumber;
         }
         set
         {
            msCowNumber = value;
         }
      }

      #endregion Properties

      #region Methods

      public override void Talk()
      {
         System.Console.WriteLine("Mooooo...");
      }

      public override void Walk()
      {
         System.Console.WriteLine("Step...Step...");
      }

      public override void Product()
      {
         System.Console.WriteLine("Give milk...");
      }


      #endregion Methods

   }
}
