using static Misha.People;

namespace Misha
{
    public partial class People
    {
        //Класс люди
        public class people
        {
            string name;
            int age;
            double salary;
            int netWorth;
            public int numberOfStudents;
            public int numberOfSupports;
            public int numberOfTeachers;

            //Конструктор люди
            public people(string name, int age, double salary, double bonus)
            {
                this.name = name;
                this.age = age;
                this.salary = salary + bonus;
            }

            //Свойство возвращения имени
            public virtual string getName()
            {
                return name;
            }

            //Свойство возвращения нетворф
            public int getNetWorth()
            {
                return netWorth;
            }

            //Свойство возвращения возраста
            public int getAge()
            {
                return age;
            }
            public double getSalary()
            {
                return salary;
            }
            //Функция показа статов
            public virtual void showStats()
            {
                Console.WriteLine($"Name of the person: {name} \n Salary of the person: {salary} \n");
            }

        }
    }
    public class SupportOnSite : people
    {
        public SupportOnSite(string name, int age, double salary, double bonus) : base(name, age, salary, bonus)
        {
            numberOfSupports++;

        }

        public override void showStats()
        {
            Console.WriteLine($"Name of the Support: {getName} \n Salary of the Support: {getSalary} \n");

        }

    }

    public class Teachers : people
    {
          public Teachers(string name, int age, double salary, double bonus) : base(name, age, salary, bonus)
        {

            numberOfTeachers++;

        }
        public override void showStats()
        {
            Console.WriteLine($"Name of the Teachers: {getName} \n Salary of the Teacher: {getSalary} \n");

        }
    }
    public class Students : people
    {
        public Students(string name, int age, double salary, double bonus) : base(name, age, salary, bonus)
        {
            numberOfStudents++;
        }
        public override void showStats()
        {
            Console.WriteLine($"Name of the Student: {getName} \n NetWorth of the Student: {getNetWorth} \n");
        }
    }
}