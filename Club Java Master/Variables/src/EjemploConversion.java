import java.util.Scanner;

public class EjemploConversion {
    public static void main(String[] args) {

        // Conversion de tipos de datos
        var consola = new Scanner(System.in);

        System.out.print("Numero 1: ");
        var numero1 = consola.nextLine();

        System.out.print("Numero 2: ");
        var numero2 = consola.nextLine();

        var resultado = Integer.parseInt(numero1) + Integer.parseInt(numero2);
        System.out.println("resultado = " + resultado);

        // var concatenacion = numero1 + numero2;
        // System.out.println("concatenacion = " + concatenacion);
    }
}
