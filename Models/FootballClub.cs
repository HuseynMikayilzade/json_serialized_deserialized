using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json.Models
{
    internal class FootballClub
    {
        public FootballClub(string name, string stadium, List<Baller> ballers)
        {
            Name = name;
            Stadium = stadium;
            this.ballers = ballers;
        }
        List<Baller> ballers;
        public string Name { get; set; }
        public string Stadium { get; set; }
        public void ShowAll()
        {
            ballers.ForEach(baller => { Console.WriteLine(baller); });
        }
        public void SalaryRange(int min,int max)
        {
            ballers.FindAll(baller => baller.Salary > min && baller.Salary < max).ForEach(baller => { Console.WriteLine($"name:{baller.Name} salary:{baller.Salary}"); });
        }
        public void RemoveBaller(int id)
        {
            Baller result=ballers.Find(baller => baller.Id == id);
            ballers.Remove(result);
        }
    }
}
