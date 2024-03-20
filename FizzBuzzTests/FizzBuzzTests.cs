using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [TestMethod()]
        public void getNextNumberTest()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            for (int i = 1; i <= 100; i++)
            {
                Assert.AreEqual(fizzBuzz.getNextNumber(), i);
            }
        }

        [TestMethod()]
        public void isFizzBuzzTest()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.AreEqual(fizzBuzz.isFizzBuzz(15), true);
            Assert.AreNotEqual(fizzBuzz.isFizzBuzz(4), true);
        }

        [TestMethod()]
        public void isFizzTest()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.AreEqual(fizzBuzz.isFizz(3), true);
        }

        [TestMethod()]
        public void isBuzzTest()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.AreEqual(fizzBuzz.isBuzz(5), true);
        }

        [TestMethod()]
        public void getAnswerTest()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.AreEqual(fizzBuzz.getAnswer(1), "1");
            Assert.AreEqual(fizzBuzz.getAnswer(3), "Fizz");
            Assert.AreEqual(fizzBuzz.getAnswer(5), "Buzz");
            Assert.AreEqual(fizzBuzz.getAnswer(15), "FizzBuzz");

        }
    }
}