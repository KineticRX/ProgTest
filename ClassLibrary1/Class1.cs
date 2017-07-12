using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        // GitHub link to Rayne@clear-measure.com
        /**
         * Creates a list of integers from 1 to "upperBound" (inclusive).  Whenever a value is a multiple
         * of a value within "multiples[]", it is replaced with the associated string within "multReps[]".
         * If a value is a multiple of several values within "multiples[]", all associated strings within
         * "multReps[]" will be used (separated by a whitespace character).
         * PARAMS:
         * int upperBound -- The final value in the returned list. Must be a positive, non-zero integer.
         * int[] multiples -- Values that are a multiple of these integers will be replaced. Cannot be null.
         * String[] multReps -- The strings to replace values when they are a valid multiple. Cannot be
         * null.  Cannot contain null strings.
         * RETURN:
         * List(String) -- If all parameters are valid, a list of integers from 1 to "upperBound" (inclusive)
         * where all integers are a multiple of a value within "multiples[]" are replaced with the replacement
         * string provided at the same index within "multReps[]."  If any parameters are invalid, the list will
         * contain an explanation of all failed checks (one explanation per index per detected failure).
         * */
        public static List<String> FizzBuzz(int upperBound, int[] multiples, String[] multReps)
        {
            // First, verify that all parameters are valid.
            List<String> retList;
            retList = ValidateParameters(upperBound, multiples, multReps);
            if (retList.Count != 0)
            {
                return retList;
            }

            for (int i = 1; i <= upperBound; i++)
            {
                String curEntry = "";
                for (int j = 0; j < multiples.Length; j++)
                {
                    if (i % multiples[j] == 0)
                    {
                        if (curEntry.Length != 0)
                        {
                            curEntry += " ";
                        }
                        curEntry += multReps[j];
                    }
                }
                if (curEntry.Length == 0)
                {
                    curEntry += i;
                }
                retList.Add(curEntry);
            }

            return retList;
        }

        /**
         * Ensures that all parameters passed to method FizzBuzz() are usable as intended.
         * If successful: An empty List is returned for the method to populate.
         * If unsuccessful: A list of errors is returned.
         * */
        private static List<String> ValidateParameters(int upperBound, int[] multiples, String[] multReps)
        {
            List<String> errorList = new List<String>();
            if (multiples == null && multReps == null)
            {
                errorList.Add("Error: Passed arrays are null.");
            }
            if (multiples == null && multReps != null)
            {
                errorList.Add("Error: Multiples array is null.");
            }
            if (multiples != null)
            {
                for (int i = 0; i < multiples.Length; i++)
                {
                    if (multiples[i] < 1)
                    {
                        errorList.Add("Error: Multiple at index " + i + " is less than 1. (Value = " + multiples[i] + ")");
                    }
                }
            }
            if (multReps == null && multiples != null)
            {
                errorList.Add("Error: Multiple replacement strings array is null.");
            }
            if (multReps != null)
            {
                for (int i = 0; i < multReps.Length; i++)
                {
                    if (multReps[i] == null)
                    {
                        errorList.Add("Error: Multiple replacement string at index " + i + " is null. (replacement strings cannot be null)");
                    }
                }
            }
            if (multiples != null && multReps != null)
            {
                if (multiples.Length == 0 && multReps.Length == 0)
                {
                    errorList.Add("Error: No multiples nor replacement strings provided.");
                }
                if (multiples.Length > multReps.Length)
                {
                    errorList.Add("Error: Too few replacement strings provided.  (Expected/Found) = (" + multiples.Length + "/" + multReps.Length + ")");
                }
                if (multiples.Length < multReps.Length)
                {
                    errorList.Add("Error: Too few multiples provided.  (Expected/Found) = (" + multReps.Length + "/" + multiples.Length + ")");
                }
            }
            if (upperBound < 1)
            {
                errorList.Add("Error: Upper bounding value cannot be less than 1.");
            }
            return errorList;
        }
    }
}
