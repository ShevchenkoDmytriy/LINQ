using System;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
var world = new List<Vocabulary>();
var world1 = new List<Vocabulary1>();
char ch;
Vocabulary X = new Vocabulary(null,null);
Vocabulary1 Y = new Vocabulary1(null, null);

do
{
ret1: Console.Clear();
    Console.WriteLine("Menu");
    Console.WriteLine("1.-Add");
    Console.WriteLine("2.-Output");
    Console.WriteLine("3.-Find");
    Console.WriteLine("4.-Delete");
    Console.WriteLine("5.-Edit");
    ch = Convert.ToChar(Console.ReadLine());
    if (ch == '1' || ch == '2' || ch == '3' || ch == '4' || ch == '5')
    {
        switch (ch)
        {
            case '1':
                Console.Clear();
                Console.WriteLine("1.-Англо-український");
                Console.WriteLine("2.-Укр-англ");
                ch = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                switch (ch)
                {
                    case '1':
                        Console.WriteLine("Введiть слово: ");
                        string? one = Console.ReadLine();
                        Console.WriteLine("Введiт переклад: ");
                        string? two = Console.ReadLine();
                        world.Add(new Vocabulary(one, two));
                        break;
                    case '2':
                        Console.WriteLine("Введiть слово: ");
                        string? one1 = Console.ReadLine();
                        Console.WriteLine("Введiт переклад: ");
                        string? two1 = Console.ReadLine();
                        world1.Add(new Vocabulary1(one1, two1));
                        break;
                }
                break;
            case '2':
                Console.Clear();
                Console.WriteLine(" _________________________ ");
                Console.WriteLine("|Англо-український словник|");
                Console.WriteLine("|_________________________|");
                var selectPe = from p in world
                               orderby p.first
                               select p;
                foreach (var person in selectPe)
                {
                    Console.WriteLine(person.first + "-" + person.second);
                }
                Console.WriteLine("\n ________________ ");
                Console.WriteLine("|Укр-англ словник|");
                Console.WriteLine("|________________|");
                var selectP = from p in world1
                              orderby p.first
                              select p;
                foreach (var person in selectP)
                {
                    Console.WriteLine(person.first + "-" + person.second);
                }
                Console.ReadKey();
                break;
            case '3':

                Console.Clear();
                Console.WriteLine("1.-Англо-український");
                Console.WriteLine("2.-Укр-англ");
                ch = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                switch (ch)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Введiть слово яке потрiбно знайти: ");
                        string? name1 = Console.ReadLine();
                        var selectPeo = from p in world
                                        where p.first == name1
                                        select p;
                        foreach (var item in selectPeo)
                        {
                            string? name2 = item.second;
                            var find = world.Contains(new Vocabulary(name1, name2));
                            if (find == true)
                            {
                                Console.WriteLine("Слово знайдено");
                                Console.WriteLine(item.first + "-" + item.second);
                            }
                            else
                                Console.WriteLine("Такого слова немає");
                        }
                        break;
                    case '2':

                        Console.Clear();
                        Console.WriteLine("Введiть слово яке потрiбно знайти: ");
                        string? name4 = Console.ReadLine();
                        var selectPeop = from p in world1
                                         where p.first == name4
                                         select p;
                        foreach (var item in selectPeop)
                        {
                            string? name3 = item.second;
                            var find = world1.Contains(new Vocabulary1(name4, name3));
                            if (find == true)
                            {
                                Console.WriteLine("Слово знайдено");
                                Console.WriteLine(item.first + "-" + item.second);
                            }
                            else
                                Console.WriteLine("Такого слова немає");
                        }
                        break;
                }
                Console.ReadKey();
                break;
            case '4':
                Console.Clear();
                Console.WriteLine("1.-Англо-український");
                Console.WriteLine("2.-Укр-англ");
                ch = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                switch (ch)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Введiть слово яке потрiбно видалити: ");
                        string? name1 = Console.ReadLine();
                        Console.WriteLine("Введiть переклад слова яке потрiбно видалити: ");
                        string? name2 = Console.ReadLine();
                        var find = world.Remove(new Vocabulary(name1, name2));
                        if (find == true)
                        {
                            Console.WriteLine("Слово знайдено i видалено");
                        }
                        else
                            Console.WriteLine("Такого слова немає");

                        Console.ReadKey();
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Введiть слово яке потрiбно видалити: ");
                        string? name4 = Console.ReadLine();
                        Console.WriteLine("Введiть переклад слова яке потрiбно видалити: ");
                        string? name3 = Console.ReadLine();
                        var find1 = world1.Remove(new Vocabulary1(name4, name3));
                        if (find1 == true)
                        {
                            Console.WriteLine("Слово знайдено i видалено");
                        }
                        else
                            Console.WriteLine("Такого слова немає");

                        Console.ReadKey();
                        break;
                }
                break;
            case '5':
                Console.Clear();
                Console.WriteLine("1.-Англо-український");
                Console.WriteLine("2.-Укр-англ");
                ch = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                switch (ch)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Введiть слово яке потрiбно знайти: ");
                        string? name1 = Console.ReadLine();
                        var selectPeo = from p in world
                                        where p.first == name1
                                        select p;
                        foreach (var item in selectPeo)
                        {
                            string? name2 = item.second;
                            var find = world.Contains(new Vocabulary(name1, name2));

                            if (find == true)
                            {
                                Console.WriteLine("Введiть ще один преклад цього слова: ");
                                string? nam = Console.ReadLine();
                                int index = world.IndexOf(world.Where(n => n.second == nam).FirstOrDefault());
                                world[index] = X;
                                Console.WriteLine("Слово замінено");
                                Console.WriteLine(item.first + "-" + item.second);
                            }
                            else
                                Console.WriteLine("Такого слова немає");
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Введiть слово яке потрiбно знайти: ");
                        string? name3 = Console.ReadLine();
                        var selectPeoP = from p in world1
                                        where p.first == name3
                                        select p;
                        foreach (var item in selectPeoP)
                        {
                            string? name2 = item.second;
                            var find = world1.Contains(new Vocabulary1(name3, name2));
                            if (find == true)
                            {
                                Console.WriteLine("Введiть новий преклад цього слова: ");
                                string? nam = Console.ReadLine();
                                int index = world1.IndexOf(world1.Where(n => n.second == nam).FirstOrDefault());
                                world1[index] = Y;
                                Console.WriteLine("Слово замінено");
                                Console.WriteLine(item.first + "-" + item.second);
                            }
                            else
                                Console.WriteLine("Такого слова немає");
                        }
                        break;
                }
                break;

        }
    }
    else
    {
        goto ret1;
        Console.ReadKey();
    }
    using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
    {
        foreach (var item in world)
        {
            await JsonSerializer.SerializeAsync<Vocabulary>(fs, item);
        }
        foreach (var item1 in world1)
        {
            await JsonSerializer.SerializeAsync<Vocabulary1>(fs, item1);
        }
    }
} while (ch != 27);

record class Vocabulary(string first, string second);
record class Vocabulary1(string first, string second);

