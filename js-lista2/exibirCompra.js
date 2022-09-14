let produto = prompt("Digite o nome do produto: ");
let preco = prompt("Digite seu o preço do produto: ");
let quantidade = prompt("Digite a quantidade: ");

if(quantidade == 1) {
  console.log("O valor total do " + produto + " foi de " + preco);
} else {
  let total = Number(preco) * Number(quantidade);
  console.log("O valor total da compra foi de " + total);
}