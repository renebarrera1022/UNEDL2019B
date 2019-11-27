using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV2doPArcial
{
    /*
     EXAMEN 2DO PARCIAL
     1. Describa en sus propias palabras el concepto de colecciones (collections) y cuales tipos existen.
          Son clases que se utilizan para el manejo de varios valores u objetos en serie (por ejemplo las pilas).
          Existen dos tipos: non-generic-collection y generic-collection
    2. Defina a que se refiere el concepto de código no seguro y que se necesita para implementarlo.
          En c# se utiliza la palabra clave unsafe para referise al código no seguro. No necesariamente es riesgoso sino que el CLR no puede comprobar su seguridad
    3. Mencione al menos tres clases que se utilizan en I/O y proporcione brevemente la idea central de las mismas.
        FileStream: Lee y escribe bytes desde y hacia un archivo.
        MemoryStream: Lee y escribe bytes desde y hacia la memoria.
        PipeStream: Lee y escribe bytes desde y hacia los procesos.
    4. Explique la diferencia entre los siguientes códigos en csharp
       a. Console.Writeline ("resultado: (*ptr) ").
          En esta línea de código se imprime el valor de la variable.
       b. Console.WriteLine("resultado: ((int)ptr)")
          En este caso imprimimos la variabe casteada a int
    5. Mencione al menos tres caracteristicas de las excepciones (Exceptions).
          1-. Es un evento inesperado en programa
          2-. Se representan mediante clases que son derivadas de la clase System.Exception
          3-. Se manejan utilizando las intrucciones try, catch, finally y thow
    6. En Java, mencione y describa los tres tipos de excepciones.
          System.IO.IOException: Es cuando existe un error de entrada y salida de datos
          System.DivideByZeroException: Es cuando dividimos un valor entre 0 y da error matemático
          System.StackOverflowException: Es cuando existe un desbordamiento de pila
    7. Explique brevemente a que se refiere con directivas para preprocesador y que se necesita para usarlas.
          Le dan instrucciones al compiladoras para que procese la información antes de iniciar con la compilacións
    8. Explique las diferencias entre ArrayList, Sorted List Hash Table.
           ArrayList:  Es un arreglo dinámico ya que nos e especifica su tamaño
           SortedList: Representa una colección de pares clave / valor que se ordenan por claves y son accesibles por clave y por índice
           HashTable: Es similar al el SortedList, pero este no los acomoda de manera ascendente
    9. Describa para que sirven StreamReader y StreamWriter
           Son clases que permiten la lectura y escritura convirtiendo bytes de información a caracteres y viceversa
    10. Explique el funcionamiento del algoritmo Quicksort
           Es un algoritmo que particiona la lista de elementos en dos partes con la ayuda de un pivote
    11. En Java, explique cuál es la diferencia entre System.out, System.in y System.err
           System.out: Es para la salida estandar de datos
           System.in: Es para el ingreso de datos
           System.err: es para la salida de errores
    12. Explique cuáles son las ventajas de utilizar "generic collections"
           La ventaja es que puede almacenar cualquier tipo de elementos
         */
    public partial class Form1 : Form
    {
        ArrayList palabras = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            palabras.Add(textBox1.Text);
            MessageBox.Show("Palabra agregada");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < palabras.Count; i++)
            {
                int cont = 0;
                for(int j=0; j<palabras.Count; j++)
                {
                    if(i != j)
                    {
                        if(palabras[i].ToString() == palabras[j].ToString())
                        {
                            palabras[j] = "0";
                            cont++;
                        }
                    }
                }
                if(cont > 0)
                {
                    if(palabras[i].ToString() != "0")
                    {
                        listBox1.Items.Add(palabras[i].ToString() + " se repite " + cont);
                    }
                }
            }
        }
    }
}
