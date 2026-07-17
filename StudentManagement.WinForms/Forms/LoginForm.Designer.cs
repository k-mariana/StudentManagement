namespace StudentManagement.WinForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            pictureBoxEye = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEye).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 38);
            label1.Name = "label1";
            label1.Size = new Size(102, 38);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(264, 124);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(223, 31);
            txtLogin.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(264, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(223, 31);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.AliceBlue;
            btnLogin.Location = new Point(317, 339);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 130);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 4;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 198);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // pictureBoxEye
            // 
            pictureBoxEye.Cursor = Cursors.Hand;
            pictureBoxEye.Image = (Image)resources.GetObject("pictureBoxEye.Image");
            pictureBoxEye.Location = new Point(493, 192);
            pictureBoxEye.Name = "pictureBoxEye";
            pictureBoxEye.Size = new Size(24, 24);
            pictureBoxEye.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEye.TabIndex = 6;
            pictureBoxEye.TabStop = false;
            pictureBoxEye.Click += pictureBoxEye_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxEye);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label2;
        private Label label3;
        private PictureBox pictureBoxEye;
    }
}
