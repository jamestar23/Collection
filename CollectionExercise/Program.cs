using System;
using System.Collections.Generic;

namespace CollectionExercise
{
    class Program
    {
        //Group 1
        static void Main(string[] args)
        {
            var cityDictionary = new Dictionary<string, City>();

            cityDictionary.Add("Toronto", new City(13448494, "Ontario"));
            cityDictionary.Add("Montreal", new City(8164361, "Quebec"));
            cityDictionary.Add("Calgary", new City(4067175, "Alberta"));

            foreach (KeyValuePair<string, City> kpv in cityDictionary)
            {
                Console.WriteLine("{0} is a city in {1} - {2})", kpv.Key, kpv.Value.Province, kpv.Value.Population);
            }

            var cityNA = new HashSet<string>();
            cityNA.Add("Chicago");

            var capitalsCA = new HashSet<string>(cityDictionary.Keys);
            capitalsCA.IntersectWith(cityNA);
            foreach (var item in capitalsCA)
                Console.WriteLine("{0} is in Canada and also in the top 10 largest cities in North America.", item);
        }
    }
    public class City
    {
        public int Population { get; set; }
        public string Province { get; set; }

        public City(int _population, string _province)
        {
            this.Population = _population;
            this.Province = _province;
        }
        public string CombineString()
        {
            return Province + Convert.ToString(Population);
        }
    }
}