namespace Inheritance.Classes
{
   abstract class Animal
   {
      #region Properties

         public int Legs { get; set; }

         public bool Gender { get; set; }

      #endregion Properties

      #region Methods

      public abstract void Walk();
      
      public abstract void Talk();

      #endregion Methods
   }
}//namespace