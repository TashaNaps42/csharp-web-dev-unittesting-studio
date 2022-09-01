using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }


        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void SimpleBracketsAndOneWordReturnsTrue()
        {
            //arrange
            string tester = "[Potato]";
            //action and assert
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(tester));
        }

        [TestMethod]
        public void EmptyTwoBracketsReturnsTrue()
        {
            string tester = "[[]]";
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(tester));
        }

        [TestMethod]
        public void SimpleTwoBracketsAroundStringReturnsTrue()
        {
            string tester = "[[Friends]]";
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(tester));
        }

        [TestMethod]
        public void TwoOpenBracketsOneCloserReturnsFalse()
        {
            string tester = "[[Friends]";
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(tester));
        }

        [TestMethod]
        public void BracketsInReverseReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void MultipleBracketsInReverseReturnFalse()
        {
            string tester = "][Booleans][AnotherGoodOne][";
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(tester));
        }

        [TestMethod]
        public void OneOpenBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void OneCloseBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void BalancedBracketsBeforeStringReturnTrue()
        {
            string tester = "[[]]Friends";
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(tester));
        }
        [TestMethod]
        public void BalancedBracketsAfterStringReturnTrue()
        {
            string tester = "Friends[[]][]";
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(tester));
        }
    }
}
