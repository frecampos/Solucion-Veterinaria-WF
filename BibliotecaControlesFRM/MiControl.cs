using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//cliente sql
namespace BibliotecaControlesFRM
{
    public partial class MiControl : UserControl
    {
        public MiControl()
        {
            InitializeComponent();
        }
        public string Mensaje { get; set; }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string rut = txtRut.Text;
            SqlConnection cone=null;
            try
            {
                string cadena = @"Data Source=localhost\sqlexpress;Initial Catalog=Veterinaria;Persist Security Info=True;User ID=sa;Password=Duocadmin2018";
                cone = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cone;
                cmd.CommandText =
                    string.Format("select * from doctor where rut='{0}'",txtRut.Text);
                cone.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MessageBox.Show(dr[1].ToString() + " " + dr[2].ToString()+" "+dr[3].ToString());
                    cone.Close();
                    return;
                }
                MessageBox.Show("no esta");
                cone.Close();
            }
            catch (Exception ex)
            {
                if (cone.State==ConnectionState.Open)
                {
                    cone.Close();
                }
                MessageBox.Show("error");
            }
        }
    }
}
