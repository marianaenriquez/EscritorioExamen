using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelo;

namespace Ventas.Servicio
{
    class ValuesController
    {
       
       
        public List<Venta> ConsultaVentaP(int id) //metodo publico que regresa un arreglo de texto con nombre get
        {
            List<string> listas = new List<string>();
            var Consulta = new ClaseAccesoDatos(); //regresa una nueva cadena de texto 
            var Lista = Consulta.ConsultaVentas(id);
            return Lista;
        }
        public List<Productos> ConsultaPro(int id) //metodo publico que regresa un arreglo de texto con nombre get
        {
            List<string> listas = new List<string>();
            var Consulta = new ClaseAccesoDatos(); //regresa una nueva cadena de texto 
            var Lista = Consulta.ConsultaPro(id);
            return Lista;
        }


        public List<Venta> ConsultaVenta() //metodo publico que regresa un arreglo de texto con nombre get
        {
            var Consulta = new ClaseAccesoDatos(); //regresa una nueva cadena de texto 
            var Lista = Consulta.ConsultaTabla();
            return Lista;
        }

        public List<Productos> ConsultaProducto() //metodo publico que regresa un arreglo de texto con nombre get
        {
            var Consulta = new ClaseAccesoDatos(); //regresa una nueva cadena de texto 
            var Lista = Consulta.ConsultaTablaP();
            return Lista;
        }

        public List<Venta> ConsultaMasV() //metodo publico que regresa un arreglo de texto con nombre get
        {
            var Consulta = new ClaseAccesoDatos(); //regresa una nueva cadena de texto 
            var Lista = Consulta.ConsultaMasV();
            return Lista;
        }




    }
}
