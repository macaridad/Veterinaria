using FormVet.datos;
using FormVet.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormVet.presentacion
{
    public partial class FormVet : Form
    {
        private AyudanteBD ayudante;
        public FormVet()
        {
            InitializeComponent();
            ayudante = new AyudanteBD();
        }

        private void FormVet_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarLista();
            CargarDGV();
            Habilitar(true);
        }
        private void CargarLista()
        {
            DataTable tabla = ayudante.EjecutarConsultaSql("sp_cargar_listado");
            foreach (DataRow fila in tabla.Rows)
            {
                Mascota oMascota = new Mascota();
                oMascota.NombreM = fila["nombre"].ToString();
                oMascota.CodigoM = int.Parse(fila["cod_mascota"].ToString());
                oMascota.Edad = (int)fila["edad"];
                oMascota.Tipo = new Tipo((int)fila["id_tipo"], fila["descripcion"].ToString());
                lstMascotas.Items.Add(oMascota.ToString());
            }
        }
        public void CargarDGV()
        {
            DataTable tabla = ayudante.EjecutarConsultaSql("sp_cargar_listado");
            dgvMascotas.DataSource = tabla.DefaultView;
            //dgvMascotas.Rows.Remove y RemoveAt para eliminar una fila.
        }
        public void CargarCombos()
        {
            DataTable tabla = ayudante.EjecutarConsultaSql("sp_cargar_tipos"); //asignar directamente como datasource
            cbTipoM.DataSource = tabla;
            cbTipoM.DisplayMember = "descripcion";
            cbTipoM.ValueMember = "id_tipo";
            DataTable tabla2 = ayudante.EjecutarConsultaSql("sp_cargar_clientes");
            cbClienteM.DataSource = tabla2;
            cbClienteM.DisplayMember = "nombre"; // hacer con lista
            cbClienteM.ValueMember = "cod_cliente";
        }
        private void Habilitar(bool x)
        {
            txtNombreM.Enabled = x;
            txtEdadM.Enabled = x;
            txtDescripcion.Enabled = x;
            txtImporte.Enabled = x;
            cbClienteM.Enabled = x;
            cbTipoM.Enabled = x;
            dtpAtenciones.Enabled = x;
            bCancelar.Enabled = x;
            bCargar.Enabled = x;
            bSalir.Enabled = x;
        }

        private void bCargar_Click(object sender, EventArgs e)
        {
            Mascota oMascota = new Mascota();
            oMascota.NombreM = txtNombreM.Text;
            oMascota.Edad = int.Parse(txtEdadM.Text);
            oMascota.Tipo = new dominio.Tipo(int.Parse(cbTipoM.SelectedValue.ToString()), cbTipoM.SelectedItem.ToString());
            Cliente oCliente = new Cliente();
            oCliente.CodigoC = int.Parse(cbClienteM.SelectedValue.ToString());
            Atencion oAtencion = new Atencion();
            oAtencion.Fecha = dtpAtenciones.Value;
            oAtencion.Descripcion = txtDescripcion.Text;
            oAtencion.Importe = float.Parse(txtImporte.Text);
            if(ayudante.EjecutarSPABM("sp_cargar_mascotas", oMascota, oAtencion, oCliente)>0)
            {
                MessageBox.Show("La mascota y su atención se han cargado con éxito");
                Limpiar();
                CargarDGV();
            }
        }

        private void Limpiar()
        {
            txtDescripcion.Clear();
            txtEdadM.Clear();
            txtImporte.Clear();
            txtNombreM.Clear();
            cbTipoM.SelectedIndex = -1;
            cbClienteM.SelectedIndex = -1;
            dtpAtenciones.Value = DateTime.Now;
        }

        //private void CargarClientes()
        //{
        //    DataTable tabla = ayudante.CargarClientes();
        //    cbClienteM.DataSource = tabla;
        //    cbClienteM.DisplayMember = "nombre";
        //    cbClienteM.ValueMember = "cod_cliente"; ;
        //}

        //private void CargarTipos()
        //{
        //    DataTable tabla = ayudante.CargarTipos();
        //    cbTipoM.DataSource = tabla;
        //    cbTipoM.DisplayMember = "descripcion";
        //    cbTipoM.ValueMember = "id_tipo";
        //}
    }
}
