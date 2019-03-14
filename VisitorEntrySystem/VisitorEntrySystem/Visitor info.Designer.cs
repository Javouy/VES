namespace VisitorEntrySystem
{
    partial class Visitor_Info
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
            this.lblVisitorname = new System.Windows.Forms.Label();
            this.lblVisitorID = new System.Windows.Forms.Label();
            this.lblVisitorType = new System.Windows.Forms.Label();
            this.lblLicensePlateNo = new System.Windows.Forms.Label();
            this.lblDeclaration = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtVisitorname = new System.Windows.Forms.TextBox();
            this.txtVisitorID = new System.Windows.Forms.TextBox();
            this.comboBoxVisitorType = new System.Windows.Forms.ComboBox();
            this.comboBoxLicensePlateNo = new System.Windows.Forms.TextBox();
            this.txtDeclaration = new System.Windows.Forms.TextBox();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVisitorname
            // 
            this.lblVisitorname.AutoSize = true;
            this.lblVisitorname.Location = new System.Drawing.Point(59, 34);
            this.lblVisitorname.Name = "lblVisitorname";
            this.lblVisitorname.Size = new System.Drawing.Size(35, 13);
            this.lblVisitorname.TabIndex = 0;
            this.lblVisitorname.Text = "Name";
            this.lblVisitorname.Click += new System.EventHandler(this.lblVisitorname_Click);
            // 
            // lblVisitorID
            // 
            this.lblVisitorID.AutoSize = true;
            this.lblVisitorID.Location = new System.Drawing.Point(59, 81);
            this.lblVisitorID.Name = "lblVisitorID";
            this.lblVisitorID.Size = new System.Drawing.Size(28, 13);
            this.lblVisitorID.TabIndex = 1;
            this.lblVisitorID.Text = "ID# ";
            // 
            // lblVisitorType
            // 
            this.lblVisitorType.AutoSize = true;
            this.lblVisitorType.Location = new System.Drawing.Point(59, 132);
            this.lblVisitorType.Name = "lblVisitorType";
            this.lblVisitorType.Size = new System.Drawing.Size(62, 13);
            this.lblVisitorType.TabIndex = 2;
            this.lblVisitorType.Text = "Visitor Type";
            // 
            // lblLicensePlateNo
            // 
            this.lblLicensePlateNo.AutoSize = true;
            this.lblLicensePlateNo.Location = new System.Drawing.Point(59, 182);
            this.lblLicensePlateNo.Name = "lblLicensePlateNo";
            this.lblLicensePlateNo.Size = new System.Drawing.Size(91, 13);
            this.lblLicensePlateNo.TabIndex = 3;
            this.lblLicensePlateNo.Text = "License Plate No.";
            // 
            // lblDeclaration
            // 
            this.lblDeclaration.AutoSize = true;
            this.lblDeclaration.Location = new System.Drawing.Point(62, 224);
            this.lblDeclaration.Name = "lblDeclaration";
            this.lblDeclaration.Size = new System.Drawing.Size(61, 13);
            this.lblDeclaration.TabIndex = 4;
            this.lblDeclaration.Text = "Declaration";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(315, 387);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(471, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtVisitorname
            // 
            this.txtVisitorname.Location = new System.Drawing.Point(201, 31);
            this.txtVisitorname.Name = "txtVisitorname";
            this.txtVisitorname.Size = new System.Drawing.Size(253, 20);
            this.txtVisitorname.TabIndex = 7;
            // 
            // txtVisitorID
            // 
            this.txtVisitorID.Location = new System.Drawing.Point(201, 78);
            this.txtVisitorID.Name = "txtVisitorID";
            this.txtVisitorID.Size = new System.Drawing.Size(100, 20);
            this.txtVisitorID.TabIndex = 8;
            // 
            // comboBoxVisitorType
            // 
            this.comboBoxVisitorType.FormattingEnabled = true;
            this.comboBoxVisitorType.Items.AddRange(new object[] {
            "Student",
            "Staff",
            "Lecturer",
            "Other"});
            this.comboBoxVisitorType.Location = new System.Drawing.Point(194, 124);
            this.comboBoxVisitorType.Name = "comboBoxVisitorType";
            this.comboBoxVisitorType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVisitorType.TabIndex = 9;
            // 
            // comboBoxLicensePlateNo
            // 
            this.comboBoxLicensePlateNo.Location = new System.Drawing.Point(194, 175);
            this.comboBoxLicensePlateNo.Name = "comboBoxLicensePlateNo";
            this.comboBoxLicensePlateNo.Size = new System.Drawing.Size(100, 20);
            this.comboBoxLicensePlateNo.TabIndex = 10;
            // 
            // txtDeclaration
            // 
            this.txtDeclaration.Location = new System.Drawing.Point(170, 201);
            this.txtDeclaration.Multiline = true;
            this.txtDeclaration.Name = "txtDeclaration";
            this.txtDeclaration.Size = new System.Drawing.Size(392, 87);
            this.txtDeclaration.TabIndex = 11;
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(170, 307);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(100, 20);
            this.txtPurpose.TabIndex = 12;
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(53, 307);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(79, 13);
            this.lblPurpose.TabIndex = 13;
            this.lblPurpose.Text = "Purpose of visit";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(510, 34);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Location";
            // 
            // Visitor_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.txtDeclaration);
            this.Controls.Add(this.comboBoxLicensePlateNo);
            this.Controls.Add(this.comboBoxVisitorType);
            this.Controls.Add(this.txtVisitorID);
            this.Controls.Add(this.txtVisitorname);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDeclaration);
            this.Controls.Add(this.lblLicensePlateNo);
            this.Controls.Add(this.lblVisitorType);
            this.Controls.Add(this.lblVisitorID);
            this.Controls.Add(this.lblVisitorname);
            this.Name = "Visitor_Info";
            this.Text = "VisitorInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisitorname;
        private System.Windows.Forms.Label lblVisitorID;
        private System.Windows.Forms.Label lblVisitorType;
        private System.Windows.Forms.Label lblLicensePlateNo;
        private System.Windows.Forms.Label lblDeclaration;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtVisitorname;
        private System.Windows.Forms.TextBox txtVisitorID;
        private System.Windows.Forms.ComboBox comboBoxVisitorType;
        private System.Windows.Forms.TextBox comboBoxLicensePlateNo;
        private System.Windows.Forms.TextBox txtDeclaration;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblLocation;
    }
}