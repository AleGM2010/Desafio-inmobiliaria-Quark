using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioInmobiliaria20._1 {
    class Pisos:Inmuebles {
        private int nPiso;
        public int NPiso { get => nPiso; set => nPiso = value; }

        // Pisos piso = new Pisos("Alberdi 600",49, 5000,12,7);
        public Pisos(string direc,int metrosCuad,float precioBase,int antiguedad,int piso) {
            Direccion = direc;
            MetrosCuadrados = metrosCuad;
            PrecioBase = precioBase;
            Antiguedad = antiguedad;
            this.NPiso = piso;
        }


        public override float Calcular() {
            int acumulador=0;
            if (NPiso >= 3) {
                acumulador += 3;
            }

            return (PrecioBase + (PrecioBase * (base.Calcular() + acumulador) / 100));
        }
    }
}
