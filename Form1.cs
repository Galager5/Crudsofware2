using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudSofware2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.nombres = txtNombre.Text;
            persona.apellidos = txtNombre.Text;
            persona.grado = txtGrado.Text;
            persona.celular = txtCelular.Text;

            
         if(dataGridView1.SelectedRows.Count == 1)
            {

            
            int matricula = Convert.ToInt32(dataGridView1.CurrentRow.Cells["matricula"].Value);
            if (matricula != null) 
            {
                persona.matricula = matricula;
                int result = Personadal.ModificarPersona(persona);

                if (result > 0)
                {
                    MessageBox.Show("exito al modificar los datos");
                }
                else
                {
                    MessageBox.Show("no se modifico los datos");
                }
            }
            }
            else 
            {
                
                int result = Personadal.AgregarPersona(persona);

                if (result > 0)
                {
                    MessageBox.Show("exito al guardar los datos");
                }
                else
                {
                    MessageBox.Show("no se guardo los datos");
                }
            }
            refressPantalla();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refressPantalla();
            txtId.Enabled = false;
        }
        public void refressPantalla()
        {
            dataGridView1.DataSource = Personadal.PresentarRegistro();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["matricula"].Value);
            txtNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombres"].Value);
            txtApellidos.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["apellidos"].Value);
            txtGrado.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["grado"].Value);
            txtCelular.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["celular"].Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtGrado.Clear();
            txtCelular.Clear();
            dataGridView1.CurrentCell = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {


                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["matricula"].Value);
                int resultado = Personadal.EliminarPersona(id);
                    if(resultado > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                }
                    else
                {
                    MessageBox.Show("No se elimino el registro");
                }
            }
            refressPantalla();
    }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
