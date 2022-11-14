namespace Facade
{
    // Mainapp test application 
    class MainApp
    {
        public static void Main()
        {
            BuildHouseFacade house = new BuildHouseFacade();
            house.BuildSmallHouse();
            Console.WriteLine();
            house.BuildBigHouse();
            Console.Read();
        }
    }
}