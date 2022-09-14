nome = input("Digite o nome do produto: ")
preco = input(f"Digite o preço do {nome}: ")
desconto = input("Digite o desconto: ")

if desconto == 0:
  print(f"O valor do {nome} foi de {preco}")
else:
  total = float(preco) - (float(preco) * (float(desconto) / 100))
  print(f"O valor total da compra foi de {total}")