using System;
using System.Collections.Generic;
using FileParser;

public delegate List<List<string>> Parser(List<List<string>> data);

namespace Delegate_Exercise
{
    class Delegate_Exercise
    {
        static void Main(string[] args)
        {
            CsvHandler csHandler = new CsvHandler();

            DataParser dataParser = new DataParser();

            Func<List<List<string>>, List<List<string>>> results = dataParser.StripQuotes;

            results += dataParser.StripWhiteSpace;
            results += RemoveHashes;

            csHandler.ProcessCsv("D:/Coding/data.csv", "D:/Coding/processed_data.csv", results);

        }

        public static List<List<string>> RemoveHashes(List<List<string>> data) 
        {
            foreach(var row in data) 
            {
                for (var index = 0; index < row.Count; index++) 
                {
                    if(row[index][0] == '#')
                        row[index] = row[index].Remove(0,1); 
                }
            }
            return data;
            
        }
    }
}
