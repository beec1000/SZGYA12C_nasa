using System;
using System.Collections.Generic;
using System.Text;

namespace nasa
{
    class Keres
    {
        public string Cim { get; set; }
        public string DatumIdo { get; set; }
        public string Get { get; set; }
        public int HttpKod { get; set; }
        public string Meret { get; set; }

        public Keres(string s)
        {
            var v = s.Split('*');
            this.Cim = v[0];
            this.DatumIdo = v[1];
            this.Get = v[2];
            var a = v[3].Split(' ');
            this.HttpKod = int.Parse(a[0]);
            this.Meret = a[1];
        }
        public static int ByteMeret(string ValaszMerete)
        {
            int x = ValaszMerete == "-" ? 0 : int.Parse(ValaszMerete);
            return x;
        }
        //7. feldadat
        public static bool Domain(string Cimek)
        {
            return !Char.IsDigit(Cimek[Cimek.Length - 1]);
        }
    }

    
}
