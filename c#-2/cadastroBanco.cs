using System;

class cadastroBanco 
{
  public static void Main (string[] args) 
  {
    string nome, cep, endereco, cidade, rg;

    Console.WriteLine("Digite o seu nome");
    nome = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Digite o seu CEP");
    cep = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Digite o seu endereço");
    endereco = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Digite o nome da sua cidade");
    cidade = Convert.ToString(Console.ReadLine());
    
    Console.WriteLine("Digite seu RG");
    rg = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Seu cadastro foi feito com os seguintes dados " + nome + cep + endereco + cidade + rg);
  }
}