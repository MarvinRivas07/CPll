using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace NotasAlumnos
{
    public partial class Form1 : Form
    {

        ArrayList RegistroNotas = new ArrayList();
        int indice, numcod = 0;
        string codigo;
        double promedio;

        void LimpiarObjetos()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtasignatura.Clear();
            txtLab.Clear();
            txtParcial.Clear();
        }
     
        void RegistrarNotas ()
        {
            codigo = " Est-00 " + numcod;
            numcod++;
            RegistroNotas.Add(codigo);
            RegistroNotas.Add(txtnombre.Text);
            RegistroNotas.Add(txtapellido.Text);
            RegistroNotas.Add(txtasignatura.Text);
            RegistroNotas.Add(txtLab.Text);
            RegistroNotas.Add(txtParcial.Text);
            promedio = ((Convert.ToDouble(txtLab.Text) + Convert.ToDouble(txtParcial.Text))/2);
            RegistroNotas.Add(promedio);
        }
        void  MostrarRegistros()
        {
            string Regdatos = "";
            for (int i=0; i < RegistroNotas.Count; i+=7)
            {
                Regdatos = Regdatos + RegistroNotas[i].ToString() + " " + RegistroNotas[i+1] + " " + RegistroNotas[i+2] + " " + RegistroNotas[i + 3] + 
                    " " + RegistroNotas[i + 4] + " " + RegistroNotas[i + 5] + " " + RegistroNotas[i + 6] + "\n";
            }
            rtbRegistros.Text = Regdatos;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            RegistrarNotas();
            MostrarRegistros();
            LimpiarObjetos();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
