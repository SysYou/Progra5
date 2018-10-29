using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Practica.Examen.DiegoRM.Logica.Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1

    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public double Are_Cuadrado(double lado)
        {
            Logica.Especificacion.Area_Cuadrado laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Area_Cuadrado();
            var elResultado = laEspecificacion.Are_Cuadrado(lado);
            return elResultado;
        }

        public double Area_PoligRegular(double lado, double apotema, int cant_lados)
        {
            Logica.Especificacion.Area_PolRegular laEspecificacion;
            laEspecificacion = new Logica.Especificacion.Area_PolRegular();
            var elResultado = laEspecificacion.Area_PolRegula(lado, apotema, cant_lados);
            return elResultado;
        }

    }
}
