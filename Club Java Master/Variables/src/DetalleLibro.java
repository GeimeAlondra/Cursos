import java.util.Scanner;

public class DetalleLibro {
    public static void main(String[] args) {
        Scanner consola = new Scanner(System.in);
        System.out.print("Proporciona el titulo del libro: ");
        var titulo = consola.nextLine();
        System.out.print("Proporciona le autor del libro: ");
        var autor = consola.nextLine();
        System.out.println(titulo + " " + "fue escrito por" + " " + autor);
        //var resultado = titulo + " fue escrito por " + autor;
    }
}
