namespace ABC_Company
{
    partial class Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            buttonEmp = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonEmp
            // 
            buttonEmp.BackColor = SystemColors.ActiveCaption;
            buttonEmp.Location = new Point(113, 263);
            buttonEmp.Name = "buttonEmp";
            buttonEmp.Size = new Size(94, 29);
            buttonEmp.TabIndex = 0;
            buttonEmp.Text = "Employee";
            buttonEmp.UseVisualStyleBackColor = false;
            buttonEmp.Click += buttonEmp_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(519, 263);
            button2.Name = "button2";
            button2.Size = new Size(107, 29);
            button2.TabIndex = 1;
            button2.Text = "Department";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(927, 263);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Position";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(425, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 159);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(35, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 159);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(830, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(285, 159);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 489);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buttonEmp);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEmp;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox pictureBox1;
    }
}