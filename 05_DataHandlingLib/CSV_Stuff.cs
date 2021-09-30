using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DataHandlingLib
{
    public class GoogleSheetStuff
    {
        string eventCSVFilePath; // ie c:\FolderName\EventCSVData.csv"

        public void importEventCSV(string filePath)
        {
            StreamReader reader = null;
            if (File.Exists(filePath))
            {
                //Read the CSV
                reader = new StreamReader(File.OpenRead(filePath));
                //Make a _List of Strings
                List<string> listA = new List<string>();

                //while reading (until the Stream Ends) do these things
                while (!reader.EndOfStream)
                {   
                    //read the stuff and make it into a sting
                    string line = reader.ReadLine();
                    //split the string into pieces based on where the ','s are
                    string[] values = line.Split(',');
                    //add each piece to the list
                    foreach (string item in values)
                    {
                        listA.Add(item);
                    }
                    //now we have a list of strings
                }

                // cut arrays of strings 18 (number of items in EventContent obj) long
                // do things based on their position in that sequence of 18

                // ignore the first 18 - (because they are the column labels)

                // for each other series of 18 strings
                // 1 - Parse to Int 
                // 2 - Parse to DateTime
                // 3 - Leave as String
                // 4 - Leave as String
                // 5 - Parse to int[]
                // 6 - Parse to int
                // 7 - Leave as String
                // 8 - Parse to int[]
                // 9 - Parse to int
                // 10 - Leave as String
                // 11 - Parse to int[]
                // 12 - Parse to int
                // 13 - Leave as String
                // 14 - Parse to int[]
                // 15 - Parse to int
                // 16 - Leave as String
                // 17 - Parse to int[]
                // 18 - Parse to int

                // save each (by sequence) to entry in EventContent

                // deal with blank/null values

                // repeat for all "series"


            }
        }
    }
}
