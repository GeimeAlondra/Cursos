edadAdulto = 18

edad = int(input('Escribe tu edad: '))

if edad >= edadAdulto:
    print(f'La persona con edad {edad} es un adulto')
else:
    print(f'La persona con edad {edad} es menor de edad')