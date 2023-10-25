using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.Models
{
    internal class Baller
    {
        
     
        public Baller(string name, string surname, int age, decimal salary )
        {
            Name = name;
            Id = ++Count;
            Surname = surname;
            Age = age;
            Salary = salary;
        }
        public static int Count { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public override string ToString()
        {
            return $"Id {Id} Name {Name} Surname {Surname} Age {Age} Salary {Salary} ";
        }
    }
}
