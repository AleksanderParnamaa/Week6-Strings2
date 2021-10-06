using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = ("Dont Panic").ToUpper();
            for (int i = name.Length - 1; i > -1; i--)
            {
                Console.WriteLine(name[i]);
                
            }
        }
    }
}
