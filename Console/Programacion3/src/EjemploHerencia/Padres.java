package EjemploHerencia;

public class Padres {

    protected float estatura;
    protected float peso;
    protected String colorPiel;
    protected String colorOjos;
    protected String colorCabello;

    public Padres() {//Estado inicial de los atributos
        estatura = 1.65f;
        peso = 67;
        colorPiel = "causcasica";
        colorOjos = "cafe";
        colorCabello = "castaño";
    }

    public void setEstatura(float estatura) {
        this.estatura = estatura;
    }

    public float getEstatura() {
        return estatura;
    }

    public void setPeso(float peso) {
        this.peso = peso;
    }

    public float getPeso() {
        return peso;
    }

    public void setColorPiel(String colorPiel) {
        this.colorPiel = colorPiel;
    }

    public String getColorPiel() {
        return colorPiel;
    }

    public void setColorOjos(String colorOjos) {
        this.colorOjos = colorOjos;
    }

    public String getColorOjos() {
        return colorOjos;
    }

    public void setColorCabello(String colorCabello) {
        this.colorCabello = colorCabello;
    }

    public String getColorCabello() {
        return colorCabello;
    }
}
