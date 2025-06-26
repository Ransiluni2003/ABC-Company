namespace ABC_Company
{
    partial class Position
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Position));
            groupBox1 = new GroupBox();
            buttonInsert = new Button();
            buttondelete = new Button();
            button1 = new Button();
            textBoxPosName = new TextBox();
            textBoxPosID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridViewAllPosition = new DataGridView();
            panel1 = new Panel();
            label5 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllPosition).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonInsert);
            groupBox1.Controls.Add(buttondelete);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxPosName);
            groupBox1.Controls.Add(textBoxPosID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(333, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(622, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Position Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(203, 164);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(94, 29);
            buttonInsert.TabIndex = 6;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttondelete
            // 
            buttondelete.Location = new Point(436, 164);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(94, 29);
            buttondelete.TabIndex = 5;
            buttondelete.Text = "Delete";
            buttondelete.UseVisualStyleBackColor = true;
            buttondelete.Click += buttondelete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(319, 164);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxPosName
            // 
            textBoxPosName.Location = new Point(175, 93);
            textBoxPosName.Name = "textBoxPosName";
            textBoxPosName.Size = new Size(380, 27);
            textBoxPosName.TabIndex = 4;
            textBoxPosName.TextChanged += textBoxPosName_TextChanged;
            // 
            // textBoxPosID
            // 
            textBoxPosID.Location = new Point(175, 44);
            textBoxPosID.Name = "textBoxPosID";
            textBoxPosID.Size = new Size(380, 27);
            textBoxPosID.TabIndex = 3;
            textBoxPosID.TextChanged += textBoxPosID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 100);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 2;
            label2.Text = "Position Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 51);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Position ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAllPosition);
            groupBox2.Location = new Point(333, 301);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(622, 189);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "All Position Details";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dataGridViewAllPosition
            // 
            dataGridViewAllPosition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllPosition.Location = new Point(16, 38);
            dataGridViewAllPosition.Name = "dataGridViewAllPosition";
            dataGridViewAllPosition.RowHeadersWidth = 51;
            dataGridViewAllPosition.Size = new Size(600, 145);
            dataGridViewAllPosition.TabIndex = 0;
            dataGridViewAllPosition.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = SystemColors.ControlDark;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 652);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(94, 560);
            label5.Name = "label5";
            label5.Size = new Size(102, 31);
            label5.TabIndex = 11;
            label5.Text = "Position";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(94, 447);
            label7.Name = "label7";
            label7.Size = new Size(144, 31);
            label7.TabIndex = 10;
            label7.Text = "Department";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(94, 339);
            label4.Name = "label4";
            label4.Size = new Size(118, 31);
            label4.TabIndex = 7;
            label4.Text = "Employee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(94, 237);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 6;
            label3.Text = "Home";
            label3.Click += label3_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(15, 547);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(55, 59);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(15, 438);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 59);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(15, 327);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 59);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 223);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 58);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 28);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Position
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 658);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Position";
            Text = "Position";
            Load += Position_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllPosition).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonInsert;
        private Button buttondelete;
        private Button button1;
        private TextBox textBoxPosName;
        private TextBox textBoxPosID;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewAllPosition;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label5;
    }
}