namespace ModeloParcial405310.PRESENTACION
{
    partial class FormNuevaOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.ColumnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboMateriales = new System.Windows.Forms.ComboBox();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.dtpFechaOrden = new System.Windows.Forms.DateTimePicker();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblFechaOrden = new System.Windows.Forms.Label();
            this.lblOrdenNro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.Location = new System.Drawing.Point(349, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnConfirmar.Location = new System.Drawing.Point(201, 405);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(142, 23);
            this.btnConfirmar.TabIndex = 24;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaId,
            this.ColumnaMaterial,
            this.ColumnaStock,
            this.ColumnaCantidad,
            this.ColumnaAcciones});
            this.dgvDetalles.Location = new System.Drawing.Point(18, 153);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(613, 237);
            this.dgvDetalles.TabIndex = 23;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // ColumnaId
            // 
            this.ColumnaId.HeaderText = "";
            this.ColumnaId.Name = "ColumnaId";
            this.ColumnaId.ReadOnly = true;
            this.ColumnaId.Visible = false;
            // 
            // ColumnaMaterial
            // 
            this.ColumnaMaterial.HeaderText = "Material";
            this.ColumnaMaterial.Name = "ColumnaMaterial";
            this.ColumnaMaterial.ReadOnly = true;
            this.ColumnaMaterial.Width = 160;
            // 
            // ColumnaStock
            // 
            this.ColumnaStock.HeaderText = "Stock";
            this.ColumnaStock.Name = "ColumnaStock";
            this.ColumnaStock.ReadOnly = true;
            this.ColumnaStock.Width = 110;
            // 
            // ColumnaCantidad
            // 
            this.ColumnaCantidad.HeaderText = "Cantidad";
            this.ColumnaCantidad.Name = "ColumnaCantidad";
            this.ColumnaCantidad.ReadOnly = true;
            this.ColumnaCantidad.Width = 150;
            // 
            // ColumnaAcciones
            // 
            this.ColumnaAcciones.HeaderText = "Acciones";
            this.ColumnaAcciones.Name = "ColumnaAcciones";
            this.ColumnaAcciones.ReadOnly = true;
            this.ColumnaAcciones.Width = 150;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.Location = new System.Drawing.Point(522, 114);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 23);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(351, 115);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(165, 20);
            this.txtCantidad.TabIndex = 21;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(282, 118);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 13);
            this.lblCantidad.TabIndex = 20;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // cboMateriales
            // 
            this.cboMateriales.FormattingEnabled = true;
            this.cboMateriales.Location = new System.Drawing.Point(105, 114);
            this.cboMateriales.Name = "cboMateriales";
            this.cboMateriales.Size = new System.Drawing.Size(165, 21);
            this.cboMateriales.TabIndex = 19;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(105, 78);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(199, 20);
            this.txtResponsable.TabIndex = 18;
            // 
            // dtpFechaOrden
            // 
            this.dtpFechaOrden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaOrden.Location = new System.Drawing.Point(105, 40);
            this.dtpFechaOrden.Name = "dtpFechaOrden";
            this.dtpFechaOrden.Size = new System.Drawing.Size(123, 20);
            this.dtpFechaOrden.TabIndex = 17;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(43, 118);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(56, 13);
            this.lblMaterial.TabIndex = 16;
            this.lblMaterial.Text = "Material:";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.Location = new System.Drawing.Point(18, 81);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(84, 13);
            this.lblResponsable.TabIndex = 15;
            this.lblResponsable.Text = "Responsable:";
            // 
            // lblFechaOrden
            // 
            this.lblFechaOrden.AutoSize = true;
            this.lblFechaOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaOrden.Location = new System.Drawing.Point(55, 46);
            this.lblFechaOrden.Name = "lblFechaOrden";
            this.lblFechaOrden.Size = new System.Drawing.Size(46, 13);
            this.lblFechaOrden.TabIndex = 14;
            this.lblFechaOrden.Text = "Fecha:";
            // 
            // lblOrdenNro
            // 
            this.lblOrdenNro.AutoSize = true;
            this.lblOrdenNro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenNro.Location = new System.Drawing.Point(54, 9);
            this.lblOrdenNro.Name = "lblOrdenNro";
            this.lblOrdenNro.Size = new System.Drawing.Size(84, 20);
            this.lblOrdenNro.TabIndex = 13;
            this.lblOrdenNro.Text = "Orden N°";
            // 
            // FormNuevaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cboMateriales);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.dtpFechaOrden);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.lblFechaOrden);
            this.Controls.Add(this.lblOrdenNro);
            this.Name = "FormNuevaOrden";
            this.Text = "FormNuevaOrden";
            this.Load += new System.EventHandler(this.FormNuevaOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnaAcciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cboMateriales;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.DateTimePicker dtpFechaOrden;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblFechaOrden;
        private System.Windows.Forms.Label lblOrdenNro;
    }
}