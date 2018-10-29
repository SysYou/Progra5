using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Practica.Examen.DiegoRM
{

    [TestClass]
    public class Area_Cuadrado
    {
        [TestMethod]
        public void Area_Cuadra()
        {
            // preparación del escenario
            var milado = 5.0;
            var miValorEsperado = 25.0;
            var miValorReal = 0.0;

            // invocamos el método
            // para invocar dinámicamente al método
            var elServicio = new DiegoRM.Logica.Servicio.Service1();
            miValorReal = elServicio.Area_Cuadrado(milado);

            // verificar el resultado obtenido
            Assert.AreEqual(miValorEsperado, miValorReal);

        }
    }

}
