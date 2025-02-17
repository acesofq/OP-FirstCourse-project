namespace WinFormsApp1
{
    partial class LoginForm
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
            panel1 = new Panel();
            CloseButton = new Label();
            Autorization = new Label();
            panel2 = new Panel();
            buttonLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            passField = new TextBox();
            loginField = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 75, 110);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(Autorization);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 440);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.FromArgb(149, 177, 247);
            CloseButton.Location = new Point(305, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(36, 36);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "X";
            CloseButton.TextAlign = ContentAlignment.MiddleCenter;
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // Autorization
            // 
            Autorization.Dock = DockStyle.Fill;
            Autorization.Font = new Font("Segoe UI Historic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Autorization.ForeColor = SystemColors.GradientInactiveCaption;
            Autorization.Location = new Point(0, 0);
            Autorization.Name = "Autorization";
            Autorization.Size = new Size(341, 84);
            Autorization.TabIndex = 0;
            Autorization.Text = "Autorization";
            Autorization.TextAlign = ContentAlignment.MiddleCenter;
            Autorization.Click += Autorization_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 90, 115);
            panel2.Controls.Add(buttonLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(passField);
            panel2.Controls.Add(loginField);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 356);
            panel2.TabIndex = 0;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.InactiveCaption;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = SystemColors.ActiveCaptionText;
            buttonLogin.Location = new Point(82, 265);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(162, 65);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Enter";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GradientInactiveCaption;
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(137, 37);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(89, 37);
            label2.TabIndex = 2;
            label2.Text = "Login";
            // 
            // passField
            // 
            passField.BackColor = Color.FromArgb(64, 75, 110);
            passField.BorderStyle = BorderStyle.None;
            passField.Font = new Font("Sitka Text", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passField.ForeColor = SystemColors.GradientInactiveCaption;
            passField.Location = new Point(12, 191);
            passField.Name = "passField";
            passField.PasswordChar = '*';
            passField.Size = new Size(277, 37);
            passField.TabIndex = 1;
            // 
            // loginField
            // 
            loginField.BackColor = Color.FromArgb(64, 75, 110);
            loginField.BorderStyle = BorderStyle.None;
            loginField.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginField.ForeColor = SystemColors.GradientInactiveCaption;
            loginField.Location = new Point(12, 93);
            loginField.Name = "loginField";
            loginField.Size = new Size(277, 39);
            loginField.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 440);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Autorization;
        private Label CloseButton;
        private TextBox loginField;
        private Label label2;
        private TextBox passField;
        private Label label3;
        private Button buttonLogin;
    }
}