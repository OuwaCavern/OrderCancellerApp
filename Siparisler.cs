using System;
using System.ComponentModel;

namespace OrderCancellerApp
{
    public class Siparisler
    {
        [DisplayName("Çek No")]
        public int ÇekNo { get; set; }

        [DisplayName("Sipariş No")]
        public string SiparişNo { get; set; }
        public DateTime Tarih { get; set; }
        public bool Ödendi { get; set; }
        public bool Kapandı { get; set; }
    }
}