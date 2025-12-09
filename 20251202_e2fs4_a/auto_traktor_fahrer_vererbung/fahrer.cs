using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace auto_traktor_fahrer_vererbung
{
    internal class fahrer
    {
        private int groesse;
        private Color augenF;
        private Color hautF;

        public fahrer(int groesse, Color augenF, Color hautF)
        {
            this.groesse = groesse;
            this.augenF = augenF;
            this.hautF = hautF;
        }

        public int Groesse { get => groesse; set => groesse = value; }

        public void zeigen(Graphics zf, int x, int y)
        {
            int teil = groesse / 4;

            //Kopf
            Pen Stift = new Pen(Color.Gray);
            SolidBrush ff = new SolidBrush(hautF);

            zf.FillEllipse(ff, x - groesse, y - groesse, 2 * groesse, 2 * groesse);
            zf.DrawEllipse(Stift, x - groesse, y - groesse, 2 * groesse, 2 * groesse);

            //Augen
            Stift.Color = Color.Black;
            Stift.Width = 1;
            ff.Color = Color.White;

            zf.FillEllipse(ff, x - 3 * teil, y - 2 * teil, 2 * teil, teil);
            zf.FillEllipse(ff, x + teil, y - 2 * teil, 2 * teil, teil);
            zf.DrawEllipse(Stift, x - 3 * teil, y - 2 * teil, 2 * teil, teil);
            zf.DrawEllipse(Stift, x + teil, y - 2 * teil, 2 * teil, teil);
            ff.Color = augenF;
            zf.FillEllipse(ff, (float)(x - 2.4 * teil), y - 2 * teil,
                (float)(0.8 * teil), (float)(0.9 * teil));
            zf.FillEllipse(ff, (float)(x + 1.6 * teil), y - 2 * teil,
                (float)(0.8 * teil), (float)(0.9 * teil));

            //Nase
            Stift.Width = 3;
            zf.DrawLine(Stift, x, y - teil, x, y + teil);

            //Mund
            teil = 2 * groesse / 3;
            zf.DrawArc(Stift, x - teil, y - teil, 2 * teil, 2 * teil, -190, -160);

        }
    }
}
