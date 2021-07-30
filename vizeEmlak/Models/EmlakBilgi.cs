using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vizeEmlak.Models
{
    public class EmlakBilgi
    {
        [Required(ErrorMessage ="İlan No Boş Geçilemez.")]
        public int IlanNo { get; set; }
        [Required(ErrorMessage = "İlan Tarihi Boş Geçilemez.")]
        public string IlanTar { get; set; }
        [Required(ErrorMessage = "Bina Yaşı Boş Geçilemez.")]
        public string BinaYasi { get; set; }
        [Required(ErrorMessage = "Metrekare Boş Geçilemez.")]
        public int MetreKare { get; set; }
        [Required(ErrorMessage = "Oda Sayısı Boş Geçilemez.")]
        public string OdaSayisi { get; set; }
        [Required(ErrorMessage = "Banyo Sayısı Boş Geçilemez.")]
        public int BanyoSayisi { get; set; }
        [Required(ErrorMessage = "Mobilya Durumu Boş Geçilemez.")]
        public string MobilyaDurumu { get; set; }
        [Required(ErrorMessage = "Kimden Boş Geçilemez.")]
        public string Kimden { get; set; }
        [Required(ErrorMessage = "Açıklama Boş Geçilemez.")]
        public string Aciklama { get; set; }

    }
}