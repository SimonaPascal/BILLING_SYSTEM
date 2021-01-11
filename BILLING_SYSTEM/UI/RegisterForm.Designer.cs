
namespace BILLING_SYSTEM.UI
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.registButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.emailRegisterTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordRegisterTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameRegisterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(194)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.registButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.emailRegisterTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.passwordRegisterTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.usernameRegisterTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lastNameTxtBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.firstNameTxtBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(35, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 512);
            this.panel1.TabIndex = 22;
            // 
            // registButton
            // 
            this.registButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.registButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.registButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.registButton.Location = new System.Drawing.Point(24, 420);
            this.registButton.Name = "registButton";
            this.registButton.Size = new System.Drawing.Size(386, 54);
            this.registButton.TabIndex = 31;
            this.registButton.Text = "REGISTER";
            this.registButton.UseVisualStyleBackColor = false;
            this.registButton.Click += new System.EventHandler(this.registButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(110)))), ((int)(((byte)(112)))));
            this.label6.Location = new System.Drawing.Point(74, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 36);
            this.label6.TabIndex = 30;
            this.label6.Text = "CREATE YOUR ACCOUNT";
            // 
            // emailRegisterTextBox
            // 
            this.emailRegisterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.emailRegisterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailRegisterTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRegisterTextBox.ForeColor = System.Drawing.Color.White;
            this.emailRegisterTextBox.Location = new System.Drawing.Point(175, 344);
            this.emailRegisterTextBox.Name = "emailRegisterTextBox";
            this.emailRegisterTextBox.Size = new System.Drawing.Size(174, 26);
            this.emailRegisterTextBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "E-mail Address";
            // 
            // passwordRegisterTextBox
            // 
            this.passwordRegisterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.passwordRegisterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordRegisterTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordRegisterTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordRegisterTextBox.Location = new System.Drawing.Point(175, 284);
            this.passwordRegisterTextBox.Name = "passwordRegisterTextBox";
            this.passwordRegisterTextBox.PasswordChar = '*';
            this.passwordRegisterTextBox.Size = new System.Drawing.Size(174, 26);
            this.passwordRegisterTextBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Password";
            // 
            // usernameRegisterTextBox
            // 
            this.usernameRegisterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.usernameRegisterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameRegisterTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameRegisterTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameRegisterTextBox.Location = new System.Drawing.Point(175, 230);
            this.usernameRegisterTextBox.Name = "usernameRegisterTextBox";
            this.usernameRegisterTextBox.Size = new System.Drawing.Size(174, 26);
            this.usernameRegisterTextBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Username";
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.lastNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTxtBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTxtBox.ForeColor = System.Drawing.Color.White;
            this.lastNameTxtBox.Location = new System.Drawing.Point(175, 173);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(174, 26);
            this.lastNameTxtBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Last Name";
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.firstNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTxtBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxtBox.ForeColor = System.Drawing.Color.White;
            this.firstNameTxtBox.Location = new System.Drawing.Point(175, 117);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(174, 26);
            this.firstNameTxtBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "First Name";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(514, 578);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox emailRegisterTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordRegisterTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameRegisterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button registButton;
    }
}