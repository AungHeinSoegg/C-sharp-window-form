using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login___Registration_System
{
    public partial class frmregister : Form
    {
        public frmregister()
        {
            InitializeComponent();
        }

        OleDbPermission con = new OleDbPermission("Provider=Microsoft.Jet.4.0;Data Source=db_users.mdb");
        OledbCommand cmd = new OledbCommand();
        OledbDataAdapter da = new OledbDataAdapter();

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and Password Field are empty ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtComPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES"('"+textUsername.Text+"', '"+textPassword.Text+"')
                cmd = new OledbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";

                MessageBox.Show("You Have Created An Account Successfuly", "Completed Registration", MessageBoxButtons.OK MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Password Dose Not Match, Plese Tryagin and ReEnter Your Password", "Regisration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxshowpass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtPassword.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new frmlogin().Show();
            this.Hide;
        }
    }
}
