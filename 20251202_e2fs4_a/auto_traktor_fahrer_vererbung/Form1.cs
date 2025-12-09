using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_traktor_fahrer_vererbung
{
    public partial class Form1: Form
    {
        auto einAuto = new auto(300, Color.Red,
            new Point(10, 10));

        traktor einTraktor = new traktor(300, Color.Green,
            new Point(100, 250));

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Width = 1800;
            Height = 900;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics zf = e.Graphics;
            einAuto.zeigen(zf);
            einTraktor.zeigen(zf);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            einTraktor.fahren(Width);
            einAuto.fahren(Width);
            Refresh();

        }
    }
}
