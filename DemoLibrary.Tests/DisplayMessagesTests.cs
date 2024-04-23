//using Xunit;


//// Arrange, Act, Assert
//// Expected and Actual
//namespace DemoLibrary.Tests
//{
//   public class DisplayMessagesTests
//   {
//      [Fact]
//      public void GreetingShouldReturnGoToBedMessage()
//      {
//         /// Arrange
//         DisplayMessages messages = new DisplayMessages();

//         // Expected
//         string expected = "Go to bed Iyad";


//         /// Act

//         // Actual
//         string actual = messages.Greeting("Iyad", 2);

//         /// Assert
//         Assert.Equal(expected, actual);
//      }

//      [Fact]
//      public void GreetingShouldReturnGoodAfternoonMessage()
//      {
//         /// Arrange
//         DisplayMessages messages = new DisplayMessages();

//         // Expected
//         string expected = "Good afternoon Iyad";


//         /// Act

//         // Actual
//         string actual = messages.Greeting("Iyad", 14);

//         /// Assert
//         Assert.Equal(expected, actual);
//      }

//      [Theory]
//      [InlineData("Iyad", 0, "Go to bed Iyad")]
//      [InlineData("Iyad", 1, "Go to bed Iyad")]
//      [InlineData("Iyad", 2, "Go to bed Iyad")]
//      [InlineData("Iyad", 3, "Go to bed Iyad")]
//      [InlineData("Iyad", 4, "Go to bed Iyad")]
//      [InlineData("Iyad", 5, "Good morning Iyad")]
//      [InlineData("Iyad", 6, "Good morning Iyad")]
//      [InlineData("Iyad", 7, "Good morning Iyad")]
//      [InlineData("Iyad", 8, "Good morning Iyad")]
//      [InlineData("Iyad", 9, "Good morning Iyad")]
//      [InlineData("Iyad", 10, "Good morning Iyad")]
//      [InlineData("Iyad", 11, "Good morning Iyad")]
//      [InlineData("Iyad", 12, "Good afternoon Iyad")]
//      [InlineData("Iyad", 13, "Good afternoon Iyad")]
//      [InlineData("Iyad", 14, "Good afternoon Iyad")]
//      [InlineData("Iyad", 15, "Good afternoon Iyad")]
//      [InlineData("Iyad", 16, "Good afternoon Iyad")]
//      [InlineData("Iyad", 17, "Good afternoon Iyad")]
//      [InlineData("Iyad", 18, "Good evening Iyad")]
//      [InlineData("Iyad", 19, "Good evening Iyad")]
//      [InlineData("Iyad", 20, "Good evening Iyad")]
//      [InlineData("Iyad", 21, "Good evening Iyad")]
//      [InlineData("Iyad", 22, "Good evening Iyad")]
//      [InlineData("Iyad", 23, "Good evening Iyad")]

//      public void GreetingShouldReturnExpectedValue(
//         string firstName,
//         int hourOfTheDay,
//         string expected)
//      {
//         /// Arrange
//         DisplayMessages messages = new DisplayMessages();

//         /// Act

//         // Actual
//         string actual = messages.Greeting(firstName, hourOfTheDay);

//         /// Assert
//         Assert.Equal(expected, actual);
//      }
//   }
//}
