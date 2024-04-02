using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Cardápio");
    Console.WriteLine ("1 - Cachorro quente - R$ 4,00");
    Console.WriteLine ("2 - X-Salada - R$ 4,50");
    Console.WriteLine ("3 - X-Bacon - R$ 5,00");
    Console.WriteLine ("4 - Torrada simples - R$ 2,00");
    Console.WriteLine ("5 - Refrigerante - R$ 1,50");
    Console.WriteLine ("Digite o número do item que deseja pedir");
    double item = double.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a quantidade desejada");
    double quantidade = double.Parse(Console.ReadLine());
    double total = 0;

    if (item == 1){
    total = quantidade * 4.00;
    }
    if (item == 2){
    total = quantidade * 4.50;
    }
    if (item == 3){
    total = quantidade * 5.00;
    }
    if (item == 4){
    total = quantidade * 2.00;
    }
    if (item == 5){
    total = quantidade * 1.50;
    }
    else{
      Console.WriteLine("Item inválido");
    }
    Console.WriteLine("Total: R$ " + total.ToString("0.00"));
  }
}