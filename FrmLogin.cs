using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCode
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtUsername.Text=="rolly" && (TxtPassword.Text=="12345" || TxtTempPassword.Text=="12345"))
            {
                FrmMain frmMain = new FrmMain();
                frmMain.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("anda salah memasukkan username atau password");
            }
        }

        private void ChShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(ChShowPassword.Checked==true)
            {
                TxtTempPassword.Text = TxtPassword.Text;
                TxtTempPassword.Visible = true;
                TxtPassword.Visible = false;

            }
            else
            {
                TxtTempPassword.Visible = false;
                TxtPassword.Visible = true;
            }
        }
    }
}
