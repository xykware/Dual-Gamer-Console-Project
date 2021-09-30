using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DataHandlingLib
{
    class parse_methods
    {
        public int StringToInt(string input)
        {
            int parsedString = int.Parse(input);
            return parsedString;
        }

        public int[] OptParamStringToIntArray(string input)
        {
            string[] pieces = input.Split(' ');

            List<int> intsList = new List<int>();
            int aNum;

            foreach (string s in pieces)
            {
                if (Int32.TryParse(s, out aNum))
                    intsList.Add(aNum);
            }

            int[] magicArray = intsList.ToArray();
            return magicArray;
        }

        public DateTime EventTimeStringToDateTime(string input)
        {
            DateTime parsedString = ;
            return DateTime parsedString;
        }

        public string IntToString(int input)
        {
            string parsedInt = $"{input}";
            return parsedInt;
        }

        public string OptParamIntArrayToString(int[] input)
        {
            string parsedIntArray = $"{input [0]} {input [1]} {input [2]} {input [3]}";
            return parsedIntArray;
        }

        public string EventTimeDateTimeToString(DateTime input)
        {
            string parsedDateTime = input.ToString("dddd, dd MMMM yyyy");
            return parsedDateTime;
        }


    }
}
