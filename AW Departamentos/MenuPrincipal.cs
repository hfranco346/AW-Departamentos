﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AW_Departamentos
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnListarDepartamentos_Click(object sender, EventArgs e)
        {
            ListarDepartamentos listarDepartamentos = new ListarDepartamentos();
            listarDepartamentos.Show();
        }
    }
}
