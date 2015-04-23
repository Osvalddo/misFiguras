using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace misFiguras
{
    class Triangulo
    {
        // Primero defino atributos
        private double lado1;
        private double lado2;
        private double lado3;
        private double superficie;
        private double perimetro;
        private string tipo;

        // Propiedades de cada atributo
        public double pLado1 { set { lado1 = value; } get { return lado1; } }
        public double pLado2 { set { lado2 = value; } get { return lado2; } }
        public double pLado3 { set { lado3 = value; } get { return lado3; } }
        public double pSuperficie { set { superficie = value; } get { return superficie; } }
        public double pPerimetro { set { perimetro = value; } get { return perimetro; } }
        public string pTipo { set { tipo = value; } get { return tipo; } }

        // Constructores
        public Triangulo() //inicializador
        {
            lado1 = 0.0;
            lado2 = 0.0;
            lado3 = 0.0;
            superficie = 0.0;
            perimetro = 0.0;
            tipo = "";
        }

        public Triangulo(double Lado1, double Lado2, double Lado3)
        {
            lado1 = Lado1;
            lado2 = Lado2;
            lado3 = Lado3;
        }

        public Triangulo(double Lados)
        { lado1 = lado2 = lado3 = Lados; }

/* Métodos para el triángulo: SUPERFICIE
            Fórmula de Herón para la superficie
            1) Calcula el semiperímetro del triángulo; se suman todos los lados y se divide por 2. Este resultado será "s"
            2) Área = √{s (s - a)(s - b)(s - c)} --> siendo a, b, y c los lado1, lado2, y lado3. Esto resulta en (3), (2), y (1)
        
*/

        public double calcularSuperficie()
        {
            double sp;
            sp = (lado1 + lado2 + lado3) / 2;
            superficie = System.Math.Sqrt(sp * (sp - lado1) * (sp - lado2) * (sp - lado3));

            return superficie;
        }

/* Métodos para el triángulo: PERIMETRO
    Hay que tener en cuenta el tipo de triangulo para calcular el perímetro
    1) Equilatero, cuando todos sus lados son iguales
    2) Isosceles, cuando dos lados son iguales
    3) Escaleno, cuando todos sus lados son distintos
 * 
 */
        public double calcularPerimEquilatero()
        {
            perimetro = 3 * lado1;
            return perimetro;
        }

        public double calcularPerimEscaleno()
        {
            perimetro = lado1 + lado2 + lado3;
            return perimetro;
        }

        public double calcularPerimIsosceles()
        {
            if (lado1 == lado2) { 
                perimetro = lado1 * 2 + lado3;
                //return perimetro;
                                }
            if (lado2 == lado3) {
                perimetro = lado2 * 2 + lado1;
                //return perimetro;
                                }
            if (lado3 == lado1) {
                perimetro = lado3 * 2 + lado2;
                //return perimetro;
                                }
            return perimetro;
        }

        public string toString()
        {
            return "Éste triángulo es del tipo: " + tipo + "\n" + "\n" + "Y sus medidas son: " + lado1 + " de un lado, " + lado2 + " de otro lado y " + "\n" + lado3 + " del último lado.";
        }

    }
}
