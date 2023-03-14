using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P19
{
    public class NumberData
    {
        private int id;
        public int Id { get { return id; } }

        private string surname;
        public string Surname { get { return surname; } }

        private string name;
        public string Name { get { return name; } }

        private string name2;
        public string Name2 { get { return name2; } }

        private int phone;
        public int Phone { get { return phone; } }

        private string address;
        public string Address { get { return address; } }

        private string description;
        public string Description { get { return description; } }

        public NumberData(int id, string surname, string name, string name2, int phone, string address, string description)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.name2 = name2;
            this.phone = phone;
            this.address = address;
            this.description = description;
        }
    }

}
