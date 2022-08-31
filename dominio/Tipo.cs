namespace FormVet.dominio
{
    internal class Tipo
    {
        private int id;
        private string descripcion;

        public int ID { get { return id; } set { id = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }

        public Tipo()
        {
            id = 0;
            descripcion = string.Empty;
        }
        public Tipo(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public string ToString()
        {
            return descripcion;
        }

    }
}