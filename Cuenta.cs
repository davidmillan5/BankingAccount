using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    internal class Cuenta
    {

        //Crear clase factura
        //1. Definir alcance, tipos y propiedades.
        //2. Encapsular ->
        //3. Crear constructores

        //Solución del 1er paso -> 
        private double numeroDeCuenta;
        private String nombreUsuario;
        private double saldoActual;
        private double valorRetiro;
        private double valorConsignacion;
        private String reciboTransaccion;
        private String fechaApertura;
        private String tipoDeCuenta;



        // Encapsular 2do paso ->
        //1ro. Seleccionar
        //2do. Click derecho
        //3ro. Acciones rapidas y refactorización
        //4to. Usar propiedades y encapsular.


        public double NumeroDeCuenta { get => numeroDeCuenta; set => numeroDeCuenta = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public double SaldoActual { get => saldoActual; set => saldoActual = value; }
        public double ValorRetiro { get => valorRetiro; set => valorRetiro = value; }
        public double ValorConsignacion { get => valorConsignacion; set => valorConsignacion = value; }
        public string ReciboTransaccion { get => reciboTransaccion; set => reciboTransaccion = value; }
        public string FechaApertura { get => fechaApertura; set => fechaApertura = value; }
        public string TipoDeCuenta { get => tipoDeCuenta; set => tipoDeCuenta = value; }


        //Crear Constructores 3er paso ->
        //Por defecto existe un contructor
        //El constructor se genera de forma rapida señalanado la solución del primer paso, dando click a acciones rapidas y luego dando click a la opción crear constructor.

        public Cuenta() { }

        public Cuenta(double numeroDeCuenta, string nombreUsuario, double saldoActual, double valorRetiro, double valorConsignacion, string reciboTransaccion, string fechaApertura, string tipoDeCuenta)
        {
            this.numeroDeCuenta = numeroDeCuenta;
            this.nombreUsuario = nombreUsuario;
            this.saldoActual = saldoActual;
            this.valorRetiro = valorRetiro;
            this.valorConsignacion = valorConsignacion;
            this.reciboTransaccion = reciboTransaccion;
            this.fechaApertura = fechaApertura;
            this.tipoDeCuenta = tipoDeCuenta;
        }


        public Cuenta(double numeroDeCuenta, string nombreUsuario, double saldoActual, string tipoDeCuenta, string fechaApertura)
        {
            this.numeroDeCuenta = numeroDeCuenta;
            this.nombreUsuario = nombreUsuario;
            this.saldoActual = saldoActual;
            this.tipoDeCuenta = tipoDeCuenta;
            this.fechaApertura = fechaApertura;
        }



        //Creación de metodos 4to paso->


        public void CrearUsuario(string nombreUsuario)
        {
            nombreUsuario = this.nombreUsuario;
        }

        public void Retirar(double valorRetiro)
        {
            if (saldoActual > 0)
            {
                if (saldoActual >= valorRetiro)
                {

                    saldoActual -= valorRetiro;
                    ImprimirRetiro(saldoActual, valorRetiro);
                }
                else
                {

                    ImprimirRetiroSaldoInsuficiente();
                }
            }
            else
            {
                Console.WriteLine("Por favor realice consignaciones a su cuenta ya que no cuenta con dinero disponible en ella");
            }

        }

        public void Consignar(double valorConsignacion)
        {

            saldoActual += valorConsignacion;
            ImprimirConsignacion(saldoActual,valorConsignacion);
        }

        public void Consultar(double numeroDeCuenta)
        {
            ImprimirReciboConsulta();
        }


        public void ImprimirReciboConsulta()
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("\tNumero de cuenta: " + numeroDeCuenta);
            Console.WriteLine("\tNombre del Usuario: " + nombreUsuario);
            Console.WriteLine("\tTipo de Cuenta: " + tipoDeCuenta);
            Console.WriteLine("\tFecha: " + fechaApertura);
            Console.WriteLine("\tSaldo Actual: ---------------------> " + saldoActual);
            Console.WriteLine("-------------------------------------------------------------------");
        }

        public void ImprimirConsignacion(double saldoActual, double valorConsignacion)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("\tNumero de cuenta: " + numeroDeCuenta);
            Console.WriteLine("\tNombre del Usuario: " + nombreUsuario);
            Console.WriteLine("\tTipo de Cuenta: " + tipoDeCuenta);
            Console.WriteLine("\tFecha: " + fechaApertura);
            Console.WriteLine("\tValor de Consignacion " + valorConsignacion);
            Console.WriteLine($"\tSaldo Actual: ---------------------> " + saldoActual);
            Console.WriteLine("-------------------------------------------------------------------");
        }

        public void ImprimirRetiro(double saldoActual, double valorRetiro)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("\tNumero de cuenta: " + numeroDeCuenta);
            Console.WriteLine("\tNombre del Usuario: " + nombreUsuario);
            Console.WriteLine("\tTipo de Cuenta: " + tipoDeCuenta);
            Console.WriteLine("\tFecha: " + fechaApertura);
            Console.WriteLine("\tValor de Retiro " + valorRetiro);
            Console.WriteLine("\tSaldo Actual: ---------------------> " + saldoActual);
            Console.WriteLine("-------------------------------------------------------------------");


        }

        public void ImprimirRetiroSaldoInsuficiente()
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("\tNumero de cuenta: " + numeroDeCuenta);
            Console.WriteLine("\tNombre del Usuario: " + nombreUsuario);
            Console.WriteLine("\tTipo de Cuenta: " + tipoDeCuenta);
            Console.WriteLine("\tFecha: " + fechaApertura);
            Console.WriteLine("\tValor de Retiro: " + valorRetiro);
            Console.WriteLine("\tSaldo Actual: ---------------------> " + saldoActual);
            Console.WriteLine("El monto en cuenta es inferior al solicitado, por favor ingrese un valor de retiro inferior o realiza una consignación.");
            Console.WriteLine("-------------------------------------------------------------------");


        }



    }
}
