using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class BuildHouseFacade
    {
        BasementFacade basement;
        RoofFacade roof;
        FirstFloorFacade floor1;
        SecondFloorFacade floor2;
        VerandaFacade veranda;
        public BuildHouseFacade()
        {
            basement = new BasementFacade();
            roof = new RoofFacade();
            floor1 = new FirstFloorFacade();
            floor2 = new SecondFloorFacade();
            veranda = new VerandaFacade();
        }

        public void BuildSmallHouse()
        {
            Console.WriteLine("Small House building is started");
            basement.BuildBasement();
            floor1.BuildFloor();
            roof.BuildRoof();
            Console.WriteLine("Small House building is end");
        }

        public void BuildBigHouse()
        {
            Console.WriteLine("Big House building is started");
            basement.BuildBasement();
            floor1.BuildFloor();
            floor2.BuildFloor();
            veranda.VerandaFloor();
            roof.BuildRoof();
            Console.WriteLine("Big House building is end");
        }
    }
}

