using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Library.Game.Loop();
            }
            catch (FormatException InputError)
            {
                Console.WriteLine(InputError);
            }
            catch (OverflowException InputError)
            {
                Console.WriteLine(InputError);
            }
            finally { }
            Console.ReadLine();
        }
    }
}
