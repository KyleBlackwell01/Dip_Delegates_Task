using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ObjectLibrary;


namespace FileParser 
{
    
    //public class Person { }  // temp class delete this when Person is referenced from dll
    
    public class PersonHandler 
    {
        public List<Person> People;

        /// <summary>
        /// Converts List of list of strings into Person objects for People attribute.
        /// </summary>
        /// <param name="people"></param>
        public PersonHandler(List<List<string>> people) 
        {
            People = new List<Person>();

            DataParser dataParser = new DataParser();
            people = dataParser.StripQuotes(people);
            people = dataParser.StripWhiteSpace(people);
            people = dataParser.RemoveHashes(people);

            for (int i = 1;  i < people.Count; i++)
            {
                People.Add(new Person(int.Parse(people[i][0]), people[i][1], people[i][2], new DateTime(long.Parse(people[i][3]))));
            }

        }

        /// <summary>
        /// Gets oldest people
        /// </summary>
        /// <returns></returns>
        public List<Person> GetOldest() 
        {
            DateTime dateB = People.Select(i => i.Dob).Min();

            List<Person> result = People.Where(p => p.Dob == dateB).ToList();


            return result; //-- return result here
        }

        /// <summary>
        /// Gets string (from ToString) of Person from given Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetString(int id) 
        {
            return "result";  //-- return result here
        }

        public List<Person> GetOrderBySurname() 
        {

            var result = People.OrderBy(p => p.Surname).ToList();

            return result;  //-- return result here
        }

        /// <summary>
        /// Returns number of people with surname starting with a given string.  Allows case-sensitive and case-insensitive searches
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <param name="caseSensitive"></param>
        /// <returns></returns>
        public int GetNumSurnameBegins(string searchTerm, bool caseSensitive) 
        {
            if (caseSensitive)
            {
                return People.Count(p => p.Surname.StartsWith(searchTerm));
            }
            else
            {
                return People.Count(p => p.Surname.ToLower().StartsWith(searchTerm.ToLower()));
            }
            ///*return*/ 0;  //-- return result here
        }
        
        /// <summary>
        /// Returns a string with date and number of people with that date of birth.  Two values seperated by a tab.  Results ordered by date.
        /// </summary>
        /// <returns></returns>
        public List<string> GetAmountBornOnEachDate() 
        {
            List<string> result = new List<string>();

            return result;  //-- return result here
        }
    }
}