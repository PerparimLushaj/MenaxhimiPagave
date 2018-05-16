using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNKProjekti
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 objform1 = new Form1();

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btnKycu_Click(object sender, EventArgs e)
        {
            LidhjaDb objLidhja = new LidhjaDb();
            DataSet _ds = objLidhja.Lexo("Select * from Perdoruesi where Perdoruesi='" + txtPerdoruesi.Text + "' and Fjalekalimi='" + txtPerdoruesi.Text + "'");
            if (objLidhja.mesazhi=="")
            {
                if (_ds.Tables[0].Rows.Count>0)
                {
                    parametrat._PerdoruesiID = int.Parse(_ds.Tables[0].Rows[0]["PerdoruesiID"].ToString());
                    this.Hide();

                    objform1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Perdoruesi ose Fjalekalimi eshte gabim");
                }
            }
            else { MessageBox.Show(objLidhja.mesazhi); }
        }

        private void btnMbyll_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}
