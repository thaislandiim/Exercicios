using System;

class identificarParOuImpar 
{
  public static void Main (string[] args) 
  {
    int numero;

    Console.WriteLine("Digite um número");
    numero = Convert.ToInt32(Console.ReadLine());

    if(numero % 2 == 0) {
      Console.WriteLine("Este número é par");
    }
    else {
      Console.WriteLine("Este número é impar");
    }
  }
}
