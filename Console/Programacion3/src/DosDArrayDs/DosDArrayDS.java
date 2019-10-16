/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DosDArrayDs;

import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class DosDArrayDS {

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
        int reloj = 0;
        int relojMayor = -63;

        for (int y = 0; y < 4; y++) {
            for (int x = 0; x < 4; x++) {
                reloj = arr[y][x] + arr[y][x + 1] + arr[y][x + 2]
                        + arr[y + 1][x + 1]
                        + arr[y + 2][x] + arr[y + 2][x + 1] + arr[y + 2][x + 2];

               if(reloj > relojMayor){
                   relojMayor = reloj;
               }
            }
        }
        System.out.println(relojMayor);
        return relojMayor;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter("C:\\Users\\reneb\\2DArray.txt"));

        int[][] arr = new int[6][6];

        for (int i = 0; i < 6; i++) {
            String[] arrRowItems = scanner.nextLine().split(" ");
            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

            for (int j = 0; j < 6; j++) {
                int arrItem = Integer.parseInt(arrRowItems[j]);
                arr[i][j] = arrItem;
            }
        }

        int result = hourglassSum(arr);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
