using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true )]
        [InlineData("Howdy", false )]
        public void MyTest(string word, bool expected)
        {
            // arrange
            var test = new WordSmith();

            // act
            bool  actual = test.IsAPalindrome(word);

            // assert
            Assert.Equal(expected, actual);
        } 


    }
} 
