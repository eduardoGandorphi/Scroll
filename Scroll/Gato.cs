using System;
using System.Collections.Generic;
using System.Text;

namespace Scroll
{
    public class Gato : Animal, IAndador
    {
        public Gato() : base()
        {
            this.NomeAnimal = "Gato";
        }

        public string Andar()
        {
            var movimentar = Movimentar();
            movimentar += " gatamente!";

            return movimentar;
        }

        
    }
}
