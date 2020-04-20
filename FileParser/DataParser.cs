using System;
using System.Collections.Generic;
using System.Text;

namespace FileParser 
{
    public class DataParser 
    {
        

        /// <summary>
        /// Strips any whitespace before and after a data value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripWhiteSpace(List<List<string>> data) 
        {
            
            for(int i = 0; i < data.Count; i++)
            {
                for (int t = 0; t < data[i].Count; t++)
                {
                    data[i][t] = data[i][t].Trim(' ');
                }
            }

            Console.WriteLine("White space trimmed");

            return data; //-- return result here
        }

        /// <summary>
        /// Strips quotes from beginning and end of each data value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripQuotes(List<List<string>> data) 
        {
            
            for(int i = 0; i < data.Count; i++)
            {
                for(int t = 0; t < data[i].Count; t++)
                {
                    data[i][t] = data[i][t].TrimStart('"');
                    data[i][t] = data[i][t].TrimEnd('"');
                }
            }


            return data; //-- return result here
        }

    }
}