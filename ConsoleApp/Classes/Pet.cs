namespace Inheritance.Classes
{
   abstract class Pet : Animal
   {
      #region Variables

      #endregion Variables

      #region Properties

      public string Name { get; set; }

      #endregion Properties

      #region  Constructors

         public Pet()
         {
             
         }
         public Pet(string name)
         {
             this.Name = name;
         }

      #endregion  Constructors

   }//class Pet

}//namespace Inheritance.Classes
