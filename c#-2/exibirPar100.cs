using System;

class exibirPar100 
{
  public static void Main (string[] args) 
  {
    int inicializador;

    for(inicializador = 1; inicializador <= 100; inicializador++) {
      if(inicializador % 2 == 0) {
        Console.WriteLine(inicializador);
      }
    }
  }
}