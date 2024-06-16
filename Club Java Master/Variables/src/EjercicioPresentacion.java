import java.util.Scanner;

public class EjercicioPresentacion {
    public static void main(String[] args) {

        var consola = new Scanner(System.in);
        System.out.println("*** Presentación ***");
        System.out.print("Nombre: ");
        var nombre = consola.nextLine();
        System.out.print("Edad: ");
        var edad = Integer.parseInt(consola.nextLine());
        System.out.print("¿Hijo único? ");
        var hijoUnico = Boolean.parseBoolean(consola.nextLine());
        System.out.print("Bebida favorita: ");
        var bebidaFavorita = consola.nextLine();
        System.out.print("Precio bebida favorita: ");
        var precioBebida = Float.parseFloat(consola.nextLine());

        // Imprimir valores
        System.out.println("Valores recibidos ");
        System.out.println("Nombre: " + nombre);
        System.out.println("Edad: " + edad);
        System.out.println("Hijo único: " + hijoUnico);
        System.out.println("Bebida favorita: " + bebidaFavorita);
        System.out.println("Precio bebida favorita: " + precioBebida);
    }
}
