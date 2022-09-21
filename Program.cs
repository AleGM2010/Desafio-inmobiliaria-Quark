using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioInmobiliaria20._1 {
    class Program {
        static void Main(string[] args) {

            

            // Direccion - Metros cuadrados - precio base - antiguedad y
            // -> para piso : numero de pisos 
            // -> para local : numero de ventanas

             Pisos piso = new Pisos("Alberdi 600",30, 100,20,5);
             Local local = new Local("Buenos aires 300",34,100,20,3);
            // Aunque no se pide, estaria bueno
            // pensar como hacer para que no ingrese valores incorrectos

         
            Console.WriteLine("El precio de su piso es:  {0}", piso.Calcular());
            Console.WriteLine("El precio de su local es: {0}", local.Calcular());
        }
    }
}
