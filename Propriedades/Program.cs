﻿using Propriedades.Models;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);





// Pessoa p1 = new Pessoa("Felipe", "Ryo");

// (string name, string surname) = p1;

// Console.WriteLine($"{name} {surname}");



// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine("Quantidade linhas do arquivo:" + quantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {

//     Console.WriteLine("Não foi possível ler o arquivo.");
// }



// Pessoa p1 = new Pessoa(name: "Felipe", surname: "Ryo");
// Pessoa p2 = new Pessoa(name: "Natasha", surname: "Dialetachi");

// Curso englishCourse = new Curso();
// englishCourse.Name = "Inglês";
// englishCourse.Students = new List<Pessoa>();

// englishCourse.AddStudent(p1);
// englishCourse.AddStudent(p2);
// englishCourse.ListStudents();


// p1.Age = 29;
// p1.Apresentar();