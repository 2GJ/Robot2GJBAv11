namespace RobotBA2GJv11.OpcionesDeFormas
{
    partial class frmCargaDeEntidades
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
            System.Windows.Forms.Button btoEjecutar;
            System.Windows.Forms.Button btoExaminar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaDeEntidades));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRutaArchivoExaminar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.dtGridDatos = new System.Windows.Forms.DataGridView();
            btoEjecutar = new System.Windows.Forms.Button();
            btoExaminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btoEjecutar
            // 
            btoEjecutar.AutoSize = true;
            btoEjecutar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            btoEjecutar.Location = new System.Drawing.Point(0, 0);
            btoEjecutar.Name = "btoEjecutar";
            btoEjecutar.Size = new System.Drawing.Size(122, 62);
            btoEjecutar.TabIndex = 0;
            btoEjecutar.Text = "Ejecutar";
            btoEjecutar.UseVisualStyleBackColor = false;
            btoEjecutar.Click += new System.EventHandler(this.btoEjecutar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRutaArchivoExaminar);
            this.groupBox1.Controls.Add(btoExaminar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ruta Archivo";
            // 
            // btoExaminar
            // 
            btoExaminar.AutoSize = true;
            btoExaminar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            btoExaminar.Location = new System.Drawing.Point(379, 14);
            btoExaminar.Name = "btoExaminar";
            btoExaminar.Size = new System.Drawing.Size(122, 28);
            btoExaminar.TabIndex = 2;
            btoExaminar.Text = "Examinar";
            btoExaminar.UseVisualStyleBackColor = false;
            btoExaminar.Click += new System.EventHandler(this.btoExaminar_Click);
            // 
            // txtRutaArchivoExaminar
            // 
            this.txtRutaArchivoExaminar.Location = new System.Drawing.Point(6, 19);
            this.txtRutaArchivoExaminar.Name = "txtRutaArchivoExaminar";
            this.txtRutaArchivoExaminar.Size = new System.Drawing.Size(367, 20);
            this.txtRutaArchivoExaminar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(btoEjecutar);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1647, 63);
            this.panel1.TabIndex = 2;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.dtGridDatos);
            this.gbDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDatos.Location = new System.Drawing.Point(12, 125);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(1032, 490);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // dtGridDatos
            // 
            this.dtGridDatos.AllowUserToAddRows = false;
            this.dtGridDatos.BackgroundColor = System.Drawing.Color.Silver;
            this.dtGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDatos.Location = new System.Drawing.Point(18, 31);
            this.dtGridDatos.Name = "dtGridDatos";
            this.dtGridDatos.Size = new System.Drawing.Size(995, 444);
            this.dtGridDatos.TabIndex = 1;
            // 
            // frmCargaDeEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1056, 625);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargaDeEntidades";
            this.Text = "Carga Entidades";
            this.Load += new System.EventHandler(this.frmCargaDeEntidades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRutaArchivoExaminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.DataGridView dtGridDatos;
    }
}