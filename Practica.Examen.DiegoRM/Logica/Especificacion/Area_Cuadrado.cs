using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica.Examen.DiegoRM.Logica.Especificacion
{
    public class Area_Cuadrado
    {

        public double Are_Cuadrado(double lado)
        {
            var laAccion = new Practica.Examen.DiegoRM.Logica.Accion.Area_Cuadrado();
            double elResultado = laAccion.Are_Cuadrado(lado);
            return elResultado;
        }

    }
}