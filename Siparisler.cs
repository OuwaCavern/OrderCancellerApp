using System;

namespace OrderCancellerApp
{
    public class Siparisler
    {
        public int ÇekNo { get; set; }
        public DateTime Tarih { get; set; }
        public bool Ödendi { get; set; }
        public bool Kapandı { get; set; }
        public string SiparişNo { get; set; }
    }
}