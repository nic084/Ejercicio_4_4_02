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

        public int Peso02
        {
            get { return peso02; }
            set { peso02 = value; }
        }
        private int altura02;

        public int Altura02
        {
            get { return altura02; }
            set { altura02 = value; }
        }
        private string colorOjos02;

        public string ColorOjos02
        {
            get { return colorOjos02; }
            set { colorOjos02 = value; }
        }
        private string colorPelo02;

        public string ColorPelo02
        {
            get { return colorPelo02; }
            set { colorPelo02 = value; }
        }

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
