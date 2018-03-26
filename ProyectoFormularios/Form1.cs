using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ReferenciaWEB.ServicioWEBClient WS;
                WS = new ReferenciaWEB.ServicioWEBClient();
                int x = WS.validacion(txtUsuario.Text, txtPass.Text);
                if (x!=0)
                {
                    MessageBox.Show("Credenciales Correctas");
                    FrmMenu MENU = new FrmMenu();
                    MENU.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario / Pass incorrecto");
                    Logger.Mensaje("NO TAAA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Ingreso");
                Logger.Mensaje(ex.Message);                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("es");//recupera informacion sobre referencia cultural

            Assembly a = Assembly.Load("ProyectoFormularios");
            ResourceManager rm=
                new ResourceManager("ProyectoFormularios.Lang.String",a);
            this.Text = rm.GetString("Bienvenido", ci);
            grbAcceso.Text = rm.GetString("CredencialAcceso", ci);
            lblUsuario.Text = rm.GetString("Usuario", ci);
            lblPass.Text = rm.GetString("Contrasena", ci);
            btnAceptar.Text = rm.GetString("Aceptar", ci);
            btnSalir.Text = rm.GetString("Salir", ci);


        }
    }
}
