namespace RobotBA2GJv11
{
    partial class frmRobot2GJv11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRobot2GJv11));
            this.btoCargaMasivaEntidades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btoCargaMasivaEntidades
            // 
            this.btoCargaMasivaEntidades.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btoCargaMasivaEntidades.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btoCargaMasivaEntidades.Location = new System.Drawing.Point(12, 12);
            this.btoCargaMasivaEntidades.Name = "btoCargaMasivaEntidades";
            this.btoCargaMasivaEntidades.Size = new System.Drawing.Size(145, 45);
            this.btoCargaMasivaEntidades.TabIndex = 0;
            this.btoCargaMasivaEntidades.Text = "Carga Entidades";
            this.btoCargaMasivaEntidades.UseVisualStyleBackColor = false;
            this.btoCargaMasivaEntidades.Click += new System.EventHandler(this.btoCargaMasivaEntidades_Click);
            // 
            // frmRobot2GJv11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1426, 635);
            this.Controls.Add(this.btoCargaMasivaEntidades);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRobot2GJv11";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot 2GJ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btoCargaMasivaEntidades;
    }
}

