using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moneyConverter
{
    public partial class MoneyConverter : Form
    {
        public MoneyConverter()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(txtValor.Text);
            string moeda = cmbMoeda.SelectedItem.ToString();
            decimal resultado = 0;

            if (moeda == "Real")
            {
                resultado = valor / 0.20m;
            }
            else if (moeda == "Euro")
            {
                resultado = valor / 1.06m;
            }

            lblValorConvertido.Text = Convert.ToString(resultado);
        }
    }
}
