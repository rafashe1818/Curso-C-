using System;

class Program {
  public static void Main (string[] args) {
  int [,] m = new int [,]{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12},
    };

    int i;
    int j;

    for(i = 0; i < 12; i++){
      for(j = 0; j < 12; j++){
        m[i, j] = i + j;
        Console.WriteLine($"m[{i},{j}] = {m[i, j]}");
        }
      }
  }
}