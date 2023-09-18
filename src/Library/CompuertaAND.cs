using System;
using System.Collections.Generic;


namespace Library
{
    // Subclase para la compuerta AND
    public class CompuertaAND : Compuerta
    {
        private List<Compuerta> entradas = new List<Compuerta>();

        public void AgregarEntrada(Compuerta entrada)
        {
            entradas.Add(entrada);
        }

        public override bool Calcular()
        {
            // Realizar la operación lógica AND en las entradas
            bool resultado = true;
            foreach (var entrada in entradas)
            {
                resultado = resultado && entrada.Calcular();
            }
            return resultado;
        }
    }  
}