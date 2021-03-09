using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtEmail.Text = "";
            txtPassword.Text = "";
            lblMessage.Text = "";
            
        }




        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.ToLower() == "admin@gmail.com" && txtPassword.Text == "123")
            {
                lblMessage.Text = "Successfull login, redirecting to main page... !";
                Form2 managementForm = new Form2(this);
                managementForm.Show();
                this.Hide();
                

            }



            else
                lblMessage.Text = "Account does not exist!";

            

        }




    }
}
