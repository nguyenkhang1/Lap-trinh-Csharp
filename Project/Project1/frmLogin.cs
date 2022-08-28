using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                if (!string.IsNullOrEmpty(txtpassword.Text))
                {

                    if (txtUserName.Text == "hktdemo" && txtpassword.Text == "hkt123")
                    {
                        new Form2().Show();
                        this.Hide();

                    }

                    else
                    {
                        MessageBox.Show("Tài Khoản hoặc mật khẩu sai. Kiểm tra lại");
                        txtUserName.Clear();
                        txtpassword.Clear();
                        txtUserName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Mật Khẩu Chưa Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpassword.Focus();
                }


            }
            else
            {
                MessageBox.Show("Tài khoản Chưa Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picb_Click(object sender, EventArgs e)
        {
            if(txtpassword.PasswordChar=='*')
            {
                pica.BringToFront();
                txtpassword.PasswordChar = '\0';
            }    
        }

        private void pica_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '\0')
            {
                picb.BringToFront();
                txtpassword.PasswordChar = '*';
            }
        }
    }
}
