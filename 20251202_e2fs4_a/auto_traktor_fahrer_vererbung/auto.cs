using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace auto_traktor_fahrer_vererbung
{
    internal class auto : fahrzeuge
    {
        //Deklaration der Attribute der Klasse

        /*Der Konstruktor ist eine besonder Methode, welche ein Objekt
         * der Klasse erzeugt. Der Konstruktor hat immer denselben Namen
         * wie die Klasse selbst und er hat keinen Rückgabewert. Auch
         * kein void.*/
        public auto(int groesse, Color farbe, Point pos)
        {
            this.groesse = groesse;
            this.farbe = farbe;
            this.pos = pos;
        }

        public void zeigen(Graphics zf)
        {
            //Ursprung Fenster
            Point uF = new Point(pos.X + groesse - 2 - groesse / 4,
                pos.Y + 2);

            //Ursprung linkes Rad
            Point ulR = new Point(pos.X + 19, 
                pos.Y + groesse / 2 - groesse / 8);

            //Ursprung rechtes Rad
            Point urR = new Point(pos.X + groesse - 19 - groesse / 4,
                pos.Y + groesse / 2 - groesse / 8);

            //Ursprung linke Felge
            Point ulF = new Point(pos.X + 19 + groesse / 16,
                pos.Y + groesse / 2 - groesse / 16);

            //Ursprung rechte Felge
            Point urF = new Point(pos.X + groesse - 19 - 3 * groesse / 16,
                pos.Y + groesse / 2 - groesse / 16);

            SolidBrush br = new SolidBrush(farbe);

            //Zeichne Karrosserie
            zf.FillRectangle(br, pos.X, pos.Y, groesse, groesse / 2);

            //Zeichne Fenster
            br.Color = Color.White;
            zf.FillRectangle(br, uF.X, uF.Y, groesse / 4, groesse / 4);

            //Zeichne Räder
            br.Color = Color.Black;
            zf.FillEllipse(br, ulR.X, ulR.Y, groesse / 4, groesse / 4);
            zf.FillEllipse(br, urR.X, urR.Y, groesse / 4, groesse / 4);

            //Zeichne Felgen
            br.Color = Color.Silver;
            zf.FillEllipse(br, ulF.X, ulF.Y, groesse / 8, groesse / 8);
            zf.FillEllipse(br, urF.X, urF.Y, groesse / 8, groesse / 8);

            //Fahrer anzeigen
            einFahrer?.zeigen(zf, uF.X + groesse / 8, uF.Y + groesse / 8);

        }
    }
}
