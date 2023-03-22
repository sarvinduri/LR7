//Задание №1

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задание 1");
        string line = Console.ReadLine();
        HashSet<char> setLine = TranslateLineToSet(line);
        PrintSet(setLine);
        HashSet<char> setDigit = new HashSet<char> { '0', '1', '2', '3', '4', '5' };
        HashSet<char> setLetter = new HashSet<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        PrintSet(setDigit);
        HashSet<char> newSet = setLine; // копия исходного множества
        newSet.IntersectWith(setDigit);
        newSet.IntersectWith(setLetter);//пересечение 
        PrintSet(newSet);
        Console.ReadKey();
    }
    private static HashSet<char> TranslateLineToSet(string word)
    {
        HashSet<char> setWord = new HashSet<char>();
        foreach (char c in word)
        {
            setWord.Add(c);
        }
        return setWord;
    }
    private static void PrintSet(HashSet<char> set)
    {
        foreach (char c in set)
        {
            Console.Write($"{c} ");
        }
        Console.WriteLine();
    }
}


//Задание №2


//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Задание 2");
//        string[] allList = { "железнодорожный", "водный ", "автомобильный", "воздушный", "трубопроводный", "транспорт" };
//        string[] list1 = { "водный ", "автомобильный", "воздушный" };
//        string[] list2 = { "железнодорожный", "водный ", "автомобильный", "воздушный" };
//        string[] list3 = { "воздушный", "трубопроводный", "водный" };
//        PrintSet(allList);
//        PrintSet(list1);
//        PrintSet(list2);
//        PrintSet(list3);
//        Console.WriteLine("Входит во все множества:");
//        PrintSet(list1.Intersect(list2).Intersect(list3));

//        Console.WriteLine("НЕ входит ни в одно множества:");
//        PrintSet(allList.Except(list1).Except(list2).Except(list3));

//        Console.WriteLine("Входят во второе и третье множества:");
//        PrintSet(list2.Intersect(list3));
//    }

//    private static void PrintSet(IEnumerable<string> set)
//    {
//        foreach (string c in set)
//        {
//            Console.Write($"{c} ");
//        }
//        Console.WriteLine();
//    }
//}