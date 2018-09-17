namespace SistemaCotizacionArticulos.UI.Registros
{
    partial class RegistroExistencia
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label articuloIDLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label existenciaLabel;
            this.existenciaArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.existenciaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuargar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnBuscar = new System.Windows.Forms.Button();
            articuloIDLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            existenciaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.existenciaArticuloBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // articuloIDLabel
            // 
            articuloIDLabel.AutoSize = true;
            articuloIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            articuloIDLabel.Location = new System.Drawing.Point(18, 41);
            articuloIDLabel.Name = "articuloIDLabel";
            articuloIDLabel.Size = new System.Drawing.Size(71, 16);
            articuloIDLabel.TabIndex = 1;
            articuloIDLabel.Text = "Articulo ID:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(11, 67);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(83, 16);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            existenciaLabel.Location = new System.Drawing.Point(19, 93);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(72, 16);
            existenciaLabel.TabIndex = 5;
            existenciaLabel.Text = "Existencia:";
            // 
            // existenciaArticuloBindingSource
            // 
            this.existenciaArticuloBindingSource.DataSource = typeof(SistemaCotizacionArticulos.Entidades.ExistenciaArticulo);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.existenciaArticuloBindingSource, "Descripcion", true));
            this.descripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(104, 64);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.Size = new System.Drawing.Size(176, 22);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // existenciaTextBox
            // 
            this.existenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.existenciaArticuloBindingSource, "Existencia", true));
            this.existenciaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existenciaTextBox.Location = new System.Drawing.Point(104, 90);
            this.existenciaTextBox.Name = "existenciaTextBox";
            this.existenciaTextBox.Size = new System.Drawing.Size(176, 22);
            this.existenciaTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuargar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(2, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 66);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::SistemaCotizacionArticulos.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(277, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 60);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuargar
            // 
            this.btnGuargar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuargar.FlatAppearance.BorderSize = 0;
            this.btnGuargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuargar.Image = global::SistemaCotizacionArticulos.Properties.Resources.save;
            this.btnGuargar.Location = new System.Drawing.Point(148, 6);
            this.btnGuargar.Name = "btnGuargar";
            this.btnGuargar.Size = new System.Drawing.Size(75, 60);
            this.btnGuargar.TabIndex = 1;
            this.btnGuargar.UseVisualStyleBackColor = false;
            this.btnGuargar.Click += new System.EventHandler(this.btnGuargar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::SistemaCotizacionArticulos.Properties.Resources._new;
            this.btnNuevo.Location = new System.Drawing.Point(12, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 60);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDnumericUpDown.Location = new System.Drawing.Point(104, 36);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(176, 22);
            this.IDnumericUpDown.TabIndex = 20;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::SistemaCotizacionArticulos.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(292, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 52);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // RegistroExistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 192);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(existenciaLabel);
            this.Controls.Add(this.existenciaTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(articuloIDLabel);
            this.Name = "RegistroExistencia";
            this.Text = "RegistroExistencia";
            ((System.ComponentModel.ISupportInitialize)(this.existenciaArticuloBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource existenciaArticuloBindingSource;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox existenciaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuargar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}