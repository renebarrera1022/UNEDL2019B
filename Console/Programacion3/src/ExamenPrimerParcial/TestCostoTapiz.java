package ExamenPrimerParcial;

public class TestCostoTapiz {

    public static void main(String[] args) {
        Habitacion habitacion = new Habitacion(2.75f,4.0f);
        Tapiz tapiz = new Tapiz(3.5f);
        Calculadora cal = new Calculadora(habitacion,tapiz);
        System.out.println("El área de la habitación es: " + habitacion.getArea());
        System.out.println("El costo del tapiz es  por metro cuadrado es: " + tapiz.getCost());
        System.out.println("Total = " + cal.getTotalCost());
    }
    
    
}
