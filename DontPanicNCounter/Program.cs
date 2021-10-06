using System;

namespace DontPanicNCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int Counter = 0;
            string dont = ("dont panic");
            for (int i = 0; i < dont.Length; i++)
            {
                if (dont[i] == 'n')
                {
                    Counter++; 
                }

            }
            if (Counter == 1)
            {
                Console.WriteLine($"The sentence dont panic has {Counter} letters 'n' in it");
            }
            else
            {
                Console.WriteLine($"The sentence dont panic has {Counter} letters 'n' in it");
            }
        }
    }
}
