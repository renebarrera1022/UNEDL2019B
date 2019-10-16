package OperadoresVisual;
import javax.swing.JOptionPane;

public class OperadoresV {

    private float valor1;
    private float valor2;
    private String operador;
    private float res;
    private boolean res2;

    public void setOperadores(String valor1, String valor2, String operador) {
        this.valor1 = Float.parseFloat(valor1);
        this.valor2 = Float.parseFloat(valor2);
        this.operador = operador;

        switch (operador) {
            case "+":
                res = this.valor1 + this.valor2;
                System.out.println("Elegiste el operador aritmético '+'");
                System.out.println("La suma " + this.valor1 + " + " + this.valor2 + " es: " + res);
                break;
            case "-":
                res = this.valor1 - this.valor2;
                System.out.println("Elegiste el operador aritmético '-'");
                System.out.println("La resta " + this.valor1 + " - " + this.valor2 + " es: " + res);
                break;
            case "*":
                res = this.valor1 * this.valor2;
                System.out.println("Elegiste el operador aritmético '*'");
                System.out.println("La multiplicación " + this.valor1 + " * " + this.valor2 + " es: " + res);
                break;
            case "/":
                res = this.valor1 / this.valor2;
                System.out.println("Elegiste el operador aritmético '/'");
                System.out.println("La división " + this.valor1 + " / " + this.valor2 + " es: " + res);
                break;
            case "%":
                res = this.valor1 % this.valor2;
                System.out.println("Elegiste el operador aritmético '%'");
                System.out.println("El residuio " + this.valor1 + " % " + this.valor2 + " es: " + res);
                break;
        }
    }

    public boolean setOperadores2(String valor1, String valor2, String operador) {
        res2 = false;
        this.valor1 = Float.parseFloat(valor1);
        this.valor2 = Float.parseFloat(valor2);
        this.operador = operador;

        switch (operador) {
            case "<":
                if (this.valor1 < this.valor2) {
                    res2 = true;
                }
                break;
            case ">":
                if (this.valor1 > this.valor2) {
                    res2 = true;
                }
                break;
            case "<=":
                if (this.valor1 <= this.valor2) {
                    res2 = true;
                }
                break;
            case ">=":
                if (this.valor1 >= this.valor2) {
                    res2 = true;
                }
                break;
            case "==":
                if (this.valor1 == this.valor2) {
                    res2 = true;
                }
                break;
            case "!=":
                if (this.valor1 != this.valor2) {
                    res2 = true;
                }
                break;
            case "&&":
                JOptionPane.showMessageDialog(null, "La condición será: si ambos número son mayores a 10");
                if (this.valor1 > 10 && this.valor2 > 10) {
                    res2 = true;
                }
                break;
            case "||":
                JOptionPane.showMessageDialog(null, "La condición será: si uno de los dos número es mayor a 10");
                if (this.valor1 > 10 || this.valor2 < 10) {
                    res2 = true;
                }
                break;
        }
        return res2;
    }
}