using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Builder_DZ2
{
    class House
    {
        public Roof roof { get; set; }
        public Door door { get; set; }
        public Wall wall { get; set; }
        public Garage garage { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (roof != null)
            {
                sb.Append("Крыша: " + roof.Name);
            }

            if (door != null)
            {
                sb.Append("Количество дверей: " +door.Amount.ToString());
            }

            if (wall != null)
            {
                sb.Append("Количество стен: " + wall.Number.ToString());
            }

            if (garage != null)
            {
                sb.Append("Гараж: " + garage.Type);
            }

            return sb.ToString();
        }
    }
}
