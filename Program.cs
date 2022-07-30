using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace DelegatesAndLambdasDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetFirstAndLastChar gfl = ShowFirstAndLastChar;
            Action<string, int> gfl = ShowFirstAndLastChar;
            gfl("Hello Nikos", 78);
            Console.WriteLine();
            //Reverse rev = ReverseString;
            Func<string, int, string> rev = ReverseString;
            Console.WriteLine($"'Hello World' becomes '{rev("Hello World", 23)}'");
            Console.WriteLine();
            //IsUpper iu = HasUpperChars;
            Predicate<string> iu = HasUpperChars;
            Console.WriteLine(iu("HI THERE"));
            
        }

        //User delegates
        //public delegate void GetFirstAndLastChar(string str, int n);
        //public delegate string Reverse(string str, int n);
        //public delegate bool IsUpper(string str, int n);

        static void ShowFirstAndLastChar(string s, int n) => Console.WriteLine(n + ": " + new string(Convert.ToString(s[0]) + Convert.ToString(s[s.Length - 1])));

        static string ReverseString(string s, int n) => n + ": " + new string(s.Reverse().ToArray());

        static bool HasUpperChars(string str) => Regex.Matches(str, @"[a-z]").Count > 0 ? false : true;
    }
}
