namespace TPS.ConsoleApp
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {

            Int32 x = 0;
            if ("1".TryParseAs<Int32>(ref x))
            {
                Console.WriteLine("'1' parsed as Int32");
            }
            else
            {
                Console.WriteLine("'1' failed to parse as Int32");
            }

            SwimStroke s = SwimStroke.Unknown;
            if ("FREESTYLE".TryParseAs<SwimStroke>(ref s))
            {
                Console.WriteLine("'FREESTYLE' parsed as SwimStroke");
            }
            else
            {
                Console.WriteLine("'FREESTYLE' failed to parse as SwimStroke");
            }

            SwimStroke s2 = SwimStroke.Unknown;
            if ("SIDESTROKE".TryParseAs<SwimStroke>(ref s2))
            {
                Console.WriteLine("'SIDESTROKE' parsed as SwimStroke");
            }
            else
            {
                Console.WriteLine("'SIDESTROKE' failed to parse as SwimStroke");
            }

            Int32? y = null;
            if ("2".TryParseAs<Int32?>(ref y))
            {
                Console.WriteLine("'2' parsed as Int32?");
            }
            else
            {
                Console.WriteLine("'2' failed to parse as Int32?");
            }

            Console.ReadKey();

        }
    }
}
