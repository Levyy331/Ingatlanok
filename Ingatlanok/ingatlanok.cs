using System;
using System.Collections.Generic;
using System.Text;

namespace Ingatlanok
{
    internal class ingatlanok
    {
        private int alapteruletM2 { get; set; }
        private int arEzerFt { get; set; }
        private static int osszesRegisztraltIngatlan = 0;
        public string Azonosito { get; set; }
        public string Cim { get; set; }
        public string Kategoria { get; set; }
        public int AlapteruletM2
        {
            get;
            set
            {
                if (value < 10)
                {
                    value = 10;
                }
            }
        }
        public int ArEzerFt
        {
            get;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
            }
        }
        public static int OsszesRegisztraltIngatlan
        {
            get
            {
                return osszesRegisztraltIngatlan;
            }
        }
        public ingatlanok(string azonosito, string cim, string kategoria, int alapteruletM2) : this(azonosito, cim, kategoria, alapteruletM2, (alapteruletM2 * 500)) { }
        public ingatlanok(string azonosito, string cim, string kategoria, int alapteruletM2, int arEzerFt)
        {
            Azonosito = azonosito;
            Cim = cim;
            Kategoria = kategoria;
            AlapteruletM2 = alapteruletM2;
            ArEzerFt = arEzerFt;
            osszesRegisztraltIngatlan++;
        }
        public override string ToString()
        {
            return $"[{Azonosito}] {Cim}({Kategoria}) - Terület: {AlapteruletM2} m2 | Ár:{ArEzerFt} ezer Ft";
        }
        public double NegyzetmeterAr()
        {
            return (ArEzerFt * 1000.0) / AlapteruletM2;
        }

    }
}
