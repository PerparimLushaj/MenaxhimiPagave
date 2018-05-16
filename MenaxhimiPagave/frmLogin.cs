using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punetori
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnKycu_Click(object sender, EventArgs e)
        {
            if (txtPerdoruesi.Text == "Admin" || txtPerdoruesi.Text == "admin" && txtfjalekalimi.Text == "admin")
            {
                this.Hide();
                new FrmHome().ShowDialog();
            }
            else
            {
                MessageBox.Show("Përdoruesi ose fjalëkalimi janë gabim");

                txtPerdoruesi.Clear();
                txtfjalekalimi.Clear();
            }
        }
        private void btnMbyll_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
