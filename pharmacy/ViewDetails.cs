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
    public partial class ViewDetails : UserControl
    {
        Panel MainPanel;
        public ViewDetails(Panel panel)
        {
            InitializeComponent();
            MainPanel = panel;
        }

        private void ViewDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
