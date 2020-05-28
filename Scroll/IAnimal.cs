using System;
using System.Collections.Generic;
using System.Text;

namespace Scroll
{
    public interface IAnimal
    {
        string NomeAnimal { get; set; }
        string Movimentar();
        string EmitirSom();
    }
}
