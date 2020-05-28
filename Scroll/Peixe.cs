using System;
using System.Collections.Generic;
using System.Text;

namespace Scroll
{
    public class Peixe : Animal, INadador
    {

        public bool TenhoGuelra = true;

        public Peixe()
        {
            this.NomeAnimal = "Piranha";
        }
        
        public new string Movimentar()
        {
            return "peixe nadando";
        }

        public string Nada()
        {
            var movimentar = Movimentar();
            movimentar += "peixamente";
            return movimentar;
        }

        public override string EmitirSom()
        {
            return "glub glub";
        }
    }
}
