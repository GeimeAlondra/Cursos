# Definir una lista de tipo string

nombres = ['Juan', 'Karla', 'Ricardo', 'María']
print(nombres)

# Acceder a los elementos de una lista

print(nombres[0])
print(nombres[1])
print(nombres[2])
print(nombres[3])

# Acceder a los elementos de una lista de manera inversa

print(nombres[-1])
print(nombres[-2])
print(nombres[-3])
print(nombres[-4])

# Imprimir un rango (sin incluir el indice 2)

print(nombres[0:2])

# Ir del inicio de la lista al indice (sin incluirlo)

print(nombres[:3])

# Desde el indice indicado hasta el final

print(nombres[1:])

# Cambiar un valor

nombres[3] = 'Ivonne'
print(nombres)

# Iterar una lista

for nombre in nombres:
    print(nombre)
else:
    print('No existen mas nombres en la lista')

# Preguntar el largo de una lista

print(len(nombres))

# Agregar un elemento

nombres.append('Lorenzo')
print(nombres)

# Insertar un elemento en un indice en especifico

nombres.insert(1, 'Octavio')
print(nombres)

# Remover un elemento

nombres.remove('Octavio')
print(nombres)

# Remover el ultimo valor agregado

nombres.pop()
print(nombres)

# Eliminar un indice

del nombres[0]
print(nombres)

# Limpiar la lista

nombres.clear()
print(nombres)

# Borrar la lista por completo

del nombres
print(nombres)
