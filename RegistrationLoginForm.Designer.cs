namespace Auction_Kostishin
{
    partial class RegistrationLoginForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.signUpRBtn = new System.Windows.Forms.RadioButton();
            this.loginRBtn = new System.Windows.Forms.RadioButton();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.attentionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.login2Label = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.pass2Label = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.login2TextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.pass2TextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.signUpRBtn);
            this.groupBox1.Controls.Add(this.loginRBtn);
            this.groupBox1.Location = new System.Drawing.Point(336, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // signUpRBtn
            // 
            this.signUpRBtn.AutoSize = true;
            this.signUpRBtn.ForeColor = System.Drawing.Color.DimGray;
            this.signUpRBtn.Location = new System.Drawing.Point(21, 46);
            this.signUpRBtn.Name = "signUpRBtn";
            this.signUpRBtn.Size = new System.Drawing.Size(102, 21);
            this.signUpRBtn.TabIndex = 43;
            this.signUpRBtn.Text = "Реєстрація";
            this.signUpRBtn.UseVisualStyleBackColor = true;
            this.signUpRBtn.CheckedChanged += new System.EventHandler(this.loginRBtn_CheckedChanged);
            // 
            // loginRBtn
            // 
            this.loginRBtn.AutoSize = true;
            this.loginRBtn.Checked = true;
            this.loginRBtn.ForeColor = System.Drawing.Color.DimGray;
            this.loginRBtn.Location = new System.Drawing.Point(21, 18);
            this.loginRBtn.Name = "loginRBtn";
            this.loginRBtn.Size = new System.Drawing.Size(55, 21);
            this.loginRBtn.TabIndex = 42;
            this.loginRBtn.TabStop = true;
            this.loginRBtn.Text = "Вхід";
            this.loginRBtn.UseVisualStyleBackColor = true;
            this.loginRBtn.CheckedChanged += new System.EventHandler(this.loginRBtn_CheckedChanged);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("BrutalType", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.Black;
            this.loginLabel.Location = new System.Drawing.Point(439, 158);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(58, 23);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Логін";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("BrutalType", 10.8F);
            this.passLabel.ForeColor = System.Drawing.Color.Black;
            this.passLabel.Location = new System.Drawing.Point(439, 197);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(75, 23);
            this.passLabel.TabIndex = 6;
            this.passLabel.Text = "Пароль";
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Transparent;
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("BrutalType", 10.8F);
            this.submitBtn.ForeColor = System.Drawing.Color.DimGray;
            this.submitBtn.Location = new System.Drawing.Point(337, 333);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(152, 36);
            this.submitBtn.TabIndex = 32;
            this.submitBtn.Text = "ПІДТВЕРДИТИ";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // attentionLabel
            // 
            this.attentionLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.attentionLabel.AutoSize = true;
            this.attentionLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attentionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.attentionLabel.Location = new System.Drawing.Point(197, 380);
            this.attentionLabel.Name = "attentionLabel";
            this.attentionLabel.Size = new System.Drawing.Size(104, 22);
            this.attentionLabel.TabIndex = 33;
            this.attentionLabel.Text = "*attention";
            this.attentionLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.attentionLabel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("BrutalType", 10.8F);
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(57, 158);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 23);
            this.nameLabel.TabIndex = 35;
            this.nameLabel.Text = "Ім\'я";
            this.nameLabel.Visible = false;
            // 
            // login2Label
            // 
            this.login2Label.AutoSize = true;
            this.login2Label.Font = new System.Drawing.Font("BrutalType", 10.8F);
            this.login2Label.ForeColor = System.Drawing.Color.Black;
            this.login2Label.Location = new System.Drawing.Point(57, 197);
            this.login2Label.Name = "login2Label";
            this.login2Label.Size = new System.Drawing.Size(58, 23);
            this.login2Label.TabIndex = 37;
            this.login2Label.Text = "Логін";
            this.login2Label.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("BrutalType", 10.8F);
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(57, 235);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(67, 23);
            this.emailLabel.TabIndex = 39;
            this.emailLabel.Text = "Пошта";
            this.emailLabel.Visible = false;
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // pass2Label
            // 
            this.pass2Label.AutoSize = true;
            this.pass2Label.Font = new System.Drawing.Font("BrutalType", 10.8F);
            this.pass2Label.ForeColor = System.Drawing.Color.Black;
            this.pass2Label.Location = new System.Drawing.Point(57, 275);
            this.pass2Label.Name = "pass2Label";
            this.pass2Label.Size = new System.Drawing.Size(75, 23);
            this.pass2Label.TabIndex = 41;
            this.pass2Label.Text = "Пароль";
            this.pass2Label.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.nameTextBox.Location = new System.Drawing.Point(140, 159);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(151, 22);
            this.nameTextBox.TabIndex = 42;
            this.nameTextBox.Visible = false;
            // 
            // login2TextBox
            // 
            this.login2TextBox.BackColor = System.Drawing.Color.White;
            this.login2TextBox.ForeColor = System.Drawing.Color.DimGray;
            this.login2TextBox.Location = new System.Drawing.Point(140, 197);
            this.login2TextBox.Name = "login2TextBox";
            this.login2TextBox.Size = new System.Drawing.Size(151, 22);
            this.login2TextBox.TabIndex = 43;
            this.login2TextBox.Visible = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.emailTextBox.Location = new System.Drawing.Point(140, 236);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(151, 22);
            this.emailTextBox.TabIndex = 44;
            this.emailTextBox.Visible = false;
            // 
            // pass2TextBox
            // 
            this.pass2TextBox.BackColor = System.Drawing.Color.White;
            this.pass2TextBox.ForeColor = System.Drawing.Color.DimGray;
            this.pass2TextBox.Location = new System.Drawing.Point(140, 276);
            this.pass2TextBox.Name = "pass2TextBox";
            this.pass2TextBox.Size = new System.Drawing.Size(151, 22);
            this.pass2TextBox.TabIndex = 45;
            this.pass2TextBox.Visible = false;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.White;
            this.loginTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.loginTextBox.Location = new System.Drawing.Point(539, 158);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(151, 22);
            this.loginTextBox.TabIndex = 46;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.Color.White;
            this.passTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.passTextBox.Location = new System.Drawing.Point(539, 198);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(151, 22);
            this.passTextBox.TabIndex = 47;
            // 
            // RegistrationLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.pass2TextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.login2TextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.pass2Label);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.login2Label);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.attentionLabel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrationLoginForm";
            this.Text = "Вхід/Реєстрація";
            this.Load += new System.EventHandler(this.RegistrationLoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label attentionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label login2Label;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label pass2Label;
        private System.Windows.Forms.RadioButton loginRBtn;
        private System.Windows.Forms.RadioButton signUpRBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox login2TextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox pass2TextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passTextBox;
    }
}