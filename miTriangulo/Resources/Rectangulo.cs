using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace misFiguras
{
    class Rectangulo
    {
        //atributos
        private double ladoA;
        private double ladoB;
        private double superficie;
        private double perimetro;
        private string tipo;

        // Propiedades de cada atributo
        public double pLadoA { set { ladoA = value; } get { return ladoA; } }
        public double pLadoB { set { ladoB = value; } get { return ladoB; } }
        public double pSuperficieR { set { superficie = value; } get { return superficie; } }
        public double pPerimetroR { set { perimetro = value; } get { return perimetro; } }
        public string pTipoR { set { tipo = value; } get { return tipo; } }

         // Constructores
        public Rectangulo() //inicializador
        {
            ladoA = 0.0;
            ladoB = 0.0;
            superficie = 0.0;
            perimetro = 0.0;
            tipo = "";
        }

        public double calcularSuperficieR()
        {
            //Sup = Base por Altura (a x b)
            superficie = ladoA * ladoB;
            return superficie;
        }

        public double calcularPerimetroR()
        {
            //Perimetro = la suma de sus lados, o bien 2*A + 2*B
            perimetro = (2 * ladoA) + (2 * ladoB);
            return perimetro;
        }

    }
}
