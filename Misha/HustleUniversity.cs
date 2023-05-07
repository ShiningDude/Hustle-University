namespace Misha
{

    partial class HustleUniversity
    {
        public class hustleUniversity
        {
            //Переменные 

            string Country;
            string City;
            int numverOfUniversities;

            //Конструктор студента


            //Конструктор универа
            public hustleUniversity(string Country, string City)
            {
                this.Country = Country;
                this.City = City;
                numverOfUniversities++;

            }

            //Фунция показа характеристик универа без возвращения
            public void showStatsOfPlace()
            {
                Console.WriteLine($"Country of university: {Country} \n City of university {City} \n");

            }







        }

    }
}
