import java.util.Scanner;

public class IntroducirValoresConsola {
    public static void main(String[] args) {
        // Introducir valores por consola
        Scanner consola = new Scanner(System.in); // in - input - entrada de datos
        System.out.println("Escribe tu nombre: ");
        var nombre = consola.nextLine();
        System.out.println("nombre: " + nombre);
    }
}
