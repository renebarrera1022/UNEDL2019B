package Palindromo;

import java.util.Scanner;
import java.util.StringTokenizer;

public class Palindromo {
Scanner t;
String palabra;
int cont=0;
int tamanoPalabra;
int contValidar=1;
    public void validarPalindromo() {
        t = new Scanner(System.in);
        System.out.println("Ingresa una palabra para determinar si es un palíndromo: ");
        palabra = t.nextLine();
        palabra = palabra.replace(" ", "");
        tamanoPalabra = palabra.length();
        for(int i = palabra.length()-1;i>0;i--){
            if(palabra.charAt(cont) == palabra.charAt(i)){
                contValidar++;
            }
            cont++;
        }
        if(tamanoPalabra == contValidar){
            System.out.println("La palabra SI es un palindromo");
        }else{
            System.out.println("La palabra NO es un palindromo");
        }
    }

    public static void main(String[] args) {
        Palindromo ref = new Palindromo();
        ref.validarPalindromo();
    }

}
