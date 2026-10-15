
namespace Presentacion_From
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.menMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.menCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.menUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menHistorialVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1341, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menArticulos,
            this.menMarca,
            this.menCategoria,
            this.menUsuarios});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.gestionToolStripMenuItem.Text = "Gestión";
            this.menArticulos.Name = "menArticulos";
            this.menArticulos.Size = new System.Drawing.Size(157, 26);
            this.menArticulos.Text = "Artículos";
            this.menArticulos.Click += new System.EventHandler(this.menArticulos_Click);
            this.menMarca.Name = "menMarca";
            this.menMarca.Size = new System.Drawing.Size(157, 26);
            this.menMarca.Text = "Marca";
            this.menMarca.Click += new System.EventHandler(this.menMarca_Click);
            this.menCategoria.Name = "menCategoria";
            this.menCategoria.Size = new System.Drawing.Size(157, 26);
            this.menCategoria.Text = "Categoría";
            this.menCategoria.Click += new System.EventHandler(this.menCategoria_Click);
            this.menUsuarios.Name = "menUsuarios";
            this.menUsuarios.Size = new System.Drawing.Size(157, 26);
            this.menUsuarios.Text = "Usuarios";
            this.menUsuarios.Click += new System.EventHandler(this.menUsuarios_Click);
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menRegistrarVenta,
            this.menHistorialVentas});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.menRegistrarVenta.Name = "menRegistrarVenta";
            this.menRegistrarVenta.Size = new System.Drawing.Size(190, 26);
            this.menRegistrarVenta.Text = "Registrar Venta";
            this.menRegistrarVenta.Click += new System.EventHandler(this.menRegistrarVenta_Click);
            this.menHistorialVentas.Name = "menHistorialVentas";
            this.menHistorialVentas.Size = new System.Drawing.Size(190, 26);
            this.menHistorialVentas.Text = "Historial de Ventas";
            this.menHistorialVentas.Click += new System.EventHandler(this.menHistorialVentas_Click);
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnSalir,
            this.btnCerrarSesion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1341, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.btnCerrarSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCerrarSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(105, 24);
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.ToolTipText = "Cerrar la sesión actual y volver a la pantalla de inicio";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSalir.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(48, 24);
            this.btnSalir.Text = "Salir";
            this.btnSalir.ToolTipText = "Cerrar la aplicación";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1341, 615);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1359, 662);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PuntoTech";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menArticulos;
        private System.Windows.Forms.ToolStripMenuItem menMarca;
        private System.Windows.Forms.ToolStripMenuItem menCategoria;
        private System.Windows.Forms.ToolStripMenuItem menUsuarios;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem menHistorialVentas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnCerrarSesion;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}
