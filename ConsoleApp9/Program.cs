using static System.Console;
using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World made by Code Maine!");

            int x = 9;
            for(int i=0 ; i<10 ; i++)
            {
                WriteLine("Another Line but different changes" + x.ToString());
            }
        }
    }
}
