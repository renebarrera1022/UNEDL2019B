package OperadoresVisual;

import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

public class TestOperadoresV extends JFrame {
//Declarando los atributos del panel
    private JLabel lblValor1;
    private JLabel lblValor2;
    private JTextField txtValor1;
    private JTextField txtValor2;
    private JLabel lblOperador;
    private JComboBox cbxOperador;
    private JComboBox cbxOperador2;
    private JCheckBox chx;
    private JButton btn;

    public TestOperadoresV() {
        Font fuente = new Font("SANS_SERIF", Font.CENTER_BASELINE, 25);
        setTitle("Operadores");
        setLocation(600, 250);
        setLayout(new GridLayout(5, 2, 100, 20));
        setVisible(true);
//Instanciando los elementos del panel
        lblValor1 = new JLabel("Valor 1: ");
        lblValor2 = new JLabel("Valor 2: ");
        lblOperador = new JLabel("Operadores Aritméticos: ");
        txtValor1 = new JTextField();
        txtValor2 = new JTextField();
        cbxOperador = new JComboBox();
        cbxOperador2 = new JComboBox();
        chx = new JCheckBox();
        chx.setText("Otros: ");
        btn = new JButton("Enviar");
        cbxOperador.addItem("+");
        cbxOperador.addItem("-");
        cbxOperador.addItem("*");
        cbxOperador.addItem("/");
        cbxOperador.addItem("%");
        cbxOperador2.addItem("<");
        cbxOperador2.addItem(">");
        cbxOperador2.addItem("<=");
        cbxOperador2.addItem(">=");
        cbxOperador2.addItem("==");
        cbxOperador2.addItem("!=");
        cbxOperador2.addItem("&&");
        cbxOperador2.addItem("||");
//Agregando tipografía a los elementos
        lblValor1.setFont(fuente);
        txtValor1.setFont(fuente);
        lblValor2.setFont(fuente);
        txtValor2.setFont(fuente);
        lblOperador.setFont(fuente);
        cbxOperador.setFont(fuente);
        cbxOperador2.setFont(fuente);
        chx.setFont(fuente);
        btn.setFont(fuente);
//Deshabilitando el segundo ComboBox
        cbxOperador2.setEnabled(false);
//Evento CheckBox
        chx.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (chx.isSelected()) {
                    cbxOperador2.setEnabled(true);
                    cbxOperador.setEnabled(false);
                } else {
                    cbxOperador2.setEnabled(false);
                    cbxOperador.setEnabled(true);
                }
            }
        });
//Evento botón
        btn.addActionListener(new ActionListener() {
//Instancia de la clase Operadores para envíar los datos al método
            OperadoresV ref = new OperadoresV();

            @Override
            public void actionPerformed(ActionEvent e) {
                if (chx.isSelected()) {//Si el JCheckBox esta seleccionado se madarán los valores al segundo método
                    System.out.println(ref.setOperadores2(txtValor1.getText(), txtValor2.getText(), (String) cbxOperador2.getSelectedItem()));
                } else {//Si no esta seleccionado se enviarán al primer método
                    ref.setOperadores(txtValor1.getText(), txtValor2.getText(), (String) cbxOperador.getSelectedItem());
                }
            }
        }
        );
//Agregando los elementos al panel
        add(lblValor1);
        add(txtValor1);
        add(lblValor2);
        add(txtValor2);
        add(lblOperador);
        add(cbxOperador);
        add(chx);
        add(cbxOperador2);
        add(btn);
        pack();
    }

    public static void main(String[] args) {
        TestOperadoresV ref = new TestOperadoresV();
    }

}

