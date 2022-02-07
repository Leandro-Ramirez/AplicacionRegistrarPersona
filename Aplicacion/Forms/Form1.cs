#region Usos
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Forms
{
    public partial class Form1 : Form
    {
        #region Variables Globales
        int i = 0;
        List<Persona> lista = new List<Persona>();
        #endregion

        #region Inicializar Form1
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Guardar Persona
        public void guardarPersona()
        {
            Persona persona1 = new Persona(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text));

            lista.Add(persona1);

            dgvPersona.DataSource = null;
            dgvPersona.DataSource = lista;
        }
        #endregion

        #region Boton Guardar Click
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            guardarPersona();
        }
        #endregion

        #region Boton Salir Click
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Data Grid View CellClick
        private void DgvPersona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;

            if (i != -1)
            {
                MessageBox.Show("HOLA ME LLAMO : " + (string)dgvPersona.Rows[i].Cells[0].Value + " " + (string)dgvPersona.Rows[i].Cells[1].Value + "y mi edad es " + (int)dgvPersona.Rows[i].Cells[2].Value);
            }
        }
        #endregion

        #region Boton Mostrar Click
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            dgvPersona.DataSource = null;
            dgvPersona.DataSource = lista;
        }
        #endregion

        #region Boton Borrar Click
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El indice es : " + i);
            if (i != -1)
            {
                lista.RemoveAt(i);
                //dataGridView1.Rows.RemoveAt(i);                                                                                                                   
                btnBorrar.PerformClick();
            }
        }
        #endregion
    }
}