using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_04
{
    public class Program : System.Windows.Forms.Form
    {

        delegate void Drawer(System.Drawing.Graphics g);

        Drawer drawers;

        public Program()
        {
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = new System.Drawing.Bitmap("..\\..\\Starsbg.jpg");
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 50;
            timer.Tick += tick;
            Planet jupiter = new Planet("jupiter", 200, 200, 50, 50, 40);
            Planet mars = new Planet("mars", 500, 100, 0, 100, 20);
            Spaceship enterpise = new Spaceship("enterprise",400,400,200,200,10);
            drawers += jupiter.Draw;
            drawers += mars.Draw;
            drawers += enterpise.Draw;
        }

        private void tick(object sender, EventArgs e)
        {
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            drawers(e.Graphics);
        }

        static void Main(string[] args)
        {
            Application.Run(new Program());
        }
    }
}
