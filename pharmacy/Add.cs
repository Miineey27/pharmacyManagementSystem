﻿using System;
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
    public partial class Add : UserControl
    {
        Panel MainPanel;
        public Add(Panel mainPanel)
        {
            InitializeComponent();
            MainPanel = mainPanel;
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
