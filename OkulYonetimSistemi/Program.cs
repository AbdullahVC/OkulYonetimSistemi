using System;

namespace OkulYonetimSistemi
{
    class Program 
    {

        static void Main(string[] args)
        {
            // Öğrenci nesneleri oluşturuluyor
            Person student1 = new Person()
            {
                FirstName = "Ali",
                LastName = "Yılmaz",
                BirthDate = new DateTime(2005, 5, 21)
            };

            Person student2 = new Person()
            {
                FirstName = "Ayşe",
                LastName = "Demir",
                BirthDate = new DateTime(2006, 11, 14)
            };

            // Öğretmen nesneleri oluşturuluyor
            Person teacher1 = new Person()
            {
                FirstName = "Mehmet",
                LastName = "Kara",
                BirthDate = new DateTime(1980, 2, 10)
            };

            Person teacher2 = new Person()
            {
                FirstName = "Fatma",
                LastName = "Çelik",
                BirthDate = new DateTime(1985, 8, 25)
            };

            // Bilgiler konsola yazdırılıyor
            Console.WriteLine("Öğrenci Bilgileri:");
            Console.WriteLine($"Ad Soyad: {student1.GetFullName()}, Yaş: {student1.GetAge()}");
            Console.WriteLine($"Ad Soyad: {student2.GetFullName()}, Yaş: {student2.GetAge()}");

            Console.WriteLine("\nÖğretmen Bilgileri:");
            Console.WriteLine($"Ad Soyad: {teacher1.GetFullName()}, Yaş: {teacher1.GetAge()}");
            Console.WriteLine($"Ad Soyad: {teacher2.GetFullName()}, Yaş: {teacher2.GetAge()}");
        }



    }








}