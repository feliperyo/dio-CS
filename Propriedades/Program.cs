using Propriedades.Models;

Pessoa p1 = new Pessoa(name: "Felipe", surname: "Ryo");
Pessoa p2 = new Pessoa(name: "Natasha", surname: "Dialetachi");

Curso englishCourse = new Curso();
englishCourse.Name = "Inglês";
englishCourse.Students = new List<Pessoa>();

englishCourse.AddStudent(p1);
englishCourse.AddStudent(p2);
englishCourse.ListStudents();




// p1.Age = 29;
// p1.Apresentar();