using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente_Proyecto_Final
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(tbProducto.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox.Items.RemoveAt(listBox.Items.Count - 1);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double suma = 0;
            foreach (object item in listBox.Items)
            {
                suma += Convert.ToDouble(item);
                tbPagar.Text = suma.ToString();
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                //Form pagoEfectivo = new Form2();
                //pagoEfectivo.Show();
            }
            else
            {
                //Form pagoTarjeta = new Form3();
                //pagoTarjeta.Show();
            }
        }
    }
}
