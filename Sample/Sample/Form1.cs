using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Sample
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(frmLogin_MouseDown);
            this.MouseUp += new MouseEventHandler(frmLogin_MouseUp);
            this.MouseMove += new MouseEventHandler(frmLogin_MouseMove);
            this.txtUsername.Enter += new EventHandler(txtUsername_Enter);
            this.txtUsername.Leave += new EventHandler(txtUsername_Leave);
            this.txtPassword.Enter += new EventHandler(txtPassword_Enter);
            this.txtPassword.Leave += new EventHandler(txtPassword_Leave);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //change the from text transfer to the label
            lblTitle.Text = this.Text;
        }

        //place holder username
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = System.Drawing.SystemColors.WindowText;
                txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            }
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
                txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            }
        }

        //place holder password
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
                txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
                txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            }
        }

        //http://www.codeproject.com/Articles/13571/Draggable-Form-Drag-a-Borderless-Form-by-Clicking
        //move form
        private bool drag = false;
        private Point start_point = new Point(0, 0);
        private bool draggable = true;
        private string exclude_list = "txtUsername, txtPassword";

        protected override void OnControlAdded(ControlEventArgs e)
        {
            //
            //Add Mouse Event Handlers for each control added into the form,
            //if Draggable property of the form is set to true and the control
            //name is not in the ExcludeList.Exclude list is the comma separated
            //list of the Controls for which you do not require the mouse handler 
            //to be added. For Example a button.  
            //
            if (this.Draggable && (this.ExcludeList.IndexOf(e.Control.Name) == -1))
            {
                e.Control.MouseDown += new MouseEventHandler(frmLogin_MouseDown);
                e.Control.MouseUp += new MouseEventHandler(frmLogin_MouseUp);
                e.Control.MouseMove += new MouseEventHandler(frmLogin_MouseMove);
            }
            base.OnControlAdded(e);
        }
        void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            //
            //On Mouse Down set the flag drag=true and 
            //Store the clicked point to the start_point variable
            //
            this.drag = true;
            this.start_point = new Point(e.X, e.Y);
        }
        void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            //
            //Set the drag flag = false;
            //
            this.drag = false;
        }
        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            //
            //If drag = true, drag the form
            //
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.start_point.X,
                                     p2.Y - this.start_point.Y);
                this.Location = p3;
            }
        }

        public string ExcludeList
        {
            set
            {
                this.exclude_list = value;
            }
            get
            {
                return this.exclude_list.Trim();
            }
        }

        public bool Draggable
        {
            set
            {
                this.draggable = value;
            }
            get
            {
                return this.draggable;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!(txtUsername.Text == "Username") && !(txtPassword.Text == "Password"))
            {
                Console.WriteLine("Username: " + txtUsername.Text);
                Console.WriteLine("Password: " + txtPassword.Text);
            }
            else 
            {
                Console.WriteLine("Error!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
