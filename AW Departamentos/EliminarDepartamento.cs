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
    public partial class EliminarDepartamento : Form
    {
        Departamentos departamentos = new Departamentos();
        public EliminarDepartamento()
        {
            InitializeComponent();
        }

        private void btnCargarDepartamentos_Click(object sender, EventArgs e)
        {
            List<Departamento> departamento = departamentos.LeerTodos();
            lstDepartamentos.Items.Clear();

            if (departamento.Any())
            {
                departamento.ForEach(depto => lstDepartamentos.Items.Add(depto.name));
            }
            else
                lstDepartamentos.Items.Add("¡Error al cargar los departamentos!");

            btnEliminarDepartamento.Enabled = true;
        }

        private void btnEliminarDepartamento_Click(object sender, EventArgs e)
        {
            Departamento departamento = new Departamento();

            if (lstDepartamentos.SelectedIndex == -1)
            {
                MessageBox.Show("Favor seleccionar un departamento antes de ejecutar la acción de eliminar", "Información");
            }
            else
            {
                departamento.name = lstDepartamentos.SelectedItem.ToString();

                if (departamentos.Eliminar(departamento))
                {
                    lblEstadoEliminacion.Text = "¡Departamento eliminado exitosamente";
                    btnEliminarDepartamento.Enabled = false;
                }
                else
                    lblEstadoEliminacion.Text = "¡Ocurrió un error al momento de eliminar el departamento!";
            }
        }
    }
}
