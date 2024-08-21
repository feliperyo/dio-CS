using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Name
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }

                _nome = value;
            }
        }
        public int Age { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Name}, Idade: {Age}");
        }
    }
}