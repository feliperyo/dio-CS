using System.Diagnostics.Contracts;
using System.Runtime.Serialization.Formatters;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");


Console.WriteLine("Percorrendo o Array com FOR");

for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição Nº{contador} - {listaString[contador]}");
}

Console.WriteLine("Percorrendo o Array com FOREACH");

int contadorForeach = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição Nº{contadorForeach} - {item}");
    contadorForeach++;
}