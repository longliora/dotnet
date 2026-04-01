using System;
namespace Application {
  class Program {
    static void Main(string[] args) {
     
      Console.WriteLine("Hello World!");

      Box<int> box1 = new Box<int>();
      box1.Value = 100;
      Box<string> box2 = new Box<string>();
      
      box2.Value = "ASP.NET Core";
      Console.WriteLine(box1.Value);
      Console.WriteLine(box2.Value);

      Box<Student> box3 = new Box<Student>();
      box3.Value = new Student { Id = 123, Name = "John" };


      Repository<Student> studentRepo = new Repository<Student>();
      studentRepo.Add(new Student { Id = 1, Name = "An" });
      studentRepo.Add(new Student { Id = 2, Name = "Bình" });
      foreach (var s in studentRepo.GetAll()) {
        Console.WriteLine($"{s.Id} - {s.Name}");
        }

          }
      }
}