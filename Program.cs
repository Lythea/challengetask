using System;

class Program
{
    static void Main()
    {
        string input = "Hello, World!";
        string reversed = ReverseString(input);
        Console.WriteLine(input); //Original String
        Console.WriteLine(reversed); //Reverse String
    }

    static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
