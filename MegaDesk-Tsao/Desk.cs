using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tsao
{
    public enum SurfaceMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    public class Desk
    {
        public decimal Width { get; set; }

        public int Depth { get; set; }

        public int NumberofDrawer { get; set; }

        public SurfaceMaterial SurfaceMaterial { get; set; }

        public decimal GetArea()
        {
            return Width * Depth;
        }
    }
}
