using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CultureInfo culture = new CultureInfo("tr");
            //string dateFormat = "dd.mm.yyyy";

            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.Id = 1;
            bilgisayar.Marka = "Asus";
            bilgisayar.Model = "ROG";
            bilgisayar.Tipi = BilgisayarTipi.Dizustu;
            bilgisayar.GHz = 3.33;
            bilgisayar.Hafiza = 32;
            bilgisayar.EkranBoyutu = 27;
            bilgisayar.SogutmaliMi = true;
            bilgisayar.UretimTarihi = DateTime.Parse("01.03.2023");

            Console.WriteLine("Id : " + bilgisayar.Id);
            Console.WriteLine("Marka : " + bilgisayar.Marka);
            Console.WriteLine("Model :" + bilgisayar.Model);
            Console.WriteLine("tİPİ : " + bilgisayar.Tipi);
            Console.WriteLine("Ghz : " + bilgisayar.GHz);
            Console.WriteLine("Hafiza : " + bilgisayar.Hafiza);
            Console.WriteLine("Ekranboyutu : " +bilgisayar.EkranBoyutu);
            Console.WriteLine("SuSogutmaliMi : " + ( bilgisayar.SogutmaliMi ? "Var" : "Yok"));
            Console.WriteLine("Uretim Tarihi : " + bilgisayar.UretimTarihi.ToShortDateString());

            Console.Read();
        }
    }
}
