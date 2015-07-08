using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sample
{
    public partial class frmMessage : Form
    {
        private Form frm;
        public static int OK = 0;
        public static int OK_CANCEL = 1;
        public static int YES_NO_CANCEL = 2;
        public static frmMessage messageBox;
        public static bool Confirm;

        public frmMessage()
        {
            InitializeComponent();
        }

        public static bool showBox(Form frm, string title, string message, int messageType)
        {
            messageBox = new frmMessage();
            messageBox.lblTitle.Text = title;
            messageBox.lblMessage.Text = message;
            messageBox.frm = frm;
            messageBox.frm.Enabled = false;

            switch (messageType)
            {
                case 0: messageBox.btnOk.Visible = true; break;
                case 1: messageBox.btnConfirm2.Visible = true; 
                        messageBox.btnDeny2.Visible = true; break;
                case 2: messageBox.btnConfirm1.Visible = true;
                        messageBox.btnDeny1.Visible = true;
                        messageBox.btnCancel.Visible = true;
                        break;

                default: break;
            }
            messageBox.ShowDialog();
            return Confirm;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Confirm = false;
            this.frm.Enabled = true;
            messageBox.Dispose();
        }

        //button actions
        private void btnOk_Click(object sender, EventArgs e)
        {
            Confirm = true;
            this.frm.Enabled = true;
            messageBox.Dispose();
        }

        private void btnConfirm2_Click(object sender, EventArgs e)
        {
            Confirm = true;
            this.frm.Enabled = true;
            messageBox.Dispose();
        }

        private void btnDeny2_Click(object sender, EventArgs e)
        {
            Confirm = false;
            this.frm.Enabled = true;
            messageBox.Dispose();
        }

        private void btnDeny1_Click(object sender, EventArgs e)
        {
            Confirm = false;
            this.frm.Enabled = true;
            messageBox.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Confirm = false;
            this.frm.Enabled = true;
            messageBox.Dispose();
        }

        private void btnConfirm1_Click(object sender, EventArgs e)
        {
            Confirm = true;
            this.frm.Enabled = true;
            messageBox.Dispose();
        }
    }
}