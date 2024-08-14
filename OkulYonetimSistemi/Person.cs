using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimSistemi
{
    public class Person
    {

        // Ad, Soyad ve Doğum Tarihi özellikleri tanımlanıyor
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        // Kişinin tam adını döndüren bir metod
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        // Kişinin yaşını hesaplayan bir metod
        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }


    }
}
