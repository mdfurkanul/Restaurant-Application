namespace Restaurant_Application
{
    partial class frmSignUp
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
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSubmit = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlBrouse = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RuleTerm = new System.Windows.Forms.CheckBox();
            this.mobile = new System.Windows.Forms.TextBox();
            this.SecurityCode = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.labSecurityCode = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.frmOpacity = new System.Windows.Forms.Timer(this.components);
            this.frmClose = new System.Windows.Forms.Timer(this.components);
            this.ImageName = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlSubmit.SuspendLayout();
            this.pnlBrouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(240)))));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Controls.Add(this.ImageName);
            this.pnlMain.Controls.Add(this.pnlSubmit);
            this.pnlMain.Controls.Add(this.pnlBrouse);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.RuleTerm);
            this.pnlMain.Controls.Add(this.mobile);
            this.pnlMain.Controls.Add(this.SecurityCode);
            this.pnlMain.Controls.Add(this.pass);
            this.pnlMain.Controls.Add(this.email);
            this.pnlMain.Controls.Add(this.name);
            this.pnlMain.Controls.Add(this.picProfile);
            this.pnlMain.Controls.Add(this.labSecurityCode);
            this.pnlMain.Controls.Add(this.Type);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Location = new System.Drawing.Point(23, 175);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(592, 378);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlSubmit
            // 
            this.pnlSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.pnlSubmit.Controls.Add(this.label9);
            this.pnlSubmit.Location = new System.Drawing.Point(212, 311);
            this.pnlSubmit.Name = "pnlSubmit";
            this.pnlSubmit.Size = new System.Drawing.Size(126, 45);
            this.pnlSubmit.TabIndex = 17;
            this.pnlSubmit.Click += new System.EventHandler(this.btnSubmit);
            this.pnlSubmit.MouseLeave += new System.EventHandler(this.btnSubmit_leave);
            this.pnlSubmit.MouseHover += new System.EventHandler(this.btnSubmit_hover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(13, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Submit";
            this.label9.Click += new System.EventHandler(this.btnSubmit);
            this.label9.MouseLeave += new System.EventHandler(this.btnSubmit_leave);
            this.label9.MouseHover += new System.EventHandler(this.btnSubmit_hover);
            // 
            // pnlBrouse
            // 
            this.pnlBrouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.pnlBrouse.Controls.Add(this.label8);
            this.pnlBrouse.Location = new System.Drawing.Point(406, 252);
            this.pnlBrouse.Name = "pnlBrouse";
            this.pnlBrouse.Size = new System.Drawing.Size(115, 43);
            this.pnlBrouse.TabIndex = 16;
            this.pnlBrouse.Click += new System.EventHandler(this.btnBrowse);
            this.pnlBrouse.MouseLeave += new System.EventHandler(this.btnBrowse_leave);
            this.pnlBrouse.MouseHover += new System.EventHandler(this.btnBrowse_hover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(35, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "......";
            this.label8.Click += new System.EventHandler(this.btnBrowse);
            this.label8.MouseLeave += new System.EventHandler(this.btnBrowse_leave);
            this.label8.MouseHover += new System.EventHandler(this.btnBrowse_hover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(37, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sign up from";
            // 
            // RuleTerm
            // 
            this.RuleTerm.AutoSize = true;
            this.RuleTerm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuleTerm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RuleTerm.Location = new System.Drawing.Point(98, 280);
            this.RuleTerm.Name = "RuleTerm";
            this.RuleTerm.Size = new System.Drawing.Size(242, 25);
            this.RuleTerm.TabIndex = 14;
            this.RuleTerm.Text = "I accept all the rules and terms.";
            this.RuleTerm.UseVisualStyleBackColor = true;
            // 
            // mobile
            // 
            this.mobile.BackColor = System.Drawing.Color.Turquoise;
            this.mobile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mobile.Location = new System.Drawing.Point(181, 174);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(157, 29);
            this.mobile.TabIndex = 12;
            // 
            // SecurityCode
            // 
            this.SecurityCode.BackColor = System.Drawing.Color.Turquoise;
            this.SecurityCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecurityCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SecurityCode.Location = new System.Drawing.Point(181, 249);
            this.SecurityCode.Name = "SecurityCode";
            this.SecurityCode.Size = new System.Drawing.Size(157, 29);
            this.SecurityCode.TabIndex = 11;
            this.SecurityCode.Visible = false;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.Turquoise;
            this.pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pass.Location = new System.Drawing.Point(181, 137);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(157, 29);
            this.pass.TabIndex = 10;
            this.pass.UseSystemPasswordChar = true;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Turquoise;
            this.email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.Location = new System.Drawing.Point(181, 101);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(157, 29);
            this.email.TabIndex = 9;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Turquoise;
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Location = new System.Drawing.Point(181, 65);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(157, 29);
            this.name.TabIndex = 8;
            // 
            // picProfile
            // 
            this.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picProfile.Location = new System.Drawing.Point(371, 60);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(197, 162);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 7;
            this.picProfile.TabStop = false;
            // 
            // labSecurityCode
            // 
            this.labSecurityCode.AutoSize = true;
            this.labSecurityCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSecurityCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labSecurityCode.Location = new System.Drawing.Point(58, 252);
            this.labSecurityCode.Name = "labSecurityCode";
            this.labSecurityCode.Size = new System.Drawing.Size(106, 21);
            this.labSecurityCode.TabIndex = 6;
            this.labSecurityCode.Text = "Security Code";
            this.labSecurityCode.Visible = false;
            // 
            // Type
            // 
            this.Type.BackColor = System.Drawing.Color.Turquoise;
            this.Type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Member",
            "Chef"});
            this.Type.Location = new System.Drawing.Point(181, 213);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(157, 29);
            this.Type.TabIndex = 5;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.comboCatagory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(91, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Catagory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(54, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(94, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(116, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(112, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // BackToolTip
            // 
            this.BackToolTip.BackColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Restaurant_Application.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(23, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.BackToolTip.SetToolTip(this.pictureBox1, "Back");
            this.pictureBox1.Click += new System.EventHandler(this.btnBack);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.btnBack_leave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.btnBack_hover);
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.pnlBack.Controls.Add(this.pictureBox1);
            this.pnlBack.Location = new System.Drawing.Point(23, 40);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(98, 65);
            this.pnlBack.TabIndex = 2;
            this.BackToolTip.SetToolTip(this.pnlBack, "Back");
            this.pnlBack.Click += new System.EventHandler(this.btnBack);
            this.pnlBack.MouseLeave += new System.EventHandler(this.btnBack_leave);
            this.pnlBack.MouseHover += new System.EventHandler(this.btnBack_hover);
            // 
            // frmOpacity
            // 
            this.frmOpacity.Interval = 50;
            this.frmOpacity.Tick += new System.EventHandler(this.frmOpacity_Tick);
            // 
            // frmClose
            // 
            this.frmClose.Interval = 1000;
            this.frmClose.Tick += new System.EventHandler(this.frmClose_Tick);
            // 
            // ImageName
            // 
            this.ImageName.AutoSize = true;
            this.ImageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageName.Location = new System.Drawing.Point(371, 229);
            this.ImageName.Name = "ImageName";
            this.ImageName.Size = new System.Drawing.Size(0, 15);
            this.ImageName.TabIndex = 18;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1022, 648);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1022, 648);
            this.Name = "frmSignUp";
            this.Text = "Index";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlSubmit.ResumeLayout(false);
            this.pnlSubmit.PerformLayout();
            this.pnlBrouse.ResumeLayout(false);
            this.pnlBrouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolTip BackToolTip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Timer frmOpacity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox RuleTerm;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.TextBox SecurityCode;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label labSecurityCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSubmit;
        private System.Windows.Forms.Panel pnlBrouse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer frmClose;
        private System.Windows.Forms.Label ImageName;
    }
}

