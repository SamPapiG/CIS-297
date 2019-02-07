using Microsoft.VisualStudio.TestTools.UnitTesting;
using YahtzeeGameForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGameForm.Tests
{
    [TestClass()]
    public class ScoreCardTests
    {
        [TestMethod()]
        public void ScoreCardTest()
        {
            // Arrange
            var expectedValues = new List<int> { 1, 2, 3, 4, 5};
            NotActuallyRandom random = new NotActuallyRandom(expectedValues);
            var dice = new Dice(random);
            var expectedOnesScore = 1;
            var expectedTwosScore = 2;
            var expectedThreesScore = 3;
            var expectedFoursScore = 4;
            var expectedFivesScore = 5;
            var expectedSixesScore = 6;
            var expectedFullHouseScore = 0;


            // Act
            dice.Roll();
            var testScorecard = new ScoreCard(dice);
            testScorecard.CalculateOnes(dice);
            testScorecard.CalculateTwos(dice);
            testScorecard.CalculateThrees(dice);
            testScorecard.CalculateFours(dice);
            testScorecard.CalculateFives(dice);
            testScorecard.CalculateSixes(dice);


            // Assert
            Assert.AreEqual(expectedOnesScore, testScorecard.Ones);
            Assert.AreEqual(expectedTwosScore, testScorecard.Twos);
            Assert.AreEqual(expectedThreesScore, testScorecard.Threes);
            Assert.AreEqual(expectedFoursScore, testScorecard.Fours);
            Assert.AreEqual(expectedFivesScore, testScorecard.Fives);
            Assert.AreEqual(expectedSixesScore, testScorecard.Sixes);
            


            Assert.AreEqual(expectedFullHouseScore, testScorecard.FullHouse);
        }
    }
}