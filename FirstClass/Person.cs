using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Person         //Person isminde sınıf oluşturuldu
    {

        public string FirstName { get; set; } //ad soyad doğum tarihi özellikleri
        public string LastName { get; set; } //soyadın değerini döndür ve set ile değer atama
        public DateTime BirthDate { get; set; }

        
        public Person(string firstName, string lastName, DateTime birthDate) // new person oluşum işlemini tek satırda yapmayı amaçladığım için parametreli bir constructer oluşturdum
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public Person() { } // new person oluşturma işlemini çok satırda yaparken kullanmak için

        
        public void PrintInfo() // oluşan personların bilgilerini ekrana yazdıran method
        {
            Console.WriteLine($"Ad: {FirstName}, Soyad: {LastName}, Doğum Tarihi: {BirthDate.ToShortDateString()}");
        }


     
    }
}
