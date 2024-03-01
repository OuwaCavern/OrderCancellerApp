using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderCancellerApp
{
    public class Siparisler
    {
        public int ÇekNo { get; set; }
        public DateTime Tarih { get; set; }
        public bool Ödendi { get; set; }
        public bool Kapandı { get; set; }
        public int SiparişNo {  get; set; }
    }
}