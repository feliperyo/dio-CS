// FOR

// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// WHILE

// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }

// DO WHILE

int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while (numero != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");