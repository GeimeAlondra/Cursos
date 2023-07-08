# Set

planetas = {'Marte', 'Júpiter', 'Venus'}
print(planetas)

# Longitud del set

print(len(planetas))

# Revisar si un elemento está presente

print('Marte' in planetas)

# Agregar un elemento

planetas.add('Tierra')
print(planetas)

# No se pueden duplicar elementos

planetas.add('Tierra')
print(planetas)

# Eliminar elemento posiblemente arrojando un error

planetas.remove('Tierra')
print(planetas)

# Eliminar elemento sin arrojar error

planetas.discard('Júpiters')
print(planetas)

# Limpiar set

planetas.clear()
print(planetas)

# Eliminar set

del planetas
print(planetas)