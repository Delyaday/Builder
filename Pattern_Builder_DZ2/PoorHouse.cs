using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Builder_DZ2
{
    class PoorHouse : HouseBuilder
    {
        public override void SetDoors()
        {
            this.House.door = new Door { Amount = 1 };
        }

        public override void SetGarage()
        {
            this.House.garage = new Garage { Type = "И гаража нет" };
        }

        public override void SetRoof()
        {
            this.House.roof = new Roof { Name = "Крыши нет" };
        }

        public override void SetWalls()
        {
            this.House.wall = new Wall { Number = 2 };
        }
    }
}
