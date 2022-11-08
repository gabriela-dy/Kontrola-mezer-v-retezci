Console.WriteLine("Zadejte číslo:");
string s = Console.ReadLine();
Console.WriteLine("Zadal jste text: " + s);
Console.WriteLine("Text po funkci trim: " + s.Trim());
int a = int.Parse(s);
Console.WriteLine("Převedl jsem zadaný text na číslo parsováním, zadal jste: " + a);
Console.ReadKey();