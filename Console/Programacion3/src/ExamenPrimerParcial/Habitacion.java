package ExamenPrimerParcial;

import java.awt.event.KeyAdapter;

public class Habitacion {
    private float ancho;
    private float largo;
    private float area;
    public Habitacion(float ancho, float largo){
        this.ancho = ancho;
        this.largo = largo;
    }
    
    public float getArea(){
        area = ancho * largo;
        return area;
    }

}
