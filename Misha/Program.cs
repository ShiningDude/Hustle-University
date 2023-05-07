using Misha;
using static Misha.HustleUniversity;

//Объявляем объекты класса hustleUniversity



Students Junior1 = new Students("Jeffrie", 21, 5, 25000);
Students Pro1 = new Students("Joe Rogan", 50, 20000000, 25000);
hustleUniversity Place1 = new hustleUniversity("Romania", "Bukharest");
Teachers Teacher1 = new Teachers("Smart Nerd Bob", 40, 100000.0, 20000.0);
SupportOnSite Support1 = new SupportOnSite("Indian Rahmad", 30, 250, 250);

//Выводим значения функций
Console.WriteLine("\tUniversity");
Place1.showStatsOfPlace();
Console.WriteLine("\tTeachers:");
Teacher1.showStats();

Console.WriteLine("\tStudents: ");
Junior1.showStats();
Pro1.showStats();
Console.WriteLine("\tSupports");
Support1.showStats();



Console.ReadKey();

//Класс HustleUniversity



