using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        /**
         * A more elaborate version of the "15 case" test requested.
         * */
        [TestMethod()]
        public void FizzBuzzMultipleMultiplesTest()
        {
            int upperBound = 30;
            int[] multiples = new int[] { 2, 5, 6, 10, 15 };
            string[] multReps = new string[] { "Two", "Five", "Six", "Ten", "Fifteen" };

            String expected = "Two Five Six Ten Fifteen";

            List<String> actual = ClassLibrary1.Class1.FizzBuzz(upperBound, multiples, multReps);

            Assert.AreEqual<String>(expected, actual[actual.Count - 1], "Values with several valid multiples improperly handled.");
        }


/*****************************************************************************************
* Additional tests that verify the "special cases" I've implemented are working properly *
******************************************************************************************/
        [TestMethod()]
        public void FizzBuzzDoubleNullTest()
        {
            int upperBound = 10;
            int[] multiples = null;
            String[] multReps = null;

            // Test double nulls
            List<String> expected = new List<String>();
            expected.Add("Error: Passed arrays are null.");

            List<String> actual = ClassLibrary1.Class1.FizzBuzz(upperBound, multiples, multReps);

            Assert.AreEqual<String>(expected[0], actual[0], "Null parameter arrays improperly handled.");
        }

        [TestMethod()]
        public void FizzBuzzNullIntArrayTest() {
            int upperBound = 10;
            string[] multReps = new string[] { "Fizz", "Buzz" };

            List<String> expected = new List<String>();
            expected.Add("Error: Multiples array is null.");

            List<String> actual = ClassLibrary1.Class1.FizzBuzz(upperBound, null, multReps);

            Assert.AreEqual<String>(expected[0], actual[0], "Null multiples array improperly handled.");
        }

        [TestMethod()]
        public void FizzBuzzNullRepStrArrayTest()
        {
            int upperBound = 10;
            int[] multiples = new int[] { 3, 5 };

            List<String> expected = new List<String>();
            expected.Add("Error: Multiple replacement strings array is null.");

            List<String> actual = ClassLibrary1.Class1.FizzBuzz(upperBound, multiples, null);

            Assert.AreEqual<String>(expected[0], actual[0], "Null multiple replacement strings array improperly handled.");
        }

        [TestMethod()]
        public void FizzBuzzBadMultiplesTest()
        {
            int upperBound = 10;
            int[] multiples = new int[] { 3, -5 };
            string[] multReps = new string[] { "Fizz", "Buzz" };

            List<String> expected = new List<String>();
            expected.Add("Error: Multiple at index 1 is less than 1. (Value = -5)");

            List<String> actual = ClassLibrary1.Class1.FizzBuzz(upperBound, multiples, multReps);

            Assert.AreEqual<String>(expected[0], actual[0], "Bad multiples improperly handled.");
        }

        [TestMethod()]
        public void FizzBuzzIndividualNullRepStrTest()
        {
            int upperBound = 10;
            int[] multiples = new int[] { 3, 5 };
            string[] multReps = new string[] { "Fizz", null };

            List<String> expected = new List<String>();
            expected.Add("Error: Multiple replacement string at index 1 is null. (replacement strings cannot be null)");

            List <String> actual = ClassLibrary1.Class1.FizzBuzz(upperBound, multiples, multReps);

            Assert.AreEqual<String>(expected[0], actual[0], "Null replacement strings improperly handled.");
        }

        [TestMethod()]
        public void FizzBuzzEmptyArraysTest()
        {
            int upperBound = 10;
            int[] multiples = new int[] { };
            string[] multReps = new string[] { };

            List<String> expected = new List<String>();
            expected.Add("Error: No multiples nor replacement strings provided.");

            List<String> actual = ClassLibrary1.Class1.FizzBuzz(upperBound, multiples, multReps);

            Assert.AreEqual<String>(expected[0], actual[0], "Empty parameter arrays improperly handled.");
        }

        [TestMethod()]
        public void FizzBuzzNotEnoughRepStringsTest()
        {
            int upperBound = 10;
            int[] multiples = new int[] { 3, 5 };
            string[] multReps = new string[] { "Fizz" };

            List<String> expected = new List<String>();
            expected.Add("Error: Too few replacement strings provided.  (Expected/Found) = (2/1)");

            List<String> actual = ClassLibrary1.Class1.FizzBuzz(upperBound, multiples, multReps);

            Assert.AreEqual<String>(expected[0], actual[0], "Missing replacement strings improperly handled.");
        }

        [TestMethod()]
        public void FizzBuzzNotEnoughMultiplesTest()
        {
            int upperBound = 10;
            int[] multiples = new int[] { 3 };
            string[] multReps = new string[] { "Fizz", "Buzz" };

            List<String> expected = new List<String>();
            expected.Add("Error: Too few multiples provided.  (Expected/Found) = (2/1)");

            List<String> actual = ClassLibrary1.Class1.FizzBuzz(upperBound, multiples, multReps);

            Assert.AreEqual<String>(expected[0], actual[0], "Missing multiples improperly handled.");
        }

        [TestMethod()]
        public void FizzBuzzInvalidBoundTest()
        {
            int upperBound = -10;
            int[] multiples = new int[] { 3, 5 };
            string[] multReps = new string[] { "Fizz", "Buzz" };

            List<String> expected = new List<String>();
            expected.Add("Error: Upper bounding value cannot be less than 1.");

            List<String> actual = ClassLibrary1.Class1.FizzBuzz(upperBound, multiples, multReps);

            Assert.AreEqual<String>(expected[0], actual[0], "Invalid upper bound value improperly handled.");
        }

    }
}