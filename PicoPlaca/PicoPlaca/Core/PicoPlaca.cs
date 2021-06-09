using PicoPlaca.Mensajeria.Constantes;
using PicoPlaca.Mensajeria.MensajeEntrada;
using PicoPlaca.Mensajeria.MensajeSalida;
using System;
using System.Globalization;

namespace PicoPlaca
{
    public class PicoPlaca
    {
        public PicoPlacaMS ValidarPicoPlaca(PicoPlacaME mensajeEntrada)
        {
            try
            {
                PicoPlacaMS mensajeSalida = new PicoPlacaMS();

                var seriePlacaNumeros = mensajeEntrada.Placa.Split('-')[1];
                var fecha = DateTime.Parse(mensajeEntrada.Fecha, new CultureInfo("es-EC"));
                var hora = TimeSpan.Parse(mensajeEntrada.Hora);

                string dia = fecha.ToLongDateString().Split(',')[0];
                mensajeSalida.Fecha = fecha.ToString("dddd dd MMM yyyy", new CultureInfo("es-ES"));

                int numeroFinalPlaca = seriePlacaNumeros.Length == 3 ? seriePlacaNumeros[2] : seriePlacaNumeros[3];

                switch (numeroFinalPlaca)
                {
                    case 0:
                    case 9:
                        {
                            if (dia == Dias.Viernes)
                                mensajeSalida.Permitido = ValidarHora(hora);
                            else
                                mensajeSalida.Permitido = true;
                        }
                        break;
                    case 1:
                    case 2:
                        {
                            if (dia == Dias.Lunes)
                                mensajeSalida.Permitido = ValidarHora(hora);
                            else
                                mensajeSalida.Permitido = true;
                        }
                        break;
                    case 3:
                    case 4:
                        {
                            if (dia == Dias.Martes)
                            {
                                mensajeSalida.Permitido = ValidarHora(hora);
                            }
                            else
                            {
                                mensajeSalida.Permitido = true;
                            }
                        }
                        break;
                    case 5:
                    case 6:
                        {
                            if (dia == Dias.Miercoles)
                                mensajeSalida.Permitido = ValidarHora(hora);
                            else
                                mensajeSalida.Permitido = true;
                        }
                        break;
                    case 7:
                    case 8:
                        {
                            if (dia == Dias.Lunes)
                                mensajeSalida.Permitido = ValidarHora(hora);
                            else
                                mensajeSalida.Permitido = true;
                        }
                        break;
                    default:
                        break;
                }

                return mensajeSalida;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private bool ValidarHora(TimeSpan hora)
        {
            if (hora > new TimeSpan(7, 0, 0) && hora < new TimeSpan(9, 30, 0))
                return false;
            else if (hora > new TimeSpan(16, 0, 0) && hora < new TimeSpan(19, 30, 0))
                return false;
            else
                return true;
        }
    }
}
