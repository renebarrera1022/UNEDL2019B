using System;
using System.Collections;
using System.Collections.Generic;

namespace PV2doParcial
{
    public class Program
    {
        static void Main(string[] args)
        {
        Stack<string> pila = new Stack<string>(); ;
        String validar;

             do
             {
                 Console.WriteLine("Para salir presiona la tecla 0");
                 Console.WriteLine("Ingresa los paréntesis y/o corchetes de una ecuación: ");
                 validar = Console.ReadLine();
                 if (validar == ")" || validar == "}" || validar == "]")
                 {
                     pila.Push(validar);
                 }
                 else if (validar == "[")
                 {
                     for (int i = 0; i < pila.Count; i++)
                     {
                         if (pila.Contains("]"))
                         {
                             pila.remove(i);
                         }
                     }
                 }
                 else if (validar == "{")
                 {
                     for (int i = pila.Count; i >= 0; i--)
                     {
                         if (pila.Get(i) == "}")
                         {
                             pila.Pop();
                         }
                     }
                 }
                 else if (validar == "(")
                 {
                     for (int i = 0; i < pila.Count; i++)
                     {
                         if (pila.get(i) == ")")
                         {
                             pila.remove(i);
                         }
                     }
                 }
                 else if (validar != "0")
                 {
                     Console.Write("Valor inválido");
                 }
             } while (validar != "0");
             if (pila.Count >= 1)
             {
                 Console.Write("--------------- SISTEMA INCONGRUENTE ---------------");
             }
             else
             {
                 Console.Write("--------------- SISTEMA CONGRUENTE ---------------");
             }
        }
    }
}
