using System.Runtime.InteropServices;



namespace pharmacy
{
    public partial class Dashboard : Form
    {

        private Button activeButton = null;
        private Color activeColor = Color.FromArgb(144, 153, 100);
        private Color defaultColor = Color.FromArgb(40, 51, 66);



        public Dashboard()
        {


            {
                InitializeComponent();

                button1.Click += SidebarButton_Click;
                button2.Click += SidebarButton_Click;
                button3.Click += SidebarButton_Click;
                button4.Click += SidebarButton_Click;
                button5.Click += SidebarButton_Click;
                button6.Click += SidebarButton_Click;
                button7.Click += SidebarButton_Click;


                ResetAllButtonColors();
            }


        }

        private void ResetAllButtonColors()
        {
            button1.BackColor = defaultColor;
            button2.BackColor = defaultColor;
            button3.BackColor = defaultColor;
            button4.BackColor = defaultColor;
            button5.BackColor = defaultColor;
            button6.BackColor = defaultColor;
            button7.BackColor = defaultColor;
        }
        private void LoadPage(UserControl page)
        {
            MainPanel.Controls.Clear();        // Remove the current page
            page.Dock = DockStyle.Fill;        // Fill the panel area
            MainPanel.Controls.Add(page);      // Show the new page
        }


        private void SidebarButton_Click(object? sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Reset the previous active button
            if (activeButton != null)
            {
                activeButton.BackColor = defaultColor;

            }

            // Set new active button
            clickedButton.BackColor = activeColor;
            activeButton = clickedButton;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            button2.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        bool drop = false;
        private void button8_Click(object sender, EventArgs e)
        {

            drop = !drop;
            button1.Visible = drop;
        }

        bool isDropdownExpanded = false;

        private void button2_Click_2(object sender, EventArgs e)
        {

            isDropdownExpanded = !isDropdownExpanded;
            button3.Visible = isDropdownExpanded;
            button4.Visible = isDropdownExpanded;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear(); // clear the panel
            Medicines medPage = new Medicines(MainPanel); // pass panelMain to Medicines
            MainPanel.Controls.Add(medPage); // show Medicines inside the panel

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            MainPanel.Controls.Clear(); // clear the panel
            SalesReport medPage = new SalesReport(MainPanel); // pass panelMain to Medicines
            MainPanel.Controls.Add(medPage);
=======
            
>>>>>>> 03665c860a1a404eb87e9c6483237c50d29bb09e
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Notifications notifications = new Notifications(MainPanel);
            MainPanel.Controls.Add(notifications);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
<<<<<<< HEAD

        private void button4_Click_1(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            ProfitAndLoss profitloss = new ProfitAndLoss(MainPanel);
            MainPanel.Controls.Add(profitloss);
        }
=======
>>>>>>> 03665c860a1a404eb87e9c6483237c50d29bb09e
    }
}
