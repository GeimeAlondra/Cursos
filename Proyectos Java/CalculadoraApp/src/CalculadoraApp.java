import java.util.Scanner;

public class CalculadoraApp {
    public static void main(String[] args) {

        Scanner consola = new Scanner(System.in);

        while(true) {

            System.out.println();
            System.out.println("*** Aplicación Calculadora ***");

            // Llamamos a la funcion de mostrarMenu
            mostrarMenu();

            try {
                var operacion = Integer.parseInt(consola.nextLine());

                // Revisar que este dentro de las opciones seleccionadas
                if (operacion >= 1 && operacion <= 4) {
                    // Ejecutamos la opción deseada
                    ejecutarOperacion(operacion, consola);
                } else if (operacion == 5) { // Salir
                    System.out.println("Hasta pronto...");
                    break;
                } else {
                    System.out.println("Opción erronea: " + operacion);
                }
                // Salto
                System.out.println();
            } catch (Exception e){
                System.out.println("Ocurrió un error: " + e.getMessage());
            }
        }
    }

    private static void mostrarMenu(){
        // Mostramos el menu
        System.out.println("""
                    1. Suma
                    2. Resta
                    3. Multiplicación
                    4. División
                    5. Salir
                    """);
        System.out.println("Operación a realizar: ");
    }

    private static  void ejecutarOperacion(int operacion, Scanner consola){

        System.out.println("Proporciona valor operando1: ");
        var operando1 = Double.parseDouble(consola.nextLine());
        System.out.println("Proporciona valor operando2: ");
        var operando2 = Double.parseDouble(consola.nextLine());

        double resultado;

        switch (operacion) {
            case 1 -> {
                resultado = operando1 + operando2;
                System.out.println("Resultado Suma: " + resultado);
            }
            case 2 -> {
                resultado = operando1 - operando2;
                System.out.println("Resultado Resta: " + resultado);
            }
            case 3 -> {
                resultado = operando1 * operando2;
                System.out.println("Resultado Multiplicación: " + resultado);
            }
            case 4 -> {
                resultado = operando1 / operando2;
                System.out.println("Resultado División: " + resultado);
            }
            default -> System.out.println("Opción erronea: " + operacion);
        }
    }
}
