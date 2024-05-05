using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    class Calisan
    {
        private int _calisanNo;
        private string _calisanAd;
        private double _calisanMaas;

        public int CalisanNo
        {
            get { return _calisanNo; }
            set { _calisanNo = value; }
        }

        public string CalisanAd
        {
            get { return _calisanAd; }
            set { _calisanAd = value; }
        }
        public double CalisanMaas
        {
            get { return _calisanMaas; }
            set { _calisanMaas = value; }
        }
    }

    //Yönetici Sınıfımız, Çalışan sınıfına kalıtım yapıldığı belirtiliyor(:)
    class Yonetici : Calisan
    {
        private double _departmanKar;

        public double DepartmanKar
        {
            get { return _departmanKar; }
            set { _departmanKar = value; }
        }
    }
    //Personel Sınıfımız, Çalışan sınıfına kalıtım yapıldığı belirtiliyor(:)
    class Personel : Calisan
    {
        private int _satisSayisi;

        public int SatisSayisi
        {
            get { return _satisSayisi; }
            set { _satisSayisi = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yeni bir Yonetici elemanı oluşturuyoruz.
            Yonetici yonetici = new Yonetici();

            //Inheritance ile Calısan sınıfından aldığımız üyeler.
            yonetici.CalisanNo = 1;
            yonetici.CalisanAd = "Fatih Alkan";
            yonetici.CalisanMaas = 8500.78;

            //Yöneyici sınıfında tanımlanan üyeler.
            yonetici.DepartmanKar = 175000;

            //Yeni bir Personel elamanı oluşturuyoruz ve üyelerini çağrıyoruz.
            Personel personel = new Personel();
            personel.CalisanNo = 2;
            personel.CalisanAd = "Beyazıt Alkan";
            personel.CalisanMaas = 4500.32;
            personel.SatisSayisi = 153;

            Console.WriteLine("Yönetici No: {0} Adı: {1} Maaşı: {2}, Departman Karı: {3}", yonetici.CalisanNo.ToString(), yonetici.CalisanAd.ToString(), yonetici.CalisanMaas.ToString(), yonetici.DepartmanKar.ToString());
            Console.WriteLine("Personel No: {0} Adı: {1} Maaşı: {2}, Satış Sayısı: {3}", personel.CalisanNo.ToString(), personel.CalisanAd.ToString(), personel.CalisanMaas.ToString(), personel.SatisSayisi.ToString());

            Console.Read();
        }
    
    }
}
