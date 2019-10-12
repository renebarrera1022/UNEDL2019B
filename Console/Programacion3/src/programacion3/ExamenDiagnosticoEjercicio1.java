//René Alejandro Barrera Ramírez
package programacion3;

public class ExamenDiagnosticoEjercicio1 {
    private int cont = 1;
    private int cont2 = 0;
    private int cont3 = 0;
    public void cargar() {
        int matriz[][] = {{1, 3, 5, 7}, {4, 7, 9, 7}, {2, 6, 8, 0}, {2, 4, 5, 2}};
        for (int i = 0; i < 1;) {
            if(cont==1){
               for(int j=0;j<4;j++){
                   System.out.print(matriz[j][cont3]);
               }
               cont=0;
               cont3++;
            }else{
                for(int k=3;k>=0;k--){
                    System.out.print(matriz[k][cont3]);
                }
                 cont3++;
                 cont=1;
            }
            cont2++;
            if(cont2==4){
                i++;
            }
        }
    }
    public static void main(String[] args) {
        ExamenDiagnosticoEjercicio1 ref = new ExamenDiagnosticoEjercicio1();
        ref.cargar();
    }
}
