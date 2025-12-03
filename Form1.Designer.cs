namespace Prueba1
{
    partial class Form1
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
            this.DTGV1 = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnVaciar = new System.Windows.Forms.Button();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.TxtImportancia = new System.Windows.Forms.TextBox();
            this.labelImportancia = new System.Windows.Forms.Label();
            this.LblFECHA = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHora = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGV1
            // 
            this.DTGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DTGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV1.Location = new System.Drawing.Point(12, 62);
            this.DTGV1.Name = "DTGV1";
            this.DTGV1.Size = new System.Drawing.Size(568, 197);
            this.DTGV1.TabIndex = 20;
            this.DTGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV1_CellClick);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(215, 275);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(96, 42);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(19, 34);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(130, 20);
            this.TxtName.TabIndex = 1;
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // BtnVaciar
            // 
            this.BtnVaciar.Location = new System.Drawing.Point(113, 275);
            this.BtnVaciar.Name = "BtnVaciar";
            this.BtnVaciar.Size = new System.Drawing.Size(96, 42);
            this.BtnVaciar.TabIndex = 8;
            this.BtnVaciar.Text = "DESCONECTAR";
            this.BtnVaciar.UseVisualStyleBackColor = true;
            this.BtnVaciar.Click += new System.EventHandler(this.BtnVaciar_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(11, 275);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(96, 42);
            this.BtnCargar.TabIndex = 7;
            this.BtnCargar.Text = "ACTUALIZAR";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(59, 9);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(419, 273);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(96, 42);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(523, 287);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(57, 20);
            this.TxtId.TabIndex = 7;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(546, 271);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(16, 13);
            this.labelID.TabIndex = 8;
            this.labelID.Text = "Id";
            // 
            // TxtImportancia
            // 
            this.TxtImportancia.Location = new System.Drawing.Point(155, 34);
            this.TxtImportancia.Name = "TxtImportancia";
            this.TxtImportancia.Size = new System.Drawing.Size(130, 20);
            this.TxtImportancia.TabIndex = 2;
            this.TxtImportancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtImportancia_KeyPress);
            // 
            // labelImportancia
            // 
            this.labelImportancia.AutoSize = true;
            this.labelImportancia.Location = new System.Drawing.Point(180, 9);
            this.labelImportancia.Name = "labelImportancia";
            this.labelImportancia.Size = new System.Drawing.Size(81, 13);
            this.labelImportancia.TabIndex = 10;
            this.labelImportancia.Text = "IMPORTANCIA";
            // 
            // LblFECHA
            // 
            this.LblFECHA.AutoSize = true;
            this.LblFECHA.Location = new System.Drawing.Point(344, 9);
            this.LblFECHA.Name = "LblFECHA";
            this.LblFECHA.Size = new System.Drawing.Size(42, 13);
            this.LblFECHA.TabIndex = 12;
            this.LblFECHA.Text = "FECHA";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(304, 34);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(130, 20);
            this.TxtFecha.TabIndex = 3;
            this.TxtFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFecha_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "HORA";
            // 
            // TxtHora
            // 
            this.TxtHora.Location = new System.Drawing.Point(450, 34);
            this.TxtHora.Name = "TxtHora";
            this.TxtHora.Size = new System.Drawing.Size(130, 20);
            this.TxtHora.TabIndex = 4;
            this.TxtHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHora_KeyPress);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(317, 275);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(96, 42);
            this.BtnEditar.TabIndex = 21;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 327);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtHora);
            this.Controls.Add(this.LblFECHA);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.labelImportancia);
            this.Controls.Add(this.TxtImportancia);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.BtnVaciar);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DTGV1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGV1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnVaciar;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox TxtImportancia;
        private System.Windows.Forms.Label labelImportancia;
        private System.Windows.Forms.Label LblFECHA;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtHora;
        private System.Windows.Forms.Button BtnEditar;
    }
}

