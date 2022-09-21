using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioInmobiliaria20._1 {
    class Local: Inmuebles {
        private int ventanas;

        public Local(string direc, int metrosCuad, float precioBase, int antiguedad, int ventanas) {
            Direccion = direc;
            MetrosCuadrados = metrosCuad;
            PrecioBase = precioBase;
            Antiguedad = antiguedad;
            this.ventanas = ventanas;
        }

        public override float Calcular() {
            int acumulador = 0;
            if (MetrosCuadrados > 50) {
                acumulador += 1;
            }
            if (ventanas <= 1) {
                acumulador -= 2;
            } else if (ventanas > 4){
                acumulador += 2;
            }

            return (PrecioBase+(PrecioBase * (base.Calcular() + acumulador) / 100));
        }
    }
}
