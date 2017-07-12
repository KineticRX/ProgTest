using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestNullParams()
        {
            int upperBound = 10;
            int[] multiples = new int[] { 3, 5 };
            string[] multReps = new string[] { "Fizz", "Buzz" };

            // Test double nulls
            List<String> expectedDN = new List<String>();
            expectedDN.Add("Error: Passed arrays are null.");

            List<String> actualDN = ClassLibrary1.Class1.FizzBuzz(upperBound, null, null);

            Assert.AreEqual<List<String>>(expectedDN, actualDN, "Double nulls improperly handled.");

            // Test null integers
            List<String> expectedI = new List<String>();
            expectedDN.Add("Error: Multiples array is null.");

            List<String> actualI = ClassLibrary1.Class1.FizzBuzz(upperBound, null, multReps);

            Assert.AreEqual<List<String>>(expectedI, actualI, "Null multiples improperly handled.");

            // Test null strings
            List<String> expectedS = new List<String>();
            expectedDN.Add("Error: Multiple replacement strings array is null.");

            List<String> actualS = ClassLibrary1.Class1.FizzBuzz(upperBound, multiples, null);

            Assert.AreEqual<List<String>>(expectedS, actualS, "Null multiple replacement strings improperly handled.");
        }
    }
}
