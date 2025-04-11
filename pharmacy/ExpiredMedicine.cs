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
    public partial class ExpiredMedicine : UserControl
    {
        Panel MainPanel;
        public ExpiredMedicine(Panel mainPanel)
        {
            InitializeComponent();
            MainPanel = mainPanel;
        }

        private void ExpiredMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
