n1 = input("Digite sua 1° nota: ")
n2 = input("Digite sua 2° nota: ")
n3 = input("Digite sua 3° nota: ")
n4 = input("Digite sua 4° nota: ")

media = int(n1) + int(n2) + int(n3) + int(n4)
total = int(media) / 4

total = int(media) / 4
if total >= 6:
  print("Você foi aprovado")
elif total >= 4 and total <= 6:
  print("Você está de recuperação")
else:
  print("Você foi reprovado")