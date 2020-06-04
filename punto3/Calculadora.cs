using System;
using System.Collections.Generic;
using System.Text;

namespace punto3
{
    class Calculadora
    {
        private float numero1;
        private float numero2;
        private DateTime fecha;
        private string operacion;
         public float Numero1
        {
            get
            {
                return numero1;
            }
            set
            {
                numero1 = value;
            }
        }
        public float Numero2
        {
            get
            {
                return numero2;
            }
            set
            {
                numero2 = value;
            }
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Operacion { get => operacion; set => operacion = value; }

        public float Suma()
        {
            return (numero1+numero2);
        }
        public float Resta()
        {
            return (numero1-numero2);
        }
        public float Multiplicacion()
        {
            return numero1 * numero2;
        }
        public float Division()
        {
            return numero1 / numero2;
        }
    }
}
