using PicoPlaca.Mensajeria.MensajeEntrada;
using PicoPlaca.Mensajeria.MensajeSalida;
using System;
using System.Threading;

namespace PicoPlaca
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            PicoPlacaME mensajeEntrada = new PicoPlacaME();
            PicoPlaca picoPlaca = new PicoPlaca();

            Console.WriteLine("Ingrese su placa (ABC-1234): ");
            mensajeEntrada.Placa = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha (dd/mm/yyyy): ");
            mensajeEntrada.Fecha = Console.ReadLine();

            Console.WriteLine("Ingrese la hora (HH:mm): ");
            mensajeEntrada.Hora = Console.ReadLine();

            PicoPlacaMS mensajeSalida = picoPlaca.ValidarPicoPlaca(mensajeEntrada);

            if(mensajeSalida != null)
            {
                if (mensajeSalida.Permitido)
                    Console.WriteLine("Su auto si puede circular el día " + mensajeSalida.Fecha);
                else
                    Console.WriteLine("Su auto no puede circular el día " + mensajeSalida.Fecha);
            }
            else
                Console.WriteLine("No se puede calcular con los datos ingresados");

            Thread.Sleep(5000);
        }
    }
}
