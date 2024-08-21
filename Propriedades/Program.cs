using Propriedades.Models;

Pessoa p1 = new Pessoa();

p1.Name = "Felipe";
p1.Surname = "Ryo";

Pessoa p2 = new Pessoa();

p2.Name = "Natasha";
p2.Surname = "Dialetachi";

Curso englishCourse = new Curso();
englishCourse.Name = "Inglês";
englishCourse.Students = new List<Pessoa>();

englishCourse.AddStudent(p1);
englishCourse.AddStudent(p2);
englishCourse.ListStudents();




// p1.Age = 29;

// p1.Apresentar();