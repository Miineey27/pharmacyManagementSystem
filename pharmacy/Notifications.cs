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
    public partial class Notifications : UserControl
    {
        Panel MainPanel;
        public Notifications(Panel mainPanel)
        {
            InitializeComponent();
            MainPanel = mainPanel;
        }

        private void Notifications_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainPanel.Controls.Clear();
            MedicineShortage shortage = new MedicineShortage(MainPanel);
            MainPanel.Controls.Add(shortage);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainPanel.Controls.Clear();
            ExpiredMedicine expired = new ExpiredMedicine(MainPanel);
            MainPanel.Controls.Add(expired);
        }
    }
}
