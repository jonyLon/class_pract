using System.Runtime.InteropServices;
using System.Text;

namespace class_pract
{
    internal class Program
    {

        internal class City
        {
            private string name = "Rivne";
            private string country = "UA";
            private string phone_code = "380-362";
            private string[] areas = new string[] {"rivne"};
            private int population = 250000;
            public City(string name, string country, string pcode, int population, params string[] areas)
            {
                Name = name;
                Country = country;
                PhoneCode = pcode;
                Population = population;
                Areas = areas;
            }
            public City(params string[] areas) 
            {
                Areas = areas;
            }

            public string Name
            {
                get {  return name; }
                set
                {
                    if (!String.IsNullOrWhiteSpace(value))
                    {
                        name = value;
                    }
                }
            }
            public string Country
            {
                get { return country; }
                set
                {
                    if (!String.IsNullOrWhiteSpace(value))
                    {
                        country = value;
                    }
                }
            }
            public string PhoneCode
            {
                get { return phone_code; }
                set { 
                    if (!String.IsNullOrWhiteSpace(value))
                    {
                        phone_code = value;
                    }
                }
            }
            public int Population { get { return population; }
                set {
                    if (value > 1)
                    {
                        population = value;
                    }
                } }

            public string[] Areas { get { return areas; }
                set
                {
                    if (value != null)
                    {
                        areas = value;
                    }
                }

            }
            public override string ToString()
            {
                string line = "";
                for (int i = 0; i < areas.Length; i++)
                {
                    line += areas[i] + "\t";
                }

                return $"Name: {name}\nCountry: {country}\nPhone code: {phone_code}\nPopulation: {population}\n" + line;
            }

        }


        static void Main(string[] args)
        {
            City rivne = new City(new string[]{ "Rivne", "Dubno", "Varash", "Ostrog" });
            Console.WriteLine(rivne.ToString());
        }
    }
}