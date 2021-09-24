namespace Animals
{
   abstract class Animal
   {
      public abstract void Walk()
      {
         System.Console.WriteLine("Step...Step...");
      }

      public abstract void Talk()
      {
         System.Console.WriteLine("Blah Blah...");
      }


   }
}//namespace