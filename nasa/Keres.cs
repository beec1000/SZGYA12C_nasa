using System;
using System.Collections.Generic;
using System.Text;

namespace nasa
{
    class Keres
    {
        public string Cim { get; set; }
        public DateTime DatumIdo { get; set; }
        public string Get { get; set; }
        public int HttpKod { get; set; }
        public string Meret { get; set; }

        public Keres(string s)
        {
            var v = s.Split('*');
            this.Cim = v[0];
            var d = v[1].Split('/');
            var i = d[2].Split(':');
            this.DatumIdo = new DateTime(/*int.Parse(d[0]), int.Parse(d[1]), int.Parse(d[2]), int.Parse(i[0]), int.Parse(i[1]), int.Parse(i[2])*/);
            this.Get = v[2];
            var a = v[3].Split(' ');
            this.HttpKod = int.Parse(a[0]);
            this.Meret = a[1];
        }
        public byte ByteMeret()
        {
            
        }
    }

    
}
