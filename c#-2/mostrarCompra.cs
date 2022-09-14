using System;

class mostrarCompra 
{
  public static void Main (string[] args) 
  {
    string nome;
    double preco, total, quantidade;

    Console.WriteLine("Digite o nome do seu produto");
    nome = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Digite o preço do seu produto");
    preco = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de produtos");
    quantidade = Convert.ToDouble(Console.ReadLine());

    if(quantidade == 1) {
      Console.WriteLine("O " + nome + " o valor do produto foi " + preco);
    }
    else {
      total = preco * quantidade;
      Console.WriteLine("O " + nome + " o valor total da compra foi de " + total);
    }
  }
}