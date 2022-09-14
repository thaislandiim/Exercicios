nome = input("Digite o nome do produto: ")
preco = input("Digite o preço do produto: ")
quantidade = input(f"Digite a quantidade de {nome} que você deseja: ")

if quantidade == 0:
  print(f"O valor total da compra de {nome} foi de {preco}")
else:
  total = int(preco) * int(quantidade)
  print(f"O valor total da compra de {quantidade} {nome} foi de {total}")