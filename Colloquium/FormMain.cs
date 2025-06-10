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
    public partial class FormMain : Form
    {
        Sea sea;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreateSea_Click(object sender, EventArgs e)
        {
            FormCreate formCreate = new FormCreate();
            if (formCreate.ShowDialog() == DialogResult.OK)
            {
                sea = new Sea(
                    FormCreate.WidthValue,
                    FormCreate.LengthValue,
                    FormCreate.HeightValue,
                    FormCreate.XCoord,
                    FormCreate.YCoord,
                    FormCreate.ZCoord);
            }
            listBoxObject.Items.Add(sea.Print());
        }

        private void buttonCreateIsland_Click(object sender, EventArgs e)
        {

        }
    }
}
