
namespace Presentacion_From
{
    partial class frmMarca
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
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.SuspendLayout();
            this.dgvMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(12, 12);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.RowHeadersWidth = 51;
            this.dgvMarca.RowTemplate.Height = 24;
            this.dgvMarca.Size = new System.Drawing.Size(392, 297);
            this.dgvMarca.TabIndex = 0;
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.FlatAppearance.BorderSize = 3;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(33, 395);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 37);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.FlatAppearance.BorderSize = 3;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(258, 395);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 37);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDetalle.FlatAppearance.BorderSize = 3;
            this.btnDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDetalle.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDetalle.Location = new System.Drawing.Point(258, 335);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(122, 37);
            this.btnDetalle.TabIndex = 2;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.FlatAppearance.BorderSize = 3;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(33, 335);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 37);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(421, 462);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvMarca);
            this.MinimumSize = new System.Drawing.Size(439, 509);
            this.Name = "frmMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.frmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnAgregar;
    }
}
