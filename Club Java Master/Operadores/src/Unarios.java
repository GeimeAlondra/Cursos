public class Unarios {
    public static void main(String[] args) {

        // Operadores unarios
        int a = 3, b = -2, resultado = 0;

        // Operador unario -
        resultado = -a;
        System.out.println("-a = " + resultado);
        resultado = -b;
        System.out.println("-b = " + resultado);

        // Operador unario ++ (incremento)
        a = 3;
        resultado = ++a; // pre-incremento
        System.out.println("Pre-incremento ++a = " + resultado);
        a = 3;
        resultado = a++; // post-incremento
        System.out.println("Post-incremento a++ = " + resultado);
        System.out.println("a = " + a);

        // Operador unario -- (decrementa en uno)
        b = -2;
        resultado = --b; // pre-decremento
        System.out.println("Pre-decremento --b = " + resultado);
        b = -2;
        resultado = b--; // post-decremento
        System.out.println("Post-decremento b-- = " + resultado);
        System.out.println("b = " + b);

        // Negación ! (invierte el valor logico)
        var c = true;
        var resultado2 = !c;
        System.out.println("Negacion !c = " + resultado2);
    }
}
