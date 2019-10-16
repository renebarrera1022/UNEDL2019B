package InicioDeCurso;

public class ExamenDiagnosticoEjercicio2 {

    private String marca;
    private boolean vacio;
    private final String COMMA = ",";
    StringBuffer r;

    public void prueba(String hostname) {
        r = new StringBuffer();
        String[] nodos = {"mercurio", "venus", "tierra", "marte", "jupiter", "saturno", "undedl", "neptuno", "pluton", "urano"};
        System.out.println("hostname: " + hostname);

        for (int i = 0; i < nodos.length; i++) {
            r.append("planeta:");
            r.append(nodos[i]);
            r.append(COMMA);
            System.out.println("nodos: " + nodos[i]);
            if (i==5) {
                r.append("universo:");
            }
        }
        System.out.println("\n Contendio: " + r);
    }

    public static void main(String[] args) {
        ExamenDiagnosticoEjercicio2 ref = new ExamenDiagnosticoEjercicio2();
        String hostname = "unedl";
        ref.prueba(hostname);
    }

}
