using Lab8.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void AgregarL_Click(object sender, EventArgs e)
        {
            PanelAgregarLocal.Visible = true;
        }

        private void AgregarLocal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" | textHoraAtencion.Text == "" | textnIdentificador.Text == "")
            {
                MessageBox.Show("Rellene todos los datos por favor.");
            }
            else
            {
                PanelCategoria.Visible = true; // Ahora tiene que legir una caterogia que es
            }


        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //DIFERENTES CATEGORIAS.
        private void btnContinuar2_Click(object sender, EventArgs e)
        {
            //Ver como lo hacer para que tenga que elelgir categoria.
            string var = "";
            int indice = comboCategoria.SelectedIndex;
            var = comboCategoria.Items[indice].ToString();
            if(var == "Restaurant")
            {
                PanelRest.Visible = true;
                Restaurant restaurant = new Restaurant(textName.Text,textnIdentificador.Text,textHoraAtencion.Text,txtBool.Text);
            }

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            if (txtBool.Text == "")
            {
                MessageBox.Show("Por favor responder.");
            }
            else//Mostrar panel principal
            {
                PanelAgregarLocal.Visible = false;
                PanelCategoria.Visible = false;
                PanelRest.Visible = false;
            }
        }

        private void RevisarInf_Click(object sender, EventArgs e) //Tengo que mostrar toda la informacion de todas las clases.
        {

        }
    }
}
