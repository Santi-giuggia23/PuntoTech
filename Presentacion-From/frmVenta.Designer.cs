namespace Presentacion_From
{
    partial class frmVenta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblArticulo = new System.Windows.Forms.Label();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblStockValor = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.colArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarItem = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblArticulo.Location = new System.Drawing.Point(30, 25);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(90, 19);
            this.lblArticulo.TabIndex = 0;
            this.lblArticulo.Text = "Artículo:";
            this.cboArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(130, 23);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(300, 24);
            this.cboArticulo.TabIndex = 0;
            this.cboArticulo.SelectedIndexChanged += new System.EventHandler(this.cboArticulo_SelectedIndexChanged);
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location = new System.Drawing.Point(450, 25);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(150, 19);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "Stock disponible:";
            this.lblStockValor.AutoSize = true;
            this.lblStockValor.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblStockValor.Location = new System.Drawing.Point(600, 25);
            this.lblStockValor.Name = "lblStockValor";
            this.lblStockValor.Size = new System.Drawing.Size(20, 19);
            this.lblStockValor.TabIndex = 2;
            this.lblStockValor.Text = "-";
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.Location = new System.Drawing.Point(30, 68);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(90, 19);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            this.numCantidad.Location = new System.Drawing.Point(130, 66);
            this.numCantidad.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            this.numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(80, 22);
            this.numCantidad.TabIndex = 1;
            this.numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.btnAgregarItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarItem.Location = new System.Drawing.Point(230, 64);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(160, 28);
            this.btnAgregarItem.TabIndex = 2;
            this.btnAgregarItem.Text = "Agregar al carrito";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArticulo,
            this.colCantidad,
            this.colPrecio,
            this.colSubtotal});
            this.dgvDetalle.Location = new System.Drawing.Point(30, 110);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersWidth = 25;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(620, 250);
            this.dgvDetalle.TabIndex = 3;
            this.colArticulo.HeaderText = "Artículo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.ReadOnly = true;
            this.colArticulo.Width = 220;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 90;
            this.colPrecio.HeaderText = "Precio Unit.";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 130;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 130;
            this.btnQuitarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuitarItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnQuitarItem.Location = new System.Drawing.Point(30, 375);
            this.btnQuitarItem.Name = "btnQuitarItem";
            this.btnQuitarItem.Size = new System.Drawing.Size(180, 30);
            this.btnQuitarItem.TabIndex = 4;
            this.btnQuitarItem.Text = "Quitar seleccionado";
            this.btnQuitarItem.UseVisualStyleBackColor = true;
            this.btnQuitarItem.Click += new System.EventHandler(this.btnQuitarItem_Click);
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(400, 380);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 22);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            this.lblTotalValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalValor.Location = new System.Drawing.Point(475, 380);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(60, 22);
            this.lblTotalValor.TabIndex = 6;
            this.lblTotalValor.Text = "$0,00";
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.Location = new System.Drawing.Point(370, 415);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 35);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar Venta";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(520, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 35);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 480);
            this.MinimumSize = new System.Drawing.Size(696, 519);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblTotalValor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnQuitarItem);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.btnAgregarItem);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblStockValor);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.cboArticulo);
            this.Controls.Add(this.lblArticulo);
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.ComboBox cboArticulo;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblStockValor;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Button btnQuitarItem;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
