
// Red, Green, Refactor

namespace DemoLibrary
{
   public class DisplayMessages
   {
      public string Greeting(string firstName, int hourOfTheDay)
      {
         string output = "";

         // DataAcess da = new DataAccess();
         // da.WriteToDB("MyData");

         // for mocking we use dependency injection
         // which we pass DataAccess object as a parameter
         // and in unit test we pass a pretend data access object


         if (hourOfTheDay < 5)
         {
            output = $"Go to bed {firstName}";

         }
         else if (hourOfTheDay < 12)
         {
            output = $"Good morning {firstName}";

         }
         else if (hourOfTheDay < 18)
         {
            output = $"Good afternoon {firstName}";
         }
         else
         {
            output = $"Good evening {firstName}";

         }

         return output;
      }
   }
}
