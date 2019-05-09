using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApplication
{
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = lstCity.GetItemText(lstCity.SelectedItem);
            MessageBox.Show("You've selected: " + text);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            string address = txtAddress.Text;

            MessageBox.Show(name + address);
        }
    }
}
