using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("--------***   BIENVENIDOS AL SERVICIO DE BANCA MOVIL ***----------");
            Console.WriteLine("------------------------------------------------------------------");

            Console.Write("Ingrese el número bajo el cual quedara registrada su cuenta: ");
            int numeroDeCuenta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su nombre y apellido: ");
            string nombreUsuario = Console.ReadLine();

            Console.Write("Ingrese el monto inicial con el que creara su nueva cuenta: ");
            double saldoActual = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tipo de cuenta que desea crear: ");
            string  tipoDeCuenta = Console.ReadLine();

            Console.Write("Ingrese la fecha del día de hoy con formato DD/MM/AAAA:  ");
            string fechaApertura = Console.ReadLine();

            Cuenta cuenta01 = new Cuenta(numeroDeCuenta, nombreUsuario, saldoActual, tipoDeCuenta, fechaApertura);
            cuenta01.ImprimirReciboConsulta();



            Console.WriteLine("¿Deseas realizar una nueva operación? Presiona 1. Para una nueva operacion 2. Para salir");
            int nuevaOperacion = Convert.ToInt32(Console.ReadLine());
            
            while(nuevaOperacion == 1)
            {
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("¿Que nueva operacion desea realizar? Presiona: \n 1. Para consignar dinero  \n2. Para realizar retiros  \n3. Para consultar el saldo \n4. Para finalizar");
                int nuevoServicio = Convert.ToInt32(Console.ReadLine());
                if (nuevoServicio == 1)
                {
                    Console.WriteLine("Ingrese el valor del monto a consignar: ");
                    double nuevaConsignacion = Convert.ToDouble(Console.ReadLine());
                    cuenta01.Consignar(nuevaConsignacion);
                    
                   

                }
                else if (nuevoServicio == 2)
                {
                    Console.WriteLine("Ingrese el valor del monto a retirar: ");
                    double nuevoRetiro = Convert.ToDouble(Console.ReadLine());
                    cuenta01.Retirar(nuevoRetiro);
                    


                }
                else if (nuevoServicio == 3)
                {
                    Console.WriteLine("Ingrese el numero de su cuenta: ");
                    int numeroCuenta = Convert.ToInt32(Console.ReadLine());
                    cuenta01.Consultar(numeroCuenta);
                    

                }
                else
                {
                    Despedida();
                }

                Console.WriteLine("¿Deseas realizar una nueva operación? Presiona 1. Para una nueva operacion 2. Para salir");
                nuevaOperacion = Convert.ToInt32(Console.ReadLine());

                Despedida();
            }
          
                
      
            Menu();



            Console.ReadKey();
        }


        public static void Menu()
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("\tDesarrollador: Cesar David Millan");
            Console.WriteLine("\tTema: Talller 1er Momento Desempeño");
            Console.WriteLine("\tFecha: 27/08/2022 ");
            Console.WriteLine("\tGrupo: Sabados 07:30am ");
            Console.WriteLine("-------------------------------------------------------------------");
        }

        public static void Despedida()
        {
            Console.WriteLine("\t--------------**** PRESIONE ENTER PARA FINALIZAR ****---------------");
        }


    }
}
