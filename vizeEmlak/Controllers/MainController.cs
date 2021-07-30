using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vizeEmlak.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Main()
        {           
            return View();
        }
        public ActionResult Navbar()
        {
            List<Models.navbar> navbar = new List<Models.navbar>();
            navbar.Add(new Models.navbar
            {
                NavName="Kurumsal Üyelik"
            });
            navbar.Add(new Models.navbar
            {
                NavName = "Haberler"
            });
            navbar.Add(new Models.navbar
            {
                NavName = "Projeler"
            });

            return View("Navbar", navbar);
        }
        public ActionResult EvListe()
        {

            List<Models.House> houseListe = new List<Models.House>();
            houseListe.Add(new Models.House
            {

                Mahalle = "Bahçelievler Mah.",
                Sokak = "Türkmeneli Sk.",
                No = 8,
                Ilce = "Merkez",
                Il = "Bilecik"
            });
            houseListe.Add(new Models.House
            {
                Mahalle = "Beşiktaş Mah.",
                Sokak = "İstiklal Sk.",
                No = 6,
                Ilce = "Merkez",
                Il = "Bilecik"
            });
            houseListe.Add(new Models.House
            {
                Mahalle = "Hürriyet Mah.",
                Sokak = "Şehit Erkan Alyanak Sk.",
                No = 3,
                Ilce = "Merkez",
                Il = "Bilecik"
            });

        

            return View("EvListe", houseListe);

        }
        public ActionResult IlanListele()
        {
            List<Models.NewHouse> ilanListe = new List<Models.NewHouse>();
            ilanListe.Add(new Models.NewHouse
            {
                Il ="İstanbul",
                IlanSayisi = "170.000"
            });
            ilanListe.Add(new Models.NewHouse
            {
                Il = "Eskişehir",
                IlanSayisi = "110.000"
            });
            ilanListe.Add(new Models.NewHouse
            {
                Il = "Ankara",
                IlanSayisi = "150.000"
            });
            ilanListe.Add(new Models.NewHouse
            {
                Il = "Çanakkale",
                IlanSayisi = "100.000"
            });
            return View("IlanListele", ilanListe);
        }
        public ActionResult EmlakDetayBilgi()
        {
            List<Models.EmlakBilgi> Liste = new List<Models.EmlakBilgi>();
            Liste.Add(new Models.EmlakBilgi
            {
                 Aciklama="Yeni yapılmış müstakil ev. Kolay ulaşım sağlanabilir. Birinci sınıf malzeme kullanılarak yapıldı. Yaz kış rahat edebilirsiniz.",
                 BanyoSayisi=5,
                 BinaYasi="2-8 Arası",
                 IlanNo=33874511,
                 IlanTar="30 Kasım 2020",
                 Kimden="Sahibinden",
                 OdaSayisi="5+1",
                 MetreKare=550,
                 MobilyaDurumu="Eşyasız"
            });
            return View("EmlakDetayBilgi", Liste);
        }
        [HttpGet]
        public ActionResult EvEkleme()
        {
            
            return View("EvEkleme");
        }
        [HttpPost]
        public ActionResult EvEkleme(Models.EmlakBilgi yeniurun)
        {
            if (ModelState.IsValid)
            {

            }
            return View("EvEkleme");
        }
        public ActionResult OnEvListele()
        {
            List<Models.EmlakBilgi> Liste = new List<Models.EmlakBilgi>();
            Liste.Add(new Models.EmlakBilgi
            {
                Aciklama = "Yeni yapılmış daire. Ferah ve doğayla uyumludur.",
                BanyoSayisi = 6,
                BinaYasi = "0-1 Arası",
                IlanNo = 3387541,
                IlanTar = "30 Eylül 2020",
                Kimden = "Sahibinden",
                OdaSayisi = "8+1",
                MetreKare = 350,
                MobilyaDurumu = "Eşyasız"
            });
            Liste.Add(new Models.EmlakBilgi
            {
                Aciklama = "Yeni onarılmış müstakil ev. Okullara ve şehir merkezine yakındır.",
                BanyoSayisi = 3,
                BinaYasi = "2-4 Arası",
                IlanNo = 33464511,
                IlanTar = "05 Ekim 2018",
                Kimden = "Sahibinden",
                OdaSayisi = "4+1",
                MetreKare = 250,
                MobilyaDurumu = "Eşyasız"
            });
            Liste.Add(new Models.EmlakBilgi
            {
                Aciklama = "Doğayla içiçe bir yaşam için idealdir. Yaz kış rahat edebilirsiniz.",
                BanyoSayisi = 3,
                BinaYasi = "3-4 Arası",
                IlanNo = 68747311,
                IlanTar = "16 Aralık 2020",
                Kimden = "Sahibinden",
                OdaSayisi = "3+1",
                MetreKare = 160,
                MobilyaDurumu = "Eşyasız"
            });
            Liste.Add(new Models.EmlakBilgi
            {
                Aciklama = "Kaliteli işçilik bulunmaktadır. Tadilatları yeni yapılmıştır.",
                BanyoSayisi = 3,
                BinaYasi = "1-7 Arası",
                IlanNo = 85474511,
                IlanTar = "23 Ağustos 2020",
                Kimden = "Sahibinden",
                OdaSayisi = "4+1",
                MetreKare = 350,
                MobilyaDurumu = "Eşyasız"
            });
            Liste.Add(new Models.EmlakBilgi
            {
                Aciklama = "Hemen taşınılmaya müsait bir evdir. Okullara ve şehir merkezine yakındır.",
                BanyoSayisi = 4,
                BinaYasi = "2-5 Arası",
                IlanNo = 76424511,
                IlanTar = "15 Temmuz 2020",
                Kimden = "Sahibinden",
                OdaSayisi = "4+1",
                MetreKare = 450,
                MobilyaDurumu = "Eşyalı"
            });
            Liste.Add(new Models.EmlakBilgi
            {
                Aciklama = "Şehrin gürültüsünden uzak, kış aylarının tasını çıkarabileceğiniz güzel bir evdir. ",
                BanyoSayisi = 2,
                BinaYasi = "6-8 Arası",
                IlanNo = 15484511,
                IlanTar = "16 Haziran 2020",
                Kimden = "Sahibinden",
                OdaSayisi = "7+1",
                MetreKare = 850,
                MobilyaDurumu = "Eşyalı"
            });
            Liste.Add(new Models.EmlakBilgi
            {
                Aciklama = "Çocuk parkına ve okullara yürüme mesafesinde, nezih bir mahallede yer almaktadır. Yerleşilmeye müsaittir.",
                BanyoSayisi = 2,
                BinaYasi = "3-7 Arası",
                IlanNo = 33874511,
                IlanTar = "17 Mayıs 2020",
                Kimden = "Sahibinden",
                OdaSayisi = "4+1",
                MetreKare = 270,
                MobilyaDurumu = "Eşyasız"
            });
            Liste.Add(new Models.EmlakBilgi
            {
                Aciklama = "Yazın şehirden uzaklaşabileceğiniz ferah bir evdir. Denize yürüme mesafesindedir.",
                BanyoSayisi = 4,
                BinaYasi = "1-2 Arası",
                IlanNo = 158464511,
                IlanTar = "21 Nisan 2020",
                Kimden = "Sahibinden",
                OdaSayisi = "5+1",
                MetreKare = 610,
                MobilyaDurumu = "Eşyalı"
            });
            Liste.Add(new Models.EmlakBilgi
            {
                Aciklama = "Aile ve çocuklar için uygun olarak tasarlanmıştır.Güvenilir bir semtte yer almaktadır.",
                BanyoSayisi = 2,
                BinaYasi = "2-8 Arası",
                IlanNo = 18544511,
                IlanTar = "14 Mart 2020",
                Kimden = "Sahibinden",
                OdaSayisi = "3+1",
                MetreKare = 180,
                MobilyaDurumu = "Eşyasız"
            });
            Liste.Add(new Models.EmlakBilgi
            {
                Aciklama = "Yürüyüş yolları ve mesira alanlarına yakın, doğayla iç içe bir evdir. Her mevsim rahat edebileceğiniz bir evdir. ",
                BanyoSayisi = 3,
                BinaYasi = "5-6 Arası",
                IlanNo = 16554511,
                IlanTar = "16 Şubat 2021",
                Kimden = "Sahibinden",
                OdaSayisi = "6+1",
                MetreKare = 430,
                MobilyaDurumu = "Eşyalı"
            });

            return View("OnEvListele", Liste);
        }
    }
}