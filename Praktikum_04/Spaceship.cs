using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum_04
{
    public class Spaceship : Orb
    {

        public Spaceship(string name, double x, double y, double vx, double vy, double m) : base(name, x, y, vx, vy, m)
        {

        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(bitmap, pos);
        }
    }
}
