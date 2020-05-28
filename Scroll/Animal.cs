using System;
using System.Collections.Generic;
using System.Text;

namespace Scroll
{
    public abstract class Animal : IAnimal
    {
        private string nomeAnimal;
        public string NomeAnimal
        {
            get { return nomeAnimal; }
            set { nomeAnimal = value; }
        }

        public Animal()
        {
            NomeAnimal = "Animal";
        }

        public string Movimentar()
        {
            return $"{NomeAnimal} se movimentando";
        }

        public virtual string EmitirSom()
        {
            return "grrrr";
        }
    }
}
