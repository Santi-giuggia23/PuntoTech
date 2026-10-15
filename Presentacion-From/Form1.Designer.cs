
namespace Presentacion_From
{
    partial class Control
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            this.dgvArticulo.AllowUserToAddRows = false;
            this.dgvArticulo.AllowUserToDeleteRows = false;
            this.dgvArticulo.AllowUserToResizeColumns = false;
            this.dgvArticulo.AllowUserToResizeRows = false;
            this.dgvArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Location = new System.Drawing.Point(12, 65);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.RowHeadersWidth = 51;
            this.dgvArticulo.RowTemplate.Height = 24;
            this.dgvArticulo.Size = new System.Drawing.Size(899, 320);
            this.dgvArticulo.TabIndex = 2;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxArticulo.Location = new System.Drawing.Point(927, 65);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(349, 320);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            this.pbxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.Location = new System.Drawing.Point(927, 5);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(349, 55);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 8;
            this.pbxLogo.TabStop = false;
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.FlatAppearance.BorderSize = 3;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(12, 391);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 37);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.Agregar_Click);
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.FlatAppearance.BorderSize = 3;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(564, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(138, 24);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDetalle.FlatAppearance.BorderSize = 3;
            this.btnDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDetalle.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDetalle.Location = new System.Drawing.Point(528, 391);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(122, 37);
            this.btnDetalle.TabIndex = 5;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.FlatAppearance.BorderSize = 3;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(789, 391);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 37);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.FlatAppearance.BorderSize = 3;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(258, 391);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 37);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFiltro.Font = new System.Drawing.Font("Arial", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFiltro.Location = new System.Drawing.Point(31, 21);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(54, 19);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Filtro:";
            this.txtBuscar.FormattingEnabled = true;
            this.txtBuscar.Location = new System.Drawing.Point(91, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(457, 24);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBuscar_KeyPress);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1282, 449);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.dgvArticulo);
            this.MinimumSize = new System.Drawing.Size(1300, 496);
            this.Name = "Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox txtBuscar;
    }
}
