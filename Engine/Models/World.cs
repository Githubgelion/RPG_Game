using System;
using System.Collections.Generic;
using System.Text;


namespace Engine.Models
{
    public class World
    {
        List<Location> _location = new List<Location>();

        internal void AddLocations(int XCoordinate, int YCoordinate, string name, string description, string imageName)
        {
            Location loc = new Location();
            loc.xCoordiante = XCoordinate;
            loc.yCoordinate = YCoordinate;
            loc.Name = name;
            loc.Description = description;
            loc.ImageName = imageName;

            _location.Add(loc);
        }

        public Location LocationAt(int XCoordinate, int YCoordinate)
        {
            foreach (Location loc in _location)
            {
                if (loc.xCoordiante == XCoordinate && loc.yCoordinate == YCoordinate)
                {
                    return loc;
                }

            }
            return null;

        }


    }
}
