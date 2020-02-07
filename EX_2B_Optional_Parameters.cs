// 3.  "Syntactic Sugar" is using the shorter of two versions of writing code. Both versions generate the 
// same result, but the "syntactic sugar" version uses a shortcut.

using System;

namespace EX_2B_Optional_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Two Optional Parameters

            void InstrumentSound(string instrument = "horn", string sound = "honk")
            {
                Console.WriteLine($"The {instrument} goes \"{sound}\"!");
            }

            // 2. Overloaded Functions

            void InstrumentSound(string instrument, string sound)
            {
                Console.WriteLine($"The {instrument} goes \"{sound}\"!");
            }

            void InstrumentSound(string instrument)
            {
                InstrumentSound(instrument, "honk");
            }

            {
                InstrumentSound("horn", "honk");
            }

        }
    }
}
