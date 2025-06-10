using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colloquium
{
    public partial class FormCreate : Form
    {
        public static List<int> inf;

        List<string> data;
        public FormCreate()
        {
            InitializeComponent();
        }

        private void textBoxObject_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            inf[0] = Convert.ToInt32(textBoxWidth.Text);
            inf[1] = Convert.ToInt32(textBoxLenght.Text);
            inf[2] = Convert.ToInt32(textBoxHeight.Text);

            inf[3] = Convert.ToInt32(textBoxX.Text);
            inf[4] = Convert.ToInt32(textBoxY.Text);
            inf[5] = Convert.ToInt32(textBoxZ.Text);

            DialogResult = DialogResult.OK;
             Close();
        }

        private void labelData_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
