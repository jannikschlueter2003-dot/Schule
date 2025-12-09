using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_traktor_virtuell
{
    abstract class fahrzeuge
    {
        //Deklaration der Attribute der Klasse
        protected Color farbe;
        protected Point pos;
        protected int groesse;
        protected int schritt = 1;
        protected fahrer einFahrer;

        public fahrzeuge()
        {

        }

        public void fahren(int zfb)
        {
            pos.X += schritt;

            if ((pos.X >= zfb) | (pos.X < 0))
            {
                schritt *= -1;
            }

            if (einFahrer == null)
            {
                einFahrer = new fahrer(groesse / 9, Color.Blue, Color.Yellow);
            }
        }

        public abstract void zeigen(Graphics zf);
        
    }
}
