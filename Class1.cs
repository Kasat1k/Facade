using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class BasementFacade
    {
        public void BuildBasement()
        {
            Console.WriteLine("Basement is built");
        }
    }

    class RoofFacade
    {
        public void BuildRoof()
        {
            Console.WriteLine("Roof is build");
        }
    }


    class FirstFloorFacade
    {
        public void BuildFloor()
        {
            Console.WriteLine("First floor is built");
        }
    }
    class SecondFloorFacade
    {
        public void BuildFloor()
        {
            Console.WriteLine("Second floor is built");
        }
    }
    class VerandaFacade
    {
        public void VerandaFloor()
        {
            Console.WriteLine("Veranda is built");
        }
    }

}
