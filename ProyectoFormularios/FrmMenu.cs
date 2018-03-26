using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFormularios
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sstHora.Text = ""+DateTime.Now;
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = MessageBox.Show("Salir Sistema", "Desea Salir?",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if (resp == DialogResult.OK)
            {
                MessageBox.Show("Quiere Salir");
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("No Quiere Salir");
                e.Cancel = true;
            }
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {

            
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresoMascotas m = new FrmIngresoMascotas();
            m.MdiParent= this;//el formulario padre es "este"
            m.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmIngresoMascotas m = new FrmIngresoMascotas();
            m.MdiParent = this;
            m.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Salir Sistema", "Desea Salir?",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if (resp == DialogResult.OK)
            {
                MessageBox.Show("Quiere Salir");
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("No Quiere Salir");
                
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmAgendarAtencion at = 
                new FrmAgendarAtencion();
            at.MdiParent = this;
            at.Show();
        }
    }
}
