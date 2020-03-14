using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocations(-2, -1, "Farmer's Field",
                    "There are rows of corn growing here, with giant rats hiding between them.",
                    "/RPG_Game;component/Images/Locations/FarmFields.png");

            newWorld.AddLocations(-1, -1, "Farmer's House",
                "This is the house of your neighbor, Farmer Ted.",
                "/RPG_Game;component/Images/Locations/Farmhouse.png");

            newWorld.AddLocations(0, -1, "Home",
                "This is your home",
                "/RPG_Game;component/Images/Locations/Home.png");

            newWorld.AddLocations(-1, 0, "Trading Shop",
                "The shop of Susan, the trader.",
                "/RPG_Game;component/Images/Locations/Trader.png");

            newWorld.AddLocations(0, 0, "Town square",
                "You see a fountain here.",
                "/RPG_Game;component/Images/Locations/TownSquare.png");

            newWorld.AddLocations(1, 0, "Town Gate",
                "There is a gate here, protecting the town from giant spiders.",
                "/RPG_Game;component/Images/Locations/TownGate.png");

            newWorld.AddLocations(2, 0, "Spider Forest",
                "The trees in this forest are covered with spider webs.",
                "/RPG_Game;component/Images/Locations/SpiderForest.png");

            newWorld.AddLocations(0, 1, "Herbalist's hut",
                "You see a small hut, with plants drying from the roof.",
                "/RPG_Game;component/Images/Locations/HerbalistsHut.png");

            newWorld.AddLocations(0, 2, "Herbalist's garden",
                "There are many plants here, with snakes hiding behind them.",
                "/RPG_Game;component/Images/Locations/HerbalistsGarden.png");



            return newWorld;
        }
    }
}
