package EJ1_RecorridoMatriz;


public class EJ1_RecorridoMatriz {

    public static void main(String[] args) {
        int[][] myMatriz = {{1,3,5,7},{4,7,9,7},{2,6,8,0},{2,4,5,2}};
        
        for(int i=0; i< myMatriz.length;i++){
            for(int j=0; j<myMatriz[i].length;j++){
                if(i % 2 == 0){
                    System.out.print(myMatriz[j][i]);
                }else{
                    System.out.print(myMatriz[myMatriz.length -j - 1][i]);
                }
            }
        }
        
    }
    
}
