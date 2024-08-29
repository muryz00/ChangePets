using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto05
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

            cboEspecie.Items.Add("Aves");
            cboEspecie.Items.Add("Gatos");
            cboEspecie.Items.Add("Cachorro");

            cboEspecie.SelectedIndexChanged += CboEspecie_SelectedIndexChanged;
        }

        private void CboEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedEspecie = cboEspecie.SelectedItem.ToString();
           if (selectedEspecie == "Aves")
            {
                cboRaca.Items.Add("Periquito");
                cboRaca.Items.Add("Papagaio");
                cboRaca.Items.Add("Canario");
            }
           else if (selectedEspecie == "Gatos")
            {
                cboRaca.Items.Add("Siames");
                cboRaca.Items.Add("Persa");
                cboRaca.Items.Add("Ragdoll");
            }
           else if (selectedEspecie == "Cachorro")
            {
                cboRaca.Items.Add("SRD");
                cboRaca.Items.Add("Bulldog");
                cboRaca.Items.Add("Golden Retriever");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            cboRaca.Items.Clear();
            string selectedEspecie = cboEspecie.SelectedItem.ToString();
            double Valor;

            Valor = 0;

                
            if(selectedEspecie == "Cachorro" && rdbMacho.Checked)
            {
                Valor = Valor + 250;
            }
            else if (selectedEspecie == "Cachorro"  && rdbFemea.Checked)
            {
                Valor = Valor + 300;
            }
            else if (selectedEspecie == "Gatos" && rdbMacho.Checked)
            {
                Valor = Valor + 200;
            }
            else if (selectedEspecie == "Gatos" && rdbFemea.Checked)
            {
                Valor = Valor + 250;
            }

            lblResultado.Text = Convert.ToString(Valor);
        }
    }
}
