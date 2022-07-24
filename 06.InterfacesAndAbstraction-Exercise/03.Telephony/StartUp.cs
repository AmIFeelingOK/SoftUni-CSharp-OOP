using _03.Telephony.Core;
using _03.Telephony.IO;
using _03.Telephony.IO.Interfaces;
using System;
using System.Linq;

namespace _03.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);
            engine.Start();
        }
    }
}
