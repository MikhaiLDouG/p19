using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace P19
{
    public class Book
    {
        private List<NumberData> numbers;
        private string path = "PhoneBook.Json";
        public Book()
        {
            numbers = new List<NumberData>();
            //numbers.Add(new NumberData(1, "Olegov", "Oleg", "Olegovich", 8987, "M Street", "-"));
            //numbers.Add(new NumberData(2, "Ivanov", "Ivan", "Ivanovich", 8942, "G Street", "-"));
            //File.WriteAllText("PhoneBook.Json", JsonConvert.SerializeObject(numbers));
        }

        public List<NumberData> GetNumbers()
        {
            string json = File.ReadAllText(path);
            numbers = JsonConvert.DeserializeObject<List<NumberData>>(json);
            return numbers;
        }

        public NumberData GetNumber(int id)
        {
            foreach (var i in GetNumbers())
            {
                if (i.Id == id)
                {
                    return i;
                }
            }
            return null;
        }

    }
}
