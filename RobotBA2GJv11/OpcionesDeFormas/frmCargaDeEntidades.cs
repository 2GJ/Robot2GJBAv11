using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RobotBA2GJv11.OpcionesDeFormas
{
    public partial class frmCargaDeEntidades : Form
    {
        public frmCargaDeEntidades()
        {
            InitializeComponent();
        }

        private void btoExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Cursor Files|*.txt";
            openFD.Title = "Select a Cursor File";

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                this.txtRutaArchivoExaminar.Text = openFD.FileName;
            }
        }

        private void btoEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtRutaArchivoExaminar.Text == null)
                    MessageBox.Show("Validacion: La ruta del archivo de carga no es valido");

                string LineaCaptura;
                StreamReader FileCaptura = new StreamReader(this.txtRutaArchivoExaminar.Text);
                Int64 y = File.ReadAllLines(this.txtRutaArchivoExaminar.Text).Length;

                cls.FileEntity objEnt = new cls.FileEntity("P_Departamento");
                bool Encabezado = false;
                Int64 Regs = 0;

                while ((LineaCaptura = FileCaptura.ReadLine()) != null)
                {
                    char tmpChar = '\t';
                    char[] Separador = new char[] { tmpChar };
                    string[] strLineArzay = LineaCaptura.Split(Separador, StringSplitOptions.RemoveEmptyEntries);

                    if (Encabezado == false)
                    {
                        for (Int16 i = 0; i < strLineArzay.Length; i++)
                        {
                            cls.ColFileEntity objColEnt = new cls.ColFileEntity(i, strLineArzay[i]);
                            objEnt.ColumnsEntity.Add(objColEnt);
                        }
                        Encabezado = true;
                    }
                    else
                    {
                        cls.RowsFileEntity objRowEntity = new cls.RowsFileEntity(Regs);
                        objEnt.RowsEntity.Add(objRowEntity);
                        Regs++;

                        for (Int16 i = 0; i < strLineArzay.Length; i++)
                        {
                            cls.RowColFileEntity objRowColData = new cls.RowColFileEntity(i, strLineArzay[i]);
                            objRowEntity.Values.Add(objRowColData);
                        }
                    }
                }

                
                this.dtGridDatos.ColumnCount = objEnt.ColumnsEntity.Count;
                this.dtGridDatos.ColumnHeadersVisible = true;
                this.dtGridDatos.DefaultCellStyle.ForeColor = Color.Red;
                //Adjust

               int cont = 0;
                foreach (cls.ColFileEntity Col  in objEnt.ColumnsEntity)
                { 
                    dtGridDatos.Columns[cont].Name = Col.NameCol;
                    cont++;
                }
                foreach (cls.RowsFileEntity rows in objEnt.RowsEntity)
                {
                    cont = 0;
                    string[] r = new string[rows.Values.Count];
                    foreach(cls.RowColFileEntity row in rows.Values)
                    {
                        r[cont] = row.Value;
                        cont++;
                    }
                    dtGridDatos.Rows.Add(r);
                }


                RobotSOA2GJv11.CapaSOA objSOA = new RobotSOA2GJv11.CapaSOA();
                objSOA.WS_GetEntityAsString("P_Departamento");


            }
            catch (Exception e1)
            {
                MessageBox.Show("Exception: " + e1.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCargaDeEntidades_Load(object sender, EventArgs e)
        {

        }
    }
}
