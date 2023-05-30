Algoritmo OperadoresLogicos
	a = Falso
	b = Verdadero
	Imprimir 'Valor a: ', a
	Imprimir 'Valor b: ', b
	
	// Operador logico Y
	// Regresa verdadero si ambos oprenandos son verdaderos
	c = a Y b
	Imprimir 'Expresion evaluar (Y): ', a, ' Y ', b
	Imprimir 'Resultado Operador Y (AND): ', c
	
	// Operador logico O
	// Regresa verdadero si cualquier operando es verdadero
	c = a O b
	Imprimir 'Expresion evaluar (O): ', a, ' Y ', b
	Imprimir 'Resultado Operador O (OR): ', c
	
	// Operador logico NO
	// Invierte el valor del operando
	c = NO a
	Imprimir 'Expresion evaluar (NO): ', a
	Imprimir 'Resultado Operador NO (NOT): ', c
	
FinAlgoritmo
