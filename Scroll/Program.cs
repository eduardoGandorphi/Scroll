using System;
using System.Collections.Generic;

namespace Scroll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animais = new List<IAnimal>();

            //Animal pet = new Animal();
            //animais.Add(pet);
            

            IAnimal aquatico = new Peixe();            
            Peixe SeiQualAquatico = (Peixe) aquatico;
            SeiQualAquatico.TenhoGuelra = true;
            animais.Add(aquatico);

            IAnimal terrestre = new Gato();
            Gato SeiQualTerrestre = (Gato)terrestre;
            animais.Add(terrestre);

            foreach (IAnimal animal in animais)
            {
                animal.EmitirSom();
                if (animal is INadador)
                {
                    INadador nadador = (INadador)animal;
                    Console.WriteLine(nadador.Nada());

                    Peixe piranha = (Peixe)animal;
                    Console.WriteLine(piranha.Movimentar());

                }

                if (animal is IAndador)
                {
                    IAndador andador = (IAndador)animal;
                    Console.WriteLine(andador.Andar());
                }

                if (animal is IAnimal)
                {
                    IAnimal animalCastado = (IAnimal)animal;
                    Console.WriteLine(animalCastado.Movimentar());
                }


                Console.WriteLine("\n\n");
            }
        }
    }
}
