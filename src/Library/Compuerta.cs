using System;
using System.Collections.Generic;

namespace Library
{
    // Clase base para todas las compuertas lógicas
    public class Compuerta
    {
        public virtual bool Calcular() { return false; }
    }   
}