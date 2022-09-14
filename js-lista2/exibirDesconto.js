let produto = prompt("Digite o nome do produto: ");
let preco = prompt("Digite seu o preço do produto: ");
let desconto = prompt("Digite a desconto: ");

if(desconto == 0) {
  console.log("O valor total do " + produto + " foi de " + preco);
} else { 
  let total = Number(preco) - (Number(preco) * (Number(desconto) / 100));
  console.log("O valor foi de: " + total);
}