namespace Library_Management_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.createAccountLb = new System.Windows.Forms.Label();
            this.logginBtn = new System.Windows.Forms.Button();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.LoginLb = new System.Windows.Forms.Label();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.confirmPasswordLabelReg = new System.Windows.Forms.Label();
            this.passwordLabelReg = new System.Windows.Forms.Label();
            this.userNameLabelReg = new System.Windows.Forms.Label();
            this.returnLoginForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.showPasswordRegister = new System.Windows.Forms.CheckBox();
            this.librarianBtn = new System.Windows.Forms.RadioButton();
            this.userBtn = new System.Windows.Forms.RadioButton();
            this.confirmPasswordRegisterText = new System.Windows.Forms.TextBox();
            this.passwordRegisterText = new System.Windows.Forms.TextBox();
            this.UsernameRegisterText = new System.Windows.Forms.TextBox();
            this.registerLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelLogin.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogin.Controls.Add(this.passwordLabel);
            this.panelLogin.Controls.Add(this.userNameLabel);
            this.panelLogin.Controls.Add(this.createAccountLb);
            this.panelLogin.Controls.Add(this.logginBtn);
            this.panelLogin.Controls.Add(this.showPasswordCheckBox);
            this.panelLogin.Controls.Add(this.passwordText);
            this.panelLogin.Controls.Add(this.usernameText);
            this.panelLogin.Controls.Add(this.LoginLb);
            this.panelLogin.Location = new System.Drawing.Point(351, 50);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(566, 580);
            this.panelLogin.TabIndex = 0;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordLabel.Location = new System.Drawing.Point(128, 303);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(166, 37);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.userNameLabel.Location = new System.Drawing.Point(128, 178);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(172, 37);
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "Username";
            // 
            // createAccountLb
            // 
            this.createAccountLb.AutoSize = true;
            this.createAccountLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.createAccountLb.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.createAccountLb.Location = new System.Drawing.Point(402, 551);
            this.createAccountLb.Name = "createAccountLb";
            this.createAccountLb.Size = new System.Drawing.Size(162, 25);
            this.createAccountLb.TabIndex = 5;
            this.createAccountLb.Text = "Create Account";
            this.createAccountLb.Click += new System.EventHandler(this.createAccountLb_Click);
            // 
            // logginBtn
            // 
            this.logginBtn.BackColor = System.Drawing.Color.Transparent;
            this.logginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.logginBtn.ForeColor = System.Drawing.Color.Azure;
            this.logginBtn.Location = new System.Drawing.Point(212, 489);
            this.logginBtn.Name = "logginBtn";
            this.logginBtn.Size = new System.Drawing.Size(153, 50);
            this.logginBtn.TabIndex = 4;
            this.logginBtn.Text = "Login";
            this.logginBtn.UseVisualStyleBackColor = false;
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.showPasswordCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(135, 418);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(192, 29);
            this.showPasswordCheckBox.TabIndex = 3;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.passwordText.ForeColor = System.Drawing.Color.Black;
            this.passwordText.Location = new System.Drawing.Point(135, 343);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(318, 53);
            this.passwordText.TabIndex = 2;
            // 
            // usernameText
            // 
            this.usernameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.usernameText.ForeColor = System.Drawing.Color.Black;
            this.usernameText.Location = new System.Drawing.Point(135, 221);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(318, 53);
            this.usernameText.TabIndex = 1;
            // 
            // LoginLb
            // 
            this.LoginLb.AutoSize = true;
            this.LoginLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LoginLb.ForeColor = System.Drawing.Color.White;
            this.LoginLb.Location = new System.Drawing.Point(201, 57);
            this.LoginLb.Name = "LoginLb";
            this.LoginLb.Size = new System.Drawing.Size(164, 64);
            this.LoginLb.TabIndex = 0;
            this.LoginLb.Text = "Login";
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.Transparent;
            this.registerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.registerPanel.Controls.Add(this.confirmPasswordLabelReg);
            this.registerPanel.Controls.Add(this.passwordLabelReg);
            this.registerPanel.Controls.Add(this.userNameLabelReg);
            this.registerPanel.Controls.Add(this.returnLoginForm);
            this.registerPanel.Controls.Add(this.button1);
            this.registerPanel.Controls.Add(this.showPasswordRegister);
            this.registerPanel.Controls.Add(this.librarianBtn);
            this.registerPanel.Controls.Add(this.userBtn);
            this.registerPanel.Controls.Add(this.confirmPasswordRegisterText);
            this.registerPanel.Controls.Add(this.passwordRegisterText);
            this.registerPanel.Controls.Add(this.UsernameRegisterText);
            this.registerPanel.Controls.Add(this.registerLabel);
            this.registerPanel.Location = new System.Drawing.Point(351, 50);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(566, 580);
            this.registerPanel.TabIndex = 6;
            // 
            // confirmPasswordLabelReg
            // 
            this.confirmPasswordLabelReg.AutoSize = true;
            this.confirmPasswordLabelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.confirmPasswordLabelReg.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.confirmPasswordLabelReg.Location = new System.Drawing.Point(103, 336);
            this.confirmPasswordLabelReg.Name = "confirmPasswordLabelReg";
            this.confirmPasswordLabelReg.Size = new System.Drawing.Size(296, 37);
            this.confirmPasswordLabelReg.TabIndex = 10;
            this.confirmPasswordLabelReg.Text = "Confirm Password";
            // 
            // passwordLabelReg
            // 
            this.passwordLabelReg.AutoSize = true;
            this.passwordLabelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.passwordLabelReg.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordLabelReg.Location = new System.Drawing.Point(103, 232);
            this.passwordLabelReg.Name = "passwordLabelReg";
            this.passwordLabelReg.Size = new System.Drawing.Size(166, 37);
            this.passwordLabelReg.TabIndex = 9;
            this.passwordLabelReg.Text = "Password";
            // 
            // userNameLabelReg
            // 
            this.userNameLabelReg.AutoSize = true;
            this.userNameLabelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.userNameLabelReg.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.userNameLabelReg.Location = new System.Drawing.Point(103, 136);
            this.userNameLabelReg.Name = "userNameLabelReg";
            this.userNameLabelReg.Size = new System.Drawing.Size(172, 37);
            this.userNameLabelReg.TabIndex = 7;
            this.userNameLabelReg.Text = "Username";
            // 
            // returnLoginForm
            // 
            this.returnLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.returnLoginForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnLoginForm.Image = ((System.Drawing.Image)(resources.GetObject("returnLoginForm.Image")));
            this.returnLoginForm.Location = new System.Drawing.Point(-2, -2);
            this.returnLoginForm.Name = "returnLoginForm";
            this.returnLoginForm.Size = new System.Drawing.Size(63, 51);
            this.returnLoginForm.TabIndex = 8;
            this.returnLoginForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.returnLoginForm.UseVisualStyleBackColor = false;
            this.returnLoginForm.Click += new System.EventHandler(this.returnLoginForm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(212, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // showPasswordRegister
            // 
            this.showPasswordRegister.AutoSize = true;
            this.showPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.showPasswordRegister.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.showPasswordRegister.Location = new System.Drawing.Point(110, 465);
            this.showPasswordRegister.Name = "showPasswordRegister";
            this.showPasswordRegister.Size = new System.Drawing.Size(192, 29);
            this.showPasswordRegister.TabIndex = 6;
            this.showPasswordRegister.Text = "Show Password";
            this.showPasswordRegister.UseVisualStyleBackColor = true;
            this.showPasswordRegister.CheckedChanged += new System.EventHandler(this.showPasswordRegister_CheckedChanged);
            // 
            // librarianBtn
            // 
            this.librarianBtn.AutoSize = true;
            this.librarianBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.librarianBtn.ForeColor = System.Drawing.Color.White;
            this.librarianBtn.Location = new System.Drawing.Point(359, 435);
            this.librarianBtn.Name = "librarianBtn";
            this.librarianBtn.Size = new System.Drawing.Size(104, 24);
            this.librarianBtn.TabIndex = 5;
            this.librarianBtn.TabStop = true;
            this.librarianBtn.Text = "Librarian";
            this.librarianBtn.UseVisualStyleBackColor = true;
            // 
            // userBtn
            // 
            this.userBtn.AutoSize = true;
            this.userBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.userBtn.ForeColor = System.Drawing.Color.White;
            this.userBtn.Location = new System.Drawing.Point(110, 435);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(72, 24);
            this.userBtn.TabIndex = 4;
            this.userBtn.TabStop = true;
            this.userBtn.Text = "User";
            this.userBtn.UseVisualStyleBackColor = true;
            // 
            // confirmPasswordRegisterText
            // 
            this.confirmPasswordRegisterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.confirmPasswordRegisterText.ForeColor = System.Drawing.Color.Black;
            this.confirmPasswordRegisterText.Location = new System.Drawing.Point(110, 376);
            this.confirmPasswordRegisterText.Name = "confirmPasswordRegisterText";
            this.confirmPasswordRegisterText.Size = new System.Drawing.Size(353, 53);
            this.confirmPasswordRegisterText.TabIndex = 3;
            // 
            // passwordRegisterText
            // 
            this.passwordRegisterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.passwordRegisterText.ForeColor = System.Drawing.Color.Black;
            this.passwordRegisterText.Location = new System.Drawing.Point(110, 275);
            this.passwordRegisterText.Name = "passwordRegisterText";
            this.passwordRegisterText.Size = new System.Drawing.Size(353, 53);
            this.passwordRegisterText.TabIndex = 2;
            // 
            // UsernameRegisterText
            // 
            this.UsernameRegisterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UsernameRegisterText.ForeColor = System.Drawing.Color.Black;
            this.UsernameRegisterText.Location = new System.Drawing.Point(110, 176);
            this.UsernameRegisterText.Name = "UsernameRegisterText";
            this.UsernameRegisterText.Size = new System.Drawing.Size(353, 53);
            this.UsernameRegisterText.TabIndex = 1;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.registerLabel.ForeColor = System.Drawing.Color.White;
            this.registerLabel.Location = new System.Drawing.Point(155, 58);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(244, 64);
            this.registerLabel.TabIndex = 0;
            this.registerLabel.Text = "Register";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 772);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.panelLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label LoginLb;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Button logginBtn;
        private System.Windows.Forms.Label createAccountLb;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.RadioButton userBtn;
        private System.Windows.Forms.TextBox confirmPasswordRegisterText;
        private System.Windows.Forms.TextBox passwordRegisterText;
        private System.Windows.Forms.TextBox UsernameRegisterText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox showPasswordRegister;
        private System.Windows.Forms.RadioButton librarianBtn;
        private System.Windows.Forms.Button returnLoginForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label confirmPasswordLabelReg;
        private System.Windows.Forms.Label passwordLabelReg;
        private System.Windows.Forms.Label userNameLabelReg;
    }
}

