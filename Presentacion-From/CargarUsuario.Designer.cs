namespace Presentacion_From
{
    partial class CargarUsuario
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
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.Location = new System.Drawing.Point(30, 30);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(150, 19);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblContrasenia.Location = new System.Drawing.Point(30, 75);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(120, 19);
            this.lblContrasenia.TabIndex = 1;
            this.lblContrasenia.Text = "Contraseña:";
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(30, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblRol.Location = new System.Drawing.Point(30, 165);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(50, 19);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol:";
            this.txtNombreUsuario.Location = new System.Drawing.Point(210, 28);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(180, 22);
            this.txtNombreUsuario.TabIndex = 0;
            this.txtContrasenia.Location = new System.Drawing.Point(210, 73);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(180, 22);
            this.txtContrasenia.TabIndex = 1;
            this.txtNombre.Location = new System.Drawing.Point(210, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 22);
            this.txtNombre.TabIndex = 2;
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(210, 163);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(180, 24);
            this.cboRol.TabIndex = 3;
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(95, 220);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 30);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(240, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 280);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.CargarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
