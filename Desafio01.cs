using System;
class Program {
  static void Main(){
    Console.WriteLine("Digite a quantidade de tempo: ");
    float tempo = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite a velocidade: ");
    float velocidade = int.Parse(Console.ReadLine());
    float distancia = tempo * velocidade;
    float litros = distancia / 12;
    Console.WriteLine("Quantidade de litros por hora gasto é: " + litros.ToString("0.00"));
    }
  }
    