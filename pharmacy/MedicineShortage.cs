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
    public partial class MedicineShortage : UserControl
    {
        Panel MainPanl;
        public MedicineShortage(Panel mainPanl)
        {
            InitializeComponent();
            MainPanl = mainPanl;
        }

        private void MedicineShortage_Load(object sender, EventArgs e)
        {

        }
    }
}
