using System;

class Program {
  public static void Main (string[] args) {
    int[] x = new int[10];
    int i;
    for(i = 0; i < 10; i++){
      x[i] = 2 - i;
    }

    for(i=0; i<10; i++){
      if(x[i] <= 0){
        x[i] = 1;
        Console.WriteLine($"x[{i}] = {x[i]}");
      }
      else{
        Console.WriteLine($"x[{i}] = {x[i]}");
      }
      
    }
  }
}