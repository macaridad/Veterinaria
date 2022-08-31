using System.Collections.Generic;

namespace FormVet.dominio
{
    internal class Mascota
    {
        private int codigoM;
        private string nombreM;
        private int edad;
        private Tipo tipo;
        private List<Atencion> atenciones;
        public int CodigoM { get { return codigoM; } set { codigoM = value; } }
        public string NombreM { get { return nombreM; } set { nombreM = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public Tipo Tipo { get { return tipo; } set { tipo = value; } }
        public List<Atencion> Atenciones { get { return atenciones; } set { atenciones = value; } }

        public Mascota()
        {
            codigoM = 0;
            nombreM = string.Empty;
            edad = 0;
            tipo = new Tipo();
            atenciones = new List<Atencion>();
        }

        public Mascota(int codigoM, string nombreM, int edad, Tipo tipo, List<Atencion> atenciones)
        {
            this.codigoM = codigoM;
            this.nombreM = nombreM;
            this.edad = edad;
            this.tipo = tipo;
            this.atenciones = atenciones;
        }

        public string ToString()
        {
            return "Nombre: " + nombreM + " | Edad: " + edad + " | Tipo: " + tipo.ToString();
        }
    }
}