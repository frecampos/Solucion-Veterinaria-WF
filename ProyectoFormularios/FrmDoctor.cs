﻿using System;
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
    public partial class FrmDoctor : Form
    {
        public FrmDoctor()
        {
            InitializeComponent();
        }

        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            miControl1.Mensaje = "Busqueda de Doctores";
        }
    }
}
