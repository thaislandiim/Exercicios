n1 = input("Digite sua 1° nota: ")
n2 = input("Digite sua 2° nota: ")
n3 = input("Digite sua 3° nota: ")
n4 = input("Digite sua 4° nota: ")

total = int(n1) + int(n2) + int(n3) + int(n4)
media = int(total) / 4

if media >= 6:
  print("Você foi aprovado")
elif media >= 4:
  print("Você está de recuperação")
else:
  print("Você foi reprovado")