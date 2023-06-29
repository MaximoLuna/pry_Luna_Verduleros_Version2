namespace pry_Luna_Verduleros
{
    partial class frmVentas
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
            this.components = new System.ComponentModel.Container();
            this.vERDULEROSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vERDULEROSDataSet = new pry_Luna_Verduleros.VERDULEROSDataSet();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblFechas = new System.Windows.Forms.Label();
            this.lblKilos = new System.Windows.Forms.Label();
            this.dtpFechas = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.mrcVenta = new System.Windows.Forms.GroupBox();
            this.nudKilos = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.vERDULEROSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vERDULEROSDataSet)).BeginInit();
            this.mrcVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilos)).BeginInit();
            this.SuspendLayout();
            // 
            // vERDULEROSDataSetBindingSource
            // 
            this.vERDULEROSDataSetBindingSource.DataSource = this.vERDULEROSDataSet;
            this.vERDULEROSDataSetBindingSource.Position = 0;
            // 
            // vERDULEROSDataSet
            // 
            this.vERDULEROSDataSet.DataSetName = "VERDULEROSDataSet";
            this.vERDULEROSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(64, 19);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(132, 21);
            this.cmbVendedor.TabIndex = 1;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(277, 19);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 2;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(8, 22);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 4;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(221, 22);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 5;
            this.lblProducto.Text = "Producto";
            // 
            // lblFechas
            // 
            this.lblFechas.AutoSize = true;
            this.lblFechas.Location = new System.Drawing.Point(8, 63);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(42, 13);
            this.lblFechas.TabIndex = 6;
            this.lblFechas.Text = "Fechas";
            // 
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.Location = new System.Drawing.Point(221, 63);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(29, 13);
            this.lblKilos.TabIndex = 7;
            this.lblKilos.Text = "Kilos";
            // 
            // dtpFechas
            // 
            this.dtpFechas.Location = new System.Drawing.Point(64, 63);
            this.dtpFechas.Name = "dtpFechas";
            this.dtpFechas.Size = new System.Drawing.Size(132, 20);
            this.dtpFechas.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(224, 90);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // mrcVenta
            // 
            this.mrcVenta.Controls.Add(this.nudKilos);
            this.mrcVenta.Controls.Add(this.cmbProducto);
            this.mrcVenta.Controls.Add(this.btnGuardar);
            this.mrcVenta.Controls.Add(this.cmbVendedor);
            this.mrcVenta.Controls.Add(this.dtpFechas);
            this.mrcVenta.Controls.Add(this.lblKilos);
            this.mrcVenta.Controls.Add(this.lblVendedor);
            this.mrcVenta.Controls.Add(this.lblFechas);
            this.mrcVenta.Controls.Add(this.lblProducto);
            this.mrcVenta.Location = new System.Drawing.Point(12, 12);
            this.mrcVenta.Name = "mrcVenta";
            this.mrcVenta.Size = new System.Drawing.Size(410, 122);
            this.mrcVenta.TabIndex = 10;
            this.mrcVenta.TabStop = false;
            this.mrcVenta.Text = "Venta";
            // 
            // nudKilos
            // 
            this.nudKilos.Location = new System.Drawing.Point(277, 56);
            this.nudKilos.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudKilos.Name = "nudKilos";
            this.nudKilos.Size = new System.Drawing.Size(62, 20);
            this.nudKilos.TabIndex = 11;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 141);
            this.Controls.Add(this.mrcVenta);
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vERDULEROSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vERDULEROSDataSet)).EndInit();
            this.mrcVenta.ResumeLayout(false);
            this.mrcVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.DateTimePicker dtpFechas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource vERDULEROSDataSetBindingSource;
        private VERDULEROSDataSet vERDULEROSDataSet;
        private System.Windows.Forms.GroupBox mrcVenta;
        private System.Windows.Forms.NumericUpDown nudKilos;
    }
}

