using System;
using System.Collections;
using System.Collections.Generic;

namespace PV2doParcial
{
    public class Program
    {
        static void Main(string[] args)
        {
        Stack pila = new Stack(); ;
        String validar;
                 Console.WriteLine("Ingresa los paréntesis y/o corchetes de una ecuación: ");
                 validar = Console.ReadLine();
                 foreach(char i in validar)
                {
                    if(i == '[' || i == '{' || i =='(')
                    {
                        pila.Push(i);
                    }
                    else if(pila.Count > 0)
                    {
                        if(i == ')')
                        {
                            pila.Pop();
                        }
                        else if (i == '}')
                        {
                            pila.Pop();
                        }
                        else if (i == ']')
                        {
                            pila.Pop();
                        }
                    }
                }
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
