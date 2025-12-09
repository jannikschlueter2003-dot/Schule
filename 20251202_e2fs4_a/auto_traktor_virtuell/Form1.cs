using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_traktor_virtuell
{
    public partial class Form1: Form
    {
        List<fahrzeuge> fuhrpark = new List<fahrzeuge>();

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Width = 1800;
            Height = 900;

            fuhrpark.Add(new auto(300, Color.Red, new Point(10, 10)));
            fuhrpark.Add(new traktor(300, Color.Green, new Point(100, 250)));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics zf = e.Graphics;

            foreach (fahrzeuge item in fuhrpark)
            {
                item.zeigen(zf);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (fahrzeuge item in fuhrpark)
            {
                item.fahren(Width);
            }

            Refresh();
        }
    }
}
