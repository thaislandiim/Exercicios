let n1 = prompt("Digite 1° sua nota");
let n2 = prompt("Digite 2° sua nota");
let n3 = prompt("Digite 3° sua nota");
let n4 = prompt("Digite 4° sua nota");

let media = Number(n1) + Number(n2) + Number(n3) + Number(n4);
total = media / 4;

if(total >= 6) {
  console.log("Você foi aprovado");
} else if(total >= 4 && total <= 6) {
  console.log("Você está de recuperação");
} else {
  console.log("Você foi reprovado");
}