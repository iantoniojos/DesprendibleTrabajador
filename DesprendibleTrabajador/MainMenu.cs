using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesprendibleTrabajador
{
    public partial class MainMenu : Form
    {
        Nomina myNomina = new Nomina(); 
        public MainMenu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSalarioDia.Text = cmbCargo.Items[cmbCargo.SelectedIndex].ToString() == "Electricista" ? "20000" :
                cmbCargo.Items[cmbCargo.SelectedIndex].ToString() == "Programador" ? "80000" :
                cmbCargo.Items[cmbCargo.SelectedIndex].ToString() == "Abogado" ? "12000" :
                cmbCargo.Items[cmbCargo.SelectedIndex].ToString() == "Arquitecta" ? "40000" :
                cmbCargo.Items[cmbCargo.SelectedIndex].ToString() == "Aseador" ? "40000" : "0";


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myNomina.Nombre = txtNombre.Text;
                myNomina.Identificacion = Convert.ToInt32(txtID.Text);
                myNomina.Cargo = cmbCargo.Items[cmbCargo.SelectedIndex].ToString();
                myNomina.AsignacionDias = Decimal.Parse(txtSalarioDia.Text);
                myNomina.DiasLaborados = Convert.ToInt32(txtDiasTrabajados.Text);
                if (rbMasculino.Checked == true)
                    myNomina.Genero = rbMasculino.Text;
                if (rbFemenino.Checked == true)
                    myNomina.Genero = rbFemenino.Text;
                if (rbNoBinario.Checked == true)
                    myNomina.Genero = rbNoBinario.Text;


                MessageBox.Show("Se guardo el registro");
            }
            catch
            {
                MessageBox.Show("Faltan datos por ingresar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Desprendible myDesprendible = new Desprendible();
            myDesprendible.Show();
            this.Hide();

            myDesprendible.lblNombre.Text = myNomina.Nombre;
            myDesprendible.lblID.Text = myNomina.Identificacion.ToString();
            myDesprendible.lblCargo.Text = myNomina.Cargo;
            myDesprendible.lblGenero.Text = myNomina.Genero;
            myDesprendible.lblDiasLaborados.Text = myNomina.DiasLaborados.ToString("N");
            myDesprendible.lblSalarioDia.Text = myNomina.AsignacionDias.ToString("C");
            myDesprendible.lblValorDevengado.Text = myNomina.CalcularNomina(myNomina.DiasLaborados, myNomina.AsignacionDias).ToString("C");

            DateTime fecha = DateTime.Today;
            string Formato = "MMM d yyyy ";

            myDesprendible.lblFecha.Text = fecha.ToString(Formato);
        }
    }
}
