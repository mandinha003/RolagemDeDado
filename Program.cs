using System.Security.Cryptography;
int faces, sorteado;

Console.WriteLine("--- Rolagem de Dados --- \n");

Console.Write(" Quantidade de Faces? ");
faces = Convert.ToInt32(Console.ReadLine());
sorteado = RandomNumberGenerator.GetInt32(1, faces + 1);

Console.Write($"\n Rolagem {sorteado}");




