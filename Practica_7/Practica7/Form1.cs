using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            int puntos = 0;

            if (this.radPorSiempre.Checked)
            {
                puntos++;
            }

            if (this.numHijos.Value == 2)
            {
                puntos++;

            }

            if (this.chk69.Checked)
            {
                puntos++;
            }

            if (this.chkOral.Checked)
            {
                puntos++;
            }
            if (this.chkNormal.Checked) {
                puntos++;
            }
            string fecha = Calendario.SelectionStart.ToString();
            if (fecha == "01/01/2013")
            {
                puntos++;
            }
            string nombre = this.txtNombre.Text;
            string codigo = this.txtCodigo.Text;
            string grupo = this.cmbGrupo.Text;

           MessageBox.Show("El Alumno:  "+nombre+ 
                          "\n\nCon código: " +codigo +
                          "\n\ndel Grupo:  " + grupo +
                          "\n\nTiene  "+ puntos +
                            "  puntos de 5", "Calificación", MessageBoxButtons.OK);
            
            
          

        }

       

     

      
    }
}
