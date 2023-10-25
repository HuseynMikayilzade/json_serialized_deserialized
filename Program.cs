using json.Models;
using Newtonsoft.Json;

namespace json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Baller> ballers = new List<Baller>();

            //ballers.Add(new Baller("Huseyn", "Mikayilzade", 20, 1000000m));
            //ballers.Add(new Baller("Lionel", "Messi", 36, 54000000m));
            //ballers.Add(new Baller("Neymar", "Jr", 31, 40000000m));
            //ballers.Add(new Baller("Andres", "Iniesta", 35, 45000000m));
            //ballers.Add(new Baller("Pique", "Gerrard", 31, 20000000m));
            //ballers.Add(new Baller("Ferid", "Haqverdiyev", 18, 1500000m));

            //string result = JsonConvert.SerializeObject(ballers);

            //using (StreamWriter sw = new StreamWriter(@"C:\Users\ca.r215.12\Desktop\json\Files\Huseyn.json"))
            //{
            //    sw.Write(result);
            //}


            string result;
            using (StreamReader rd = new StreamReader(@"C:\Users\ca.r215.12\Desktop\json\Files\ferid.json"))
            {
                result = rd.ReadToEnd();
            }

            List<Baller> ballers = JsonConvert.DeserializeObject<List<Baller>>(result);

            //foreach (var item in ballers)
            //{
            //    Console.WriteLine(item.Name);
            //}
            FootballClub footballClub = new FootballClub("Barcelona", "CampNou", ballers);
            footballClub.ShowAll();
            Console.WriteLine("--------------------------------------");
            footballClub.SalaryRange(2000000, 5000000);
            footballClub.RemoveBaller(7);
            footballClub.ShowAll();
        }

    }
}