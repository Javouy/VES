namespace VisitorEntrySystem
{
    partial class RegistrationFrm
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtRegFName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtRegLname = new System.Windows.Forms.TextBox();
            this.lblRegLname = new System.Windows.Forms.Label();
            this.txtRegIdNo = new System.Windows.Forms.TextBox();
            this.lblRegIDNo = new System.Windows.Forms.Label();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.TxtRegConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(52, 79);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // txtRegFName
            // 
            this.txtRegFName.Location = new System.Drawing.Point(161, 72);
            this.txtRegFName.Name = "txtRegFName";
            this.txtRegFName.Size = new System.Drawing.Size(179, 20);
            this.txtRegFName.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.Location = new System.Drawing.Point(366, 388);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 40);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "&Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtRegLname
            // 
            this.txtRegLname.Location = new System.Drawing.Point(161, 108);
            this.txtRegLname.Name = "txtRegLname";
            this.txtRegLname.Size = new System.Drawing.Size(179, 20);
            this.txtRegLname.TabIndex = 4;
            // 
            // lblRegLname
            // 
            this.lblRegLname.AutoSize = true;
            this.lblRegLname.Location = new System.Drawing.Point(51, 115);
            this.lblRegLname.Name = "lblRegLname";
            this.lblRegLname.Size = new System.Drawing.Size(58, 13);
            this.lblRegLname.TabIndex = 3;
            this.lblRegLname.Text = "Last Name";
            // 
            // txtRegIdNo
            // 
            this.txtRegIdNo.Location = new System.Drawing.Point(161, 153);
            this.txtRegIdNo.Name = "txtRegIdNo";
            this.txtRegIdNo.Size = new System.Drawing.Size(179, 20);
            this.txtRegIdNo.TabIndex = 6;
            // 
            // lblRegIDNo
            // 
            this.lblRegIDNo.AutoSize = true;
            this.lblRegIDNo.Location = new System.Drawing.Point(52, 160);
            this.lblRegIDNo.Name = "lblRegIDNo";
            this.lblRegIDNo.Size = new System.Drawing.Size(35, 13);
            this.lblRegIDNo.TabIndex = 5;
            this.lblRegIDNo.Text = "ID No";
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(161, 198);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '*';
            this.txtRegPassword.Size = new System.Drawing.Size(179, 20);
            this.txtRegPassword.TabIndex = 8;
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Location = new System.Drawing.Point(52, 205);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(53, 13);
            this.lblRegPassword.TabIndex = 7;
            this.lblRegPassword.Text = "Password";
            // 
            // TxtRegConfirmPassword
            // 
            this.TxtRegConfirmPassword.Location = new System.Drawing.Point(161, 240);
            this.TxtRegConfirmPassword.Name = "TxtRegConfirmPassword";
            this.TxtRegConfirmPassword.PasswordChar = '*';
            this.TxtRegConfirmPassword.Size = new System.Drawing.Size(179, 20);
            this.TxtRegConfirmPassword.TabIndex = 10;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(52, 247);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 9;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // RegistrationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtRegConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.lblRegPassword);
            this.Controls.Add(this.txtRegIdNo);
            this.Controls.Add(this.lblRegIDNo);
            this.Controls.Add(this.txtRegLname);
            this.Controls.Add(this.lblRegLname);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRegFName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "RegistrationFrm";
            this.Text = "RegistrationFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtRegFName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtRegLname;
        private System.Windows.Forms.Label lblRegLname;
        private System.Windows.Forms.TextBox txtRegIdNo;
        private System.Windows.Forms.Label lblRegIDNo;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.TextBox TxtRegConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
    }
}