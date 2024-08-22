using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades.Models
{
    public class Curso
    {
        public string Name { get; set; }
        public List<Pessoa> Students { get; set; }


        public void AddStudent(Pessoa student)
        {
            Students.Add(student);
        }

        public int StudentQuantity()
        {
            int quantity = Students.Count;
            return quantity;
        }

        public bool RemoveStudent(Pessoa student)
        {
            return Students.Remove(student);
        }

        public void ListStudents()
        {
            Console.WriteLine($"Alunos do curso de: {Name}");

            for (int count = 0; count < Students.Count; count++)
            {
                // string text = "Nº " + count + " - " + Students[count].FullName;
                string text = $"Nº {count + 1} - {Students[count].FullName}";
                Console.WriteLine(text);
            }
        }
    }
}