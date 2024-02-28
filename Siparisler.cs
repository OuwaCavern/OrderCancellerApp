using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderCancellerApp
{
    public class Siparisler
    {
        public string MüşteriAdı { get; set; }
        public string Açıklama { get; set; }
        public bool Ödendi { get; set; }
        public bool Kapandı { get; set; }
        public int SiparişNo {  get; set; }
    }
}