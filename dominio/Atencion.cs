using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormVet.dominio
{
    internal class Atencion
    {
		private DateTime fecha;

		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}
		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}
		private float importe;

		public float Importe
		{
			get { return importe; }
			set { importe = value; }
		}
		public Atencion()
		{
			fecha = DateTime.Now;
			descripcion = String.Empty;
			importe = 0;
		}
		public string ToString()
		{
			return "Fecha: " + fecha + " | Descripción: " + descripcion + " | Importe: " + importe;
		}

	}
}
