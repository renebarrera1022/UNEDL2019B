package ExamenPrimerParcial;

public class Calculadora {
    private float resultado;

    public Calculadora(Habitacion habitacion, Tapiz tapiz) {
        resultado =  (habitacion.getArea() * tapiz.getCost());
    }

    public double getTotalCost() {
        return resultado;
    }

}
