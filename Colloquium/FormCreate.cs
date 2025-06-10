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
        public static int WidthValue = 0;
        public static int LengthValue = 0;
        public static int HeightValue = 0;
        public static int XCoord = 0;
        public static int YCoord = 0;
        public static int ZCoord = 0;

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
            WidthValue = Convert.ToInt32(textBoxWidth.Text);
            LengthValue = Convert.ToInt32(textBoxLenght.Text);
            HeightValue = Convert.ToInt32(textBoxHeight.Text);

            XCoord = Convert.ToInt32(textBoxX.Text);
            YCoord = Convert.ToInt32(textBoxY.Text);
            ZCoord = Convert.ToInt32(textBoxZ.Text);

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
