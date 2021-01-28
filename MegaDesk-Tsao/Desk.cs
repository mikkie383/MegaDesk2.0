using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tsao
{
    public enum SurfaceMaterial
    {
        Pine = 50,
        Laminate = 100,
        Veneer = 125,
        Oak = 200,
        Rosewood = 300
    }

    public class Desk
    {
        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public int NumberofDrawer { get; set; }

        public SurfaceMaterial SurfaceMaterial { get; set; }

        public Desk(decimal Width, decimal Depth, int NumberofDrawer, SurfaceMaterial surfaceMaterial)
        {
            this.Width = Width;
            this.Depth = Depth;
            this.NumberofDrawer = NumberofDrawer;
            this.SurfaceMaterial = surfaceMaterial;
        }

        public decimal GetArea()
        {
            return Width * Depth;
        }
    }
}
