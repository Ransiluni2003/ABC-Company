

namespace ABC_Company
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            buttonLogin = new Button();
            textBoxUserName = new TextBox();
            labelUserName = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(520, 35);
            label1.Name = "label1";
            label1.Size = new Size(413, 25);
            label1.TabIndex = 0;
            label1.Text = "Welcome to ABC Company Phone Book";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(labelPassword);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(labelUserName);
            groupBox1.Location = new Point(520, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 262);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please login to continue";
          
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(196, 111);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(229, 27);
            textBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(66, 111);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(93, 28);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(171, 183);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(125, 29);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(196, 65);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(229, 27);
            textBoxUserName.TabIndex = 1;
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(66, 65);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(108, 28);
            labelUserName.TabIndex = 0;
            labelUserName.Text = "User Name";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 493);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 488);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += this.Login_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Button buttonLogin;
        private TextBox textBoxUserName;
        private Label labelUserName;
        private Panel panel1;

        public EventHandler Login_Load { get; private set; }
    }
}
