

using FirstClass;

Person student1 = new Person(); //yeni öğrenci oluşturma
student1.FirstName = "Zeynep";
student1.LastName = "Çakır";
student1.BirthDate = new DateTime(2001, 11, 6);

Person teacher1 = new Person("Ertan", "Bozkuş", DateTime.Now); // yeni öğretmen oluşturma

student1.PrintInfo(); //method çağırarak bilgileri yazdırma
teacher1.PrintInfo();
