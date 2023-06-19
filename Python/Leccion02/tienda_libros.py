print('Proporcione los siguientes datos del libro:')

nombre = input('Proporciona el nombre: ')
id = int(input('Proporciona el ID: '))
precio = float(input('Proporciona el precio: '))
envio = input('Indica si el envio es gratuito (True/False): ')

if envio == 'True':
    envio = True
elif envio == 'False':
    envio = False
else:
    envio = 'Valor incorrecto, debe escribir True o False'

print(f'''
    Nombre: {nombre}
    ID: {id}
    Precio: {precio}
    Envio gratuito?: {envio}
''')
