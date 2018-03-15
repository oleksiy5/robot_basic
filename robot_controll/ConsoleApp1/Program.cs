using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboController;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robotMarek = new Robot(2000);

            string keyControl = "";
            while (keyControl != "end")
            {
                keyControl = Console.ReadLine();
                if (keyControl == ":)")
                    robotMarek.Smile(true);
                else if (keyControl == ":(")
                    robotMarek.Sad(true);
                if (keyControl == ":)")
                    robotMarek.Smile(true);
                else if (keyControl == "-")
                    robotMarek.Sleep();
            }
        }
    }
}
