using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioInmobiliaria20._1 {
     abstract class Inmuebles {


        private string direccion;
        private float precioBase;
        private int metrosCuadrados;
        private int antiguedad;

        public string Direccion { get => direccion; set => direccion = value; }
        public float PrecioBase { get => precioBase; set => precioBase = value; }
        public int MetrosCuadrados { get => metrosCuadrados; set => metrosCuadrados = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }

        public virtual float Calcular() {
            int acumulador=0;
            if (15 > antiguedad) {
                acumulador -= 1;
            } else {
                acumulador -= 2;
            }

            return acumulador;
        }
       


    }
}
