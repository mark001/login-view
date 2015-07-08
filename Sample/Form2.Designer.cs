namespace Sample
{
    partial class frmMessage
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnConfirm1 = new System.Windows.Forms.Button();
            this.btnDeny1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm2 = new System.Windows.Forms.Button();
            this.btnDeny2 = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnExit.Location = new System.Drawing.Point(295, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.lblTitle.Font = new System.Drawing.Font("Roboto Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.Location = new System.Drawing.Point(-2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(322, 39);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title Message";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Roboto Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.lblMessage.Location = new System.Drawing.Point(-1, 50);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(321, 28);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Are you sure you want to exit?";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConfirm1
            // 
            this.btnConfirm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.btnConfirm1.FlatAppearance.BorderSize = 0;
            this.btnConfirm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm1.Location = new System.Drawing.Point(9, 86);
            this.btnConfirm1.Name = "btnConfirm1";
            this.btnConfirm1.Size = new System.Drawing.Size(96, 38);
            this.btnConfirm1.TabIndex = 10;
            this.btnConfirm1.Text = "Yes";
            this.btnConfirm1.UseVisualStyleBackColor = false;
            this.btnConfirm1.Visible = false;
            this.btnConfirm1.Click += new System.EventHandler(this.btnConfirm1_Click);
            // 
            // btnDeny1
            // 
            this.btnDeny1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.btnDeny1.FlatAppearance.BorderSize = 0;
            this.btnDeny1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeny1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeny1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeny1.Location = new System.Drawing.Point(111, 86);
            this.btnDeny1.Name = "btnDeny1";
            this.btnDeny1.Size = new System.Drawing.Size(96, 38);
            this.btnDeny1.TabIndex = 11;
            this.btnDeny1.Text = "No";
            this.btnDeny1.UseVisualStyleBackColor = false;
            this.btnDeny1.Visible = false;
            this.btnDeny1.Click += new System.EventHandler(this.btnDeny1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(213, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 38);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm2
            // 
            this.btnConfirm2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.btnConfirm2.FlatAppearance.BorderSize = 0;
            this.btnConfirm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm2.Location = new System.Drawing.Point(52, 86);
            this.btnConfirm2.Name = "btnConfirm2";
            this.btnConfirm2.Size = new System.Drawing.Size(96, 38);
            this.btnConfirm2.TabIndex = 13;
            this.btnConfirm2.Text = "Ok";
            this.btnConfirm2.UseVisualStyleBackColor = false;
            this.btnConfirm2.Visible = false;
            this.btnConfirm2.Click += new System.EventHandler(this.btnConfirm2_Click);
            // 
            // btnDeny2
            // 
            this.btnDeny2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.btnDeny2.FlatAppearance.BorderSize = 0;
            this.btnDeny2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeny2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeny2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeny2.Location = new System.Drawing.Point(154, 86);
            this.btnDeny2.Name = "btnDeny2";
            this.btnDeny2.Size = new System.Drawing.Size(96, 38);
            this.btnDeny2.TabIndex = 14;
            this.btnDeny2.Text = "Cancel";
            this.btnDeny2.UseVisualStyleBackColor = false;
            this.btnDeny2.Visible = false;
            this.btnDeny2.Click += new System.EventHandler(this.btnDeny2_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOk.Location = new System.Drawing.Point(111, 86);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 38);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(319, 129);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDeny2);
            this.Controls.Add(this.btnConfirm2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeny1);
            this.Controls.Add(this.btnConfirm1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmMessage";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnConfirm1;
        private System.Windows.Forms.Button btnDeny1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm2;
        private System.Windows.Forms.Button btnDeny2;
        private System.Windows.Forms.Button btnOk;
    }
}