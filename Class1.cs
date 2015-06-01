using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_4_02
{
    public class Persona02
    {
        public Persona02(int altura, int peso, string colorOjos, string colorPelo)
        {
            this.altura02 = altura;
            this.colorOjos02 = colorOjos;
            this.colorPelo02 = colorPelo;
            this.peso02 = peso;
        }

        private int peso02;
        private int altura02;
        private string colorOjos02;
        private string colorPelo02;


        public void PonerLentillas02(string colorLentillas)
        {
            if (comprobarColor02(colorLentillas))
                this.colorOjos02 = colorLentillas;
        }

        private static bool comprobarColor02(string color)
        {
            return color.Equals("azul") || color.Equals("marron") || color.Equals("verde");
        }


        public void Engordar02(int cantidad)
        {
            int nuevo_peso = this.peso02 + cantidad;

            if ((nuevo_peso) > 180)
            {
                Console.WriteLine("Cantidad incorrecta");
            }
            else
            {
                Console.WriteLine("Incrementando del peso en {0} kg", cantidad);
                this.peso02 = nuevo_peso;
            }
        }


        public void Adelgazar02(double cantidad)
        {
            double nuevo_peso = this.peso02 - cantidad;

            if ((nuevo_peso) < 40)
            {
                Console.WriteLine("Cantidad incorrecta");
            }
            else
            {
                Console.WriteLine("Reduciendo el peso en {0} kg", cantidad);
                this.peso02 = (int)nuevo_peso;
            }
        }
    }
}
