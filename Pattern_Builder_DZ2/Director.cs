using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Builder_DZ2
{
    class Director
    {
        public House build (HouseBuilder houseBuilder)
        {
            houseBuilder.CreateHouse();
            houseBuilder.SetRoof();
            houseBuilder.SetWalls();
            houseBuilder.SetDoors();
            houseBuilder.SetGarage();
            return houseBuilder.House;

        }
    }
}
