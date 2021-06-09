using Microsoft.VisualStudio.TestTools.UnitTesting;
using PicoPlaca.Core;
using PicoPlaca.Mensajeria.MensajeEntrada;

namespace PicoPlacaTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly PicoPlacaServicio servicio = new PicoPlacaServicio();

        [TestMethod]
        public void TestMethod1()
        {
            PicoPlacaME mensajeEntrada = new PicoPlacaME()
            {
                Fecha = "07/06/2021",
                Hora = "16:30",
                Placa = "PBB-5894"
            };

            servicio.ValidarPicoPlaca(mensajeEntrada);
        }

        [TestMethod]
        public void TestMethod2()
        {
            PicoPlacaME mensajeEntrada = new PicoPlacaME()
            {
                Fecha = "18/11/2018",
                Hora = "07:21",
                Placa = "TJI-8985"
            };

            servicio.ValidarPicoPlaca(mensajeEntrada);
        }

        [TestMethod]
        public void TestMethod3()
        {
            PicoPlacaME mensajeEntrada = new PicoPlacaME()
            {
                Fecha = "23/05/2017",
                Hora = "22:27",
                Placa = "TJI-898"
            };

            servicio.ValidarPicoPlaca(mensajeEntrada);
        }

        [TestMethod]
        public void TestMethod4()
        {
            PicoPlacaME mensajeEntrada = new PicoPlacaME()
            {
                Fecha = "07/06/2021",
                Hora = "09:30",
                Placa = "IMB444"
            };

            servicio.ValidarPicoPlaca(mensajeEntrada);
        }
    }
}
