using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace auto_traktor_fahrer_vererbung
{
    internal class traktor : fahrzeuge

    {
        //Deklaration der Attribute der Klasse

        /*Der Konstruktor ist eine besonder Methode, welche ein Objekt
         * der Klasse erzeugt. Der Konstruktor hat immer denselben Namen
         * wie die Klasse selbst und er hat keinen Rückgabewert. Auch
         * kein void.*/
        public traktor(int groesse, Color farbe, Point pos)
        {
            this.groesse = groesse;
            this.farbe = farbe;
            this.pos = pos;
        }

        public void zeigen(Graphics zf)
        {
            //Ecken des Traktors und Ursprung der Räder
            int g = (int)(0.9 * groesse);
            int rRadH = g / 3;
            int rRadV = rRadH / 2;
            Point p2 = new Point((int)(pos.X + g / 2.2), pos.Y);
            Point p3 = new Point(p2.X + g / 5, (int)(p2.Y + g / 2.2));
            Point p4 = new Point((int)(pos.X + g * 1.4), p3.Y);
            Point p5 = new Point(p4.X, p3.Y + g / 2);
            Point p6 = new Point(pos.X, p5.Y);
            Point[] ecken = { pos, p2, p3, p4, p5, p6 };
            Point oRadH = new Point(pos.X + 10 + rRadH / 2, p5.Y);
            Point oRadV = new Point(p4.X - 3 - rRadH / 2, p5.Y);

            //Karroserie zeichnen
            SolidBrush ff = new SolidBrush(farbe);
            zf.FillPolygon(ff, ecken);

            //Fenster zeichnen
            ff.Color = Color.White;
            zf.FillRectangle(ff, pos.X + 2, pos.Y + 5,
                p2.X - pos.X, p3.Y - pos.Y);

            //Räder zeichnen
            ff.Color = Color.Black;
            zf.FillEllipse(ff, oRadH.X - rRadH, oRadH.Y - rRadH,
                2 * rRadH, 2 * rRadH);
            zf.FillEllipse(ff, oRadV.X - rRadV, oRadV.Y,
                2 * rRadV, 2 * rRadV);

            //Felgen zeichnen
            ff.Color = Color.Silver;
            zf.FillEllipse(ff, oRadH.X - rRadH / 2, oRadH.Y - rRadH / 2,
                rRadH, rRadH);
            zf.FillEllipse(ff, oRadV.X - rRadV / 2, oRadV.Y + rRadV / 2,
                rRadV, rRadV);

            if (einFahrer != null)
            {
                einFahrer.Groesse = groesse / 6;
            }

            einFahrer?.zeigen(zf, pos.X + 2 + (p2.X - pos.X) / 2,
                pos.Y + 5 + (p3.Y - pos.Y) / 2);

        }
    }
}
