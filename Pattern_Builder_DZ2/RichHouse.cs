using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Builder_DZ2
{
    class RichHouse : HouseBuilder
    {
        public override void SetDoors()
        {
            this.House.door = new Door { Amount = 13 };
        }

        public override void SetGarage()
        {
            this.House.garage = new Garage { Type = "Огромный" };
        }

        public override void SetRoof()
        {
            this.House.roof = new Roof { Name = "Кирпичная" };
        }

        public override void SetWalls()
        {
            this.House.wall = new Wall { Number = 26 };
        }
    }
}
