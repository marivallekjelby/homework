using System;
using static System.Console;
using static System.Math;

public class main
{
    public static void Main()
    {
        var list = new generic_list<double[]>();
        char[] delimiters = { ' ', '\t' };
        var options = StringSplitOptions.RemoveEmptyEntries;
        for (string line = ReadLine(); line != null; line = ReadLine())
        {
            var words = line.Split(delimiters, options);
            int n = words.Length;
            var numbers = new double[n];
            for (int i = 0; i < n; i++) numbers[i] = double.Parse(words[i]);
            list.push(numbers);
        }
        for (int i = 0; i < list.size; i++)
        {
            var numbers = list.data[i];
            foreach (var number in numbers) Write($"{number:e} ");
            WriteLine();
        }

        Writeline("-----------------------------------------------");
        WriteLine("Now I will remove element i=1 and print again:");
        WriteLine($"List size before removing i=1: {list.size}");
        list.remove(1);
        WriteLine($"Size after removing i=1: {list.size}");
        for (int i = 0; i < list.size; i++)
        {
            var numbers = list.data[i];
            foreach (var number in numbers) Write($"{number:e}");
            WriteLine();
        }


    }
}