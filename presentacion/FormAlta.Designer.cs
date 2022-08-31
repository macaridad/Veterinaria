namespace FormVet.presentacion
{
    partial class FormVet
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtEdadM = new System.Windows.Forms.TextBox();
            this.cbTipoM = new System.Windows.Forms.ComboBox();
            this.cbClienteM = new System.Windows.Forms.ComboBox();
            this.gbMascotas = new System.Windows.Forms.GroupBox();
            this.gbAtenciones = new System.Windows.Forms.GroupBox();
            this.dtpAtenciones = new System.Windows.Forms.DateTimePicker();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.bCargar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.CodigoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMascotas.SuspendLayout();
            this.gbAtenciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente";
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(93, 26);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(189, 20);
            this.txtNombreM.TabIndex = 4;
            // 
            // txtEdadM
            // 
            this.txtEdadM.Location = new System.Drawing.Point(93, 63);
            this.txtEdadM.Name = "txtEdadM";
            this.txtEdadM.Size = new System.Drawing.Size(85, 20);
            this.txtEdadM.TabIndex = 5;
            // 
            // cbTipoM
            // 
            this.cbTipoM.FormattingEnabled = true;
            this.cbTipoM.Location = new System.Drawing.Point(93, 99);
            this.cbTipoM.Name = "cbTipoM";
            this.cbTipoM.Size = new System.Drawing.Size(159, 21);
            this.cbTipoM.TabIndex = 6;
            // 
            // cbClienteM
            // 
            this.cbClienteM.FormattingEnabled = true;
            this.cbClienteM.Location = new System.Drawing.Point(93, 143);
            this.cbClienteM.Name = "cbClienteM";
            this.cbClienteM.Size = new System.Drawing.Size(290, 21);
            this.cbClienteM.TabIndex = 7;
            // 
            // gbMascotas
            // 
            this.gbMascotas.Controls.Add(this.cbClienteM);
            this.gbMascotas.Controls.Add(this.cbTipoM);
            this.gbMascotas.Controls.Add(this.label1);
            this.gbMascotas.Controls.Add(this.txtEdadM);
            this.gbMascotas.Controls.Add(this.label2);
            this.gbMascotas.Controls.Add(this.txtNombreM);
            this.gbMascotas.Controls.Add(this.label3);
            this.gbMascotas.Controls.Add(this.label4);
            this.gbMascotas.Location = new System.Drawing.Point(12, 12);
            this.gbMascotas.Name = "gbMascotas";
            this.gbMascotas.Size = new System.Drawing.Size(403, 182);
            this.gbMascotas.TabIndex = 2;
            this.gbMascotas.TabStop = false;
            this.gbMascotas.Text = "Datos de la mascota";
            // 
            // gbAtenciones
            // 
            this.gbAtenciones.Controls.Add(this.dtpAtenciones);
            this.gbAtenciones.Controls.Add(this.txtImporte);
            this.gbAtenciones.Controls.Add(this.txtDescripcion);
            this.gbAtenciones.Controls.Add(this.label7);
            this.gbAtenciones.Controls.Add(this.label6);
            this.gbAtenciones.Controls.Add(this.label5);
            this.gbAtenciones.Location = new System.Drawing.Point(13, 201);
            this.gbAtenciones.Name = "gbAtenciones";
            this.gbAtenciones.Size = new System.Drawing.Size(402, 176);
            this.gbAtenciones.TabIndex = 3;
            this.gbAtenciones.TabStop = false;
            this.gbAtenciones.Text = "Atenciones";
            // 
            // dtpAtenciones
            // 
            this.dtpAtenciones.Location = new System.Drawing.Point(92, 26);
            this.dtpAtenciones.Name = "dtpAtenciones";
            this.dtpAtenciones.Size = new System.Drawing.Size(200, 20);
            this.dtpAtenciones.TabIndex = 5;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(92, 130);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(178, 20);
            this.txtImporte.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(92, 57);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(290, 56);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Importe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha";
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.Location = new System.Drawing.Point(436, 13);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(333, 355);
            this.lstMascotas.TabIndex = 4;
            // 
            // bCargar
            // 
            this.bCargar.Location = new System.Drawing.Point(47, 404);
            this.bCargar.Name = "bCargar";
            this.bCargar.Size = new System.Drawing.Size(75, 23);
            this.bCargar.TabIndex = 5;
            this.bCargar.Text = "Cargar";
            this.bCargar.UseVisualStyleBackColor = true;
            this.bCargar.Click += new System.EventHandler(this.bCargar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(260, 404);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 6;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(479, 404);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 7;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoM,
            this.NombreM,
            this.Edad,
            this.Tipo,
            this.CodigoC,
            this.IdTipo,
            this.Descripcion});
            this.dgvMascotas.Location = new System.Drawing.Point(436, 13);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.Size = new System.Drawing.Size(485, 364);
            this.dgvMascotas.TabIndex = 8;
            // 
            // CodigoM
            // 
            this.CodigoM.DataPropertyName = "cod_mascota";
            this.CodigoM.HeaderText = "Codigo Mascota";
            this.CodigoM.Name = "CodigoM";
            this.CodigoM.Visible = false;
            // 
            // NombreM
            // 
            this.NombreM.DataPropertyName = "nombre";
            this.NombreM.HeaderText = "Nombre Mascota";
            this.NombreM.Name = "NombreM";
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.Width = 30;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // CodigoC
            // 
            this.CodigoC.DataPropertyName = "cod_cliente";
            this.CodigoC.HeaderText = "Codigo de Cliente";
            this.CodigoC.Name = "CodigoC";
            this.CodigoC.Visible = false;
            // 
            // IdTipo
            // 
            this.IdTipo.DataPropertyName = "id_tipo";
            this.IdTipo.HeaderText = "IdTipo";
            this.IdTipo.Name = "IdTipo";
            this.IdTipo.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // FormVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.dgvMascotas);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bCargar);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.gbAtenciones);
            this.Controls.Add(this.gbMascotas);
            this.Name = "FormVet";
            this.Text = "Veterinaria";
            this.Load += new System.EventHandler(this.FormVet_Load);
            this.gbMascotas.ResumeLayout(false);
            this.gbMascotas.PerformLayout();
            this.gbAtenciones.ResumeLayout(false);
            this.gbAtenciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.TextBox txtEdadM;
        private System.Windows.Forms.ComboBox cbTipoM;
        private System.Windows.Forms.ComboBox cbClienteM;
        private System.Windows.Forms.GroupBox gbMascotas;
        private System.Windows.Forms.GroupBox gbAtenciones;
        private System.Windows.Forms.DateTimePicker dtpAtenciones;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstMascotas;
        private System.Windows.Forms.Button bCargar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}

