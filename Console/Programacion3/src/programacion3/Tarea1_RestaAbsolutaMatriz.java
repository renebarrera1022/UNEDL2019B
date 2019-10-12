package programacion3;
import java.util.Scanner;
public class Tarea1_RestaAbsolutaMatriz {
    private Scanner t;
    private int n, x;
    private int matriz[][];
    private int diagonal1;
    private int diagonal2;
    private int res;
    public void cargar() {
        t = new Scanner(System.in);
        System.out.print("Ingresa el tamaño de la matriz: ");
        n = t.nextInt();
        x = n;
        matriz = new int[n][n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                System.out.print("Ingresa la posición [" + j + "][" + i + "] de la matriz: ");
                matriz[j][i] = t.nextInt();
                if (i == j) {
                    diagonal1 += matriz[j][i];
                }
                if(j == (x-1)){
                    x--;
                    diagonal2 += matriz[j][i];
                }
            }
        }
        System.out.println("\nLa matriz que introduciste es: ");
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                System.out.print("[ ");
                System.out.print(matriz[j][i]);
                System.out.print(" ]");
                if (j == (n - 1)) {
                    System.out.println("");
                }
            }
        }
         if(diagonal1>diagonal2){
            res = diagonal1 - diagonal2;
        }else{
            res = diagonal2 - diagonal1;
        }
        System.out.println("La suma de la primera diagonal es: " + diagonal1);
        System.out.println("La suma de la segunda diagonal es: " + diagonal2);
        System.out.println("El resultado de la diferencia absoluta es: " + res);
    }
    public static void main(String[] args) {
        Tarea1_RestaAbsolutaMatriz ref = new Tarea1_RestaAbsolutaMatriz();
        ref.cargar();
    }
}
