using System;
using System.Collections.Generic;



namespace Library
{
    // Subclase para la compuerta NOT
    public class CompuertaNOT : Compuerta
    {
        private Compuerta entrada;

        public CompuertaNOT(Compuerta entrada)
        {
            this.entrada = entrada;
        }

        public override bool Calcular()
        {
            // Realizar la operación lógica NOT en la entrada
            return !entrada.Calcular();
        }
    }
        
}
