using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public required string Name { get; set; }
        public int Age { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Name}, \n e tenho {Age} anos");
        }
    }
}