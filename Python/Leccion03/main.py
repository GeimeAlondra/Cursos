condicion = True

# Version general
if condicion == True:
    print('Condición verdadera')
elif condicion == False:
    print('Condición falsa')
else:
    print('Condición no reconocida')

# Version simplificada
if condicion:
    print('Condición verdadera')
else:
    print('Condición falsa')

print('Condición verdadera') if condicion else print('Condición falsa')