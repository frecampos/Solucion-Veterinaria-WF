using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace ProyectoFormularios
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatasetRegistros.BUSCAR' Puede moverla o quitarla según sea necesario.
            this.BUSCARTableAdapter.Fill(this.DatasetRegistros.BUSCAR,"0");
            this.reportViewer1.RefreshReport();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (txtEspecilidad.Text.Trim().Length==0)
            {
                this.BUSCARTableAdapter.Fill(this.DatasetRegistros.BUSCAR, "0");
            }
            else
            {
                this.BUSCARTableAdapter.Fill(this.DatasetRegistros.BUSCAR,
                    txtEspecilidad.Text);
            }            
            this.reportViewer1.RefreshReport();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                string cadena = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Veterinaria;Persist Security Info=True;User ID=sa;Password=Duocadmin2018";
                SqlConnection cone = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cone;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BUSCAR";
                cmd.Parameters.Add("@especialidad", SqlDbType.NVarChar, 50)
                    .Value =(txtEspecilidad.Text.Trim().Length==0
                             ? "0": txtEspecilidad.Text);
                cone.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cone.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(@"d:\Exportar.csv");
                int cantidad_filas=dataGridView1.Rows.Count-1;
                int cantidad_columnas=dataGridView1.ColumnCount;
                for (int f = 0; f < cantidad_filas; f++)
                {
                    string linea = "";
                    for (int c = 0; c < cantidad_columnas; c++)
                    {
                        linea = linea + 
                            dataGridView1.Rows[f].Cells[c].Value.ToString()+";";
                    }
                    linea = linea + Environment.NewLine;
                    File.AppendAllText(@"d:\Exportar.csv", linea);
                }
                MessageBox.Show("OK exportado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
