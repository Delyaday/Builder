using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Builder_DZ2
{
    abstract class HouseBuilder
    {
        public House House { get; private set; }
        public void CreateHouse()
        {
            House = new House();
        }
        public abstract void SetRoof();
        public abstract void SetDoors();
        public abstract void SetWalls();
        public abstract void SetGarage();

    }
}
