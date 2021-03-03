using System;
using System.Text;

namespace LDCDeveloperCodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            var inputString = ValidateString();

            try
            {
                var resultString = RemoveDuplicateChars(inputString);

                var stringBuilderOutput = StringBuilder(resultString);

                //If output string > 15, below condition will check and truncated to max length of 15 characters
                if (stringBuilderOutput.Length > 15)
                {
                    Console.WriteLine("Output string is: {0} ", stringBuilderOutput.Substring(0, 15));
                }
                else if (stringBuilderOutput.Length == 0) // Case: Output string is NULL
                {
                    Console.WriteLine("Output string is NULL");
                }
                else
                {
                    Console.WriteLine("Output string is: {0} ", stringBuilderOutput);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }

        //To validate empty string
        static string ValidateString()
        {
            var str = Console.ReadLine();
            if (str == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }

            return str;
        }

        //Remove duplicate characters from string
        static string RemoveDuplicateChars(string inputStr)
        {
            var str = string.Empty;
            for (int i = 0; i < inputStr.Length; i++)
            {
                if (!str.Contains(inputStr[i]))
                {
                    str += inputStr[i];
                }
            }

            return str;
        }

        //Replace multiple string elements
        static string StringBuilder(string inputStr)
        {
            StringBuilder sb = new StringBuilder(inputStr);
            sb.Replace("$", "£");
            sb.Replace("_", "");
            sb.Replace("4", "");

            return sb.ToString();
        }

    }
}
