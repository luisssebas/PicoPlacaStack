using PicoPlaca.Core;
using PicoPlaca.Mensajeria.MensajeEntrada;
using System;

namespace PicoPlaca
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            PicoPlacaME mensajeEntrada = new PicoPlacaME();
            PicoPlacaServicio servicio = new PicoPlacaServicio();

            Console.WriteLine("Ingrese su placa (ABC-1234): ");
            mensajeEntrada.Placa = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha (dd/mm/yyyy): ");
            mensajeEntrada.Fecha = Console.ReadLine();

            Console.WriteLine("Ingrese la hora (HH:mm): ");
            mensajeEntrada.Hora = Console.ReadLine();

            servicio.ValidarPicoPlaca(mensajeEntrada);
        }
    }
}
