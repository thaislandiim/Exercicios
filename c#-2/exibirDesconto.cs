using System;

class exibirDesconto 
{
  public static void Main (string[] args) 
  {
    string nome;
    double preco, desconto, total;

    Console.WriteLine("Digite o nome do seu produto");
    nome = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Digite o preço do seu produto");
    preco = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("O desconto do produto é de");
    desconto = Convert.ToDouble(Console.ReadLine());

    if(desconto == 0) {
      Console.WriteLine("O " + nome + " o valor do produto foi " + preco);
    }
    else {
      total = preco - (preco * (desconto / 100));
      Console.WriteLine("O " + nome + " o valor total da compra foi de " + total);
    }
  }
}