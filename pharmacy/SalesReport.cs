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

    public partial class SalesReport : UserControl
    {
        Panel MainPanel;
        public SalesReport(Panel panel)
        {
            InitializeComponent();
            MainPanel = panel;
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            ViewDetails view = new ViewDetails(MainPanel);
            MainPanel.Controls.Add(view);
        }
    }
}
