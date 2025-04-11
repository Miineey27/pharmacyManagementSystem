using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy
{
    public partial class Medicines : UserControl
    {

        Panel MainPanel;
        public Medicines(Panel panel)
        {

            InitializeComponent();
            MainPanel = panel;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear(); // remove current page
            Add addPage = new Add(MainPanel); // pass panel again
            MainPanel.Controls.Add(addPage); // show AddMedicine
        }
    }
}
