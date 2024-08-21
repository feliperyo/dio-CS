
int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


//Redimensionando o Array
// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

Console.WriteLine("Percorrendo o Array com FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº{contador} - {arrayInteiros[contador]}");
}

Console.WriteLine("Percorrendo o Array com FOREACH");
foreach (int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}