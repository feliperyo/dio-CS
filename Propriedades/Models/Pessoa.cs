using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades.Models
{
    public class Pessoa
    {

        public Pessoa()
        {

        }
        public Pessoa(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        private string _name;
        private int _age;
        public string Name
        {
            get => _name;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }

                _name = value;
            }
        }

        public string Surname { get; set; }

        public string FullName => $"{Name} {Surname}".ToUpper();

        public int Age
        {
            get => _age;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _age = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {FullName}, Idade: {Age}");
        }
    }
}