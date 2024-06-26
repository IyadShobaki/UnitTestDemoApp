﻿using Xunit;

namespace DemoLibrary.Tests
{
   public class CalculationsTests
   {
      [Theory]
      [InlineData(4, 2, 6)]
      [InlineData(0, 0, 0)]
      [InlineData(1234, -1234, 0)]
      public void AddShouldRetrunExpectedValue(double x, double y, double expected)
      {
         // Arrange
         Calculations calc = new Calculations();

         // Act
         double actual = calc.Add(x, y);

         // Assert

         Assert.Equal(expected, actual);
      }

      [Theory]
      [InlineData(8, 2, 6)]
      [InlineData(0, 2, -2)]
      [InlineData(9, -2, 11)]
      public void SubtractShouldRetrunExpectedValue(double x, double y, double expected)
      {
         // Arrange
         Calculations calc = new Calculations();

         // Act
         double actual = calc.Subtract(x, y);

         // Assert

         Assert.Equal(expected, actual);
      }

      [Theory]
      [InlineData(4, 2, 8)]
      [InlineData(40, 0, 0)]
      [InlineData(9, 9, 81)]
      public void MultiplyShouldRetrunExpectedValue(double x, double y, double expected)
      {
         // Arrange
         Calculations calc = new Calculations();

         // Act
         double actual = calc.Multiply(x, y);

         // Assert

         Assert.Equal(expected, actual);
      }

      [Theory]
      [InlineData(4, 2, 2)]
      [InlineData(1, 4, 0.25)]
      [InlineData(6, 2, 3)]
      [InlineData(15, 0, 0)]
      public void DivideShouldRetrunExpectedValue(double x, double y, double expected)
      {
         // Arrange
         Calculations calc = new Calculations();

         // Act
         double actual = calc.Divide(x, y);

         // Assert

         Assert.Equal(expected, actual);
      }
   }
}
