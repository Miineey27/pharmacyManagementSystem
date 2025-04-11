namespace pharmacy
{
    partial class Notifications
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifications));
            panel3 = new Panel();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            panel2 = new Panel();
            linkLabel2 = new LinkLabel();
            label6 = new Label();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(153, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 221);
            panel3.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(3, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 38);
            panel1.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(70, 7);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(105, 25);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "View details";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 96);
            label2.Name = "label2";
            label2.Size = new Size(32, 25);
            label2.TabIndex = 3;
            label2.Text = "02";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 130);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 0;
            label3.Text = "Medicine Shortage";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(73, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(87, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(pictureBox5);
            panel5.Location = new Point(506, 71);
            panel5.Name = "panel5";
            panel5.Size = new Size(260, 221);
            panel5.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 128);
            panel2.Controls.Add(linkLabel2);
            panel2.Location = new Point(2, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 38);
            panel2.TabIndex = 12;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(70, 7);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(105, 25);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "View details";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(111, 96);
            label6.Name = "label6";
            label6.Size = new Size(32, 25);
            label6.TabIndex = 3;
            label6.Text = "02";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 130);
            label7.Name = "label7";
            label7.Size = new Size(146, 25);
            label7.TabIndex = 0;
            label7.Text = "Expired Medicine";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(73, 11);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(87, 75);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // Notifications
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel5);
            Name = "Notifications";
            Size = new Size(1341, 720);
            Load += Notifications_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel panel5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox5;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private LinkLabel linkLabel2;
    }
}
