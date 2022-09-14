let n1 = prompt("Digite 1° sua nota");
let n2 = prompt("Digite 2° sua nota");
let n3 = prompt("Digite 3° sua nota");
let n4 = prompt("Digite 4° sua nota");

let total = Number(n1) + Number(n2) + Number(n3) + Number(n4);
media = total / 4;

if(media >= 6) {
  console.log("Você foi aprovado");
} else if(media >= 4) {
  console.log("Você está de recuperação");
} else {
  console.log("Você foi reprovado");
}