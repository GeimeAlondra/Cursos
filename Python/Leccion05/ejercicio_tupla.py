# Dada la siguiente tupla, crear una lista que sólo incluya los números menores a 5

tupla = (13, 1, 8, 3, 2, 5, 8)

# Definir lista
lista = []

# Filtramos lso elementos menores a 5 en la tupla
for elemento in tupla:
    if elemento < 5:
        lista.append(elemento)

# Imprimimos la lista
print(lista)
