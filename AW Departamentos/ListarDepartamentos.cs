using System;
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
    public partial class ListarDepartamentos : Form
    {
        public ListarDepartamentos()
        {
            InitializeComponent();
        }

        private void ListarDepartamentos_Load(object sender, EventArgs e)
        {
            Departamentos departamentos = new Departamentos();

            List<Departamento> departamento = departamentos.LeerTodos();

            if (departamento.Any())
            {
                txtDepartamentos.AppendText("Id \t\t Nombre \t\t\t Nombre del grupo\n");

                departamento.ForEach(depto => txtDepartamentos.AppendText(depto.id.ToString() + "\t\t" + depto.name.ToString() + "\t\t\t" + depto.groupName.ToString() + "\n"));
            }
            else
                txtDepartamentos.AppendText("Error al obtener los registros de los departamentos");
        }
    }
}
