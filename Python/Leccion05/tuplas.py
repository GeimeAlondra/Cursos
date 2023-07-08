# Definir una tupla

frutas = ('Naranja', 'Platano', 'Guayaba')
print(frutas)

# Saber el largo

print(len(frutas))

# Acceder a un elemento

print(frutas[0])

# Navegacion inversa

print(frutas[-1])

# Acceder a un rango (sin incluir el ultimo indice)

print(frutas[0:1])

# Recorrer elementos

for fruta in frutas:
    print(fruta, end=' ')

# Cambiar un valor de la tupla (esto no se puede hacer)

#fruta[0] = 'Pera'
#print(frutas)

# Cambiar una tupla a una lista

frutasLista = list(frutas)
frutasLista[0] = 'Pera'
frutas = tuple(frutasLista)
print('\n', frutas)

# Eliminar la tupla

del frutas
print(frutas)
