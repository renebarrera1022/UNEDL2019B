package PVT10_Calificaciones;

public class PVT10_JaggedArrays {

    public static void main(String[] args) {
        int[][][] arr = new int[8][][];

        for (int i = 0; i < arr.length; i++) {
            arr[i] = new int[10][5];
            for (int j = 0; j < arr[i].length; j++) {
                System.out.println("-------------------------------------");
                for (int k = 0; k < arr[i][j].length; k++) {
                    System.out.println("Semestre: " + (i+1));
                    System.out.println("Alumno: " + (j+1));
                    System.out.println("Calificación " +( k+1) + ": " + (int)((Math.random() * 50) + 50));
                }
                System.out.println("-------------------------------------");
                System.out.println("");
            }
        }
    }
}
