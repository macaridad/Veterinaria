using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormVet.dominio
{
    internal class Cliente
    {
        private int codigoC;
        private string nombre;
        private bool sexo;
        private List<Mascota> listMascotas;

        public int CodigoC { get { return codigoC; } set { codigoC = value; }}
        public string Nombre { get { return nombre; } set { nombre = value; }}
        public bool Sexo { get { return sexo; } set { sexo = value; }}
        public List<Mascota> ListMascotas { get { return listMascotas; } set { listMascotas = value; }}

        public Cliente()
        {
            codigoC= 0;
            nombre = String.Empty;
            sexo = false;
            listMascotas = new List<Mascota>();
        }

        public Cliente (int codigo, string nombre, bool sexo, List<Mascota> listMascotas)
        {
            this.codigoC = codigo;
            this.nombre = nombre;
            this.sexo = sexo;
            this.listMascotas = listMascotas;
        }

        public string ToString()
        {
            return "Nombre: " + nombre + " | Mascotas: " +listMascotas.ToString();
        }
    }

}
