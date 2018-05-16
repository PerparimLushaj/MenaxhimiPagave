using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;        //per assambly
using System.Resources;         //per ResourseMenager
using System.Globalization;  

namespace KNKProjekti
{
	public partial class Form1 : Form
	{
		LidhjaDb objLidhja = new LidhjaDb();
		int _NrId = 0;
		public Form1()
		{
			InitializeComponent();
		}
		//Form2 f = new Form2();

		string gj = "";
		private void Form1_Load(object sender, EventArgs e)
		{

				if (radioButton1.Checked==true)
					{
						gj = "KNKProjekti.Gjuhet.LangAl";
						 CultureInfo ci = new CultureInfo("en-US");
						 NdrroGjuhen(ci, gj);
					}
				else if (radioButton2.Checked == true) //gj anglisht
				{
					gj = "KNKProjekti.Gjuhet.LangEl";
					CultureInfo ci = new CultureInfo("al-AL");
					NdrroGjuhen(ci, gj);
					this.Text = "FIEK Administration";
				}

			
		}

		private void NdrroGjuhen(CultureInfo ci, string gj)
		{
			Assembly a = Assembly.Load("KNKProjekti");
			ResourceManager rm = new ResourceManager(gj, a);

			labelX11.Text = rm.GetString("NrIdentifikues", ci) + ":";
			labelX10.Text = rm.GetString("Emri", ci) + ":";
			labelX2.Text = rm.GetString("Mbiemri", ci) + ":";
			labelX12.Text = rm.GetString("Email", ci) + ":";
			labelX13.Text = rm.GetString("NrKontaktues", ci) + ":";
			labelX14.Text = rm.GetString("Ditelindja", ci) + ":";
			labelX15.Text = rm.GetString("Pozita", ci) + ":";
			labelX16.Text = rm.GetString("DataRegjistrimit", ci) + ":";
			labelX3.Text = rm.GetString("Departamenti", ci) + ":";
			labelX17.Text = rm.GetString("KerkoSipasEmrit", ci) + ":";
			btnAnulo.Text = rm.GetString("Anulo", ci) + "";
			btnIRi.Text = rm.GetString("IRi", ci) + "";
			btnnRuaj.Text = rm.GetString("Ruaj", ci) + "";
			btnEdito1.Text = rm.GetString("Edito", ci) + "";
			buttonX1.Text = rm.GetString("RuajNdryshimet", ci) + "";
			btnFshije.Text = rm.GetString("Fshije", ci) + "";
			//btnKerko.Text = rm.GetString("Kerko", ci) + "";
			sideNavItem3.Text = rm.GetString("Stafi", ci);
			labelX18.Text = rm.GetString("EmriDepartamentit", ci) + ":";
			labelX19.Text = rm.GetString("UdheheqesiDepartamentit", ci) + ":";
			btnKrijo.Text = rm.GetString("IRi", ci) + "";
			btnRuajDept.Text = rm.GetString("Ruaj", ci) + "";
			btnEditoDpt.Text = rm.GetString("Edito", ci) + "";
			btnFshijeDpt.Text = rm.GetString("Fshije", ci) + "";
			groupPanel2.Text = rm.GetString("Departamentet", ci);
			groupPanel3.Text = rm.GetString("TeDhenat", ci);
			labelX20.Text = rm.GetString("ZgjedhPoziten", ci) + ":";
			rdbProfesor.Text = rm.GetString("Profesor", ci) + ":";
			rdbAsisten.Text = rm.GetString("Asistent", ci) + ":";
			rdbReferent.Text = rm.GetString("Referent", ci);
			rdbPunetorNdihmes.Text = rm.GetString("PunetorNdihmes", ci);
			gbVetit.Text = rm.GetString("Vetit", ci);
			labelX22.Text = rm.GetString("DataFillimit", ci) + ":";
			labelX23.Text = rm.GetString("DataMbarimit", ci) + ":";
			labelX21.Text = rm.GetString("NumriLlogaris", ci) + ":";
			labelX24.Text = rm.GetString("Paga", ci) + ":";
			btnRuaj1.Text = rm.GetString("Ruaj", ci);
			sideNavItem4.Text = rm.GetString("Departamentet", ci);
			sideNavItem5.Text = rm.GetString("Pagesat", ci);
			labelX26.Text = rm.GetString("Emri", ci) + ":";
			labelX29.Text = rm.GetString("Mbiemri", ci) + ":";
			lbldfg.Text = rm.GetString("Emri", ci) + ":";
			labelX27.Text = rm.GetString("Mbiemri", ci) + ":";
			btnKerkoRaport.Text = rm.GetString("Kerko", ci);
			labelX1.Text = rm.GetString("ZgjedhGrafikun", ci) + ":";
			rdbGrafikuDepartment.Text = rm.GetString("NrPunetorevePerSecilinDepartment", ci);
			labelX4.Text = rm.GetString("Kompjuterik", ci) + ":";
			labelX5.Text = rm.GetString("Automatik", ci) + ":";
			labelX6.Text = rm.GetString("Elektronik", ci) + ":";
			labelX4.Text = rm.GetString("Kompjuterik", ci) + ":";
			labelX7.Text = rm.GetString("NrPergjithshem", ci) + ":";
			sideNavItem6.Text = rm.GetString("Raportet", ci);
			sideNavItem2.Text = rm.GetString("Grafikat", ci);
			groupPanel1.Text = rm.GetString("TeDhenat", ci);
			gpGrafikat.Text = rm.GetString("Grafikat", ci);
			labelX28.Text = rm.GetString("PagaTotale", ci);









			//btnParaqitAdresat.Text = rm.GetString("Paraqit", ci);
			//btnRuajMofiko.Text = rm.GetString("ModifikoAdresen", ci);
		}

		private void MbushKombot()
		{
			DataSet _shenimet = objLidhja.Lexo("Select EmriDepartamentit from Departamentet ");
			if (objLidhja.mesazhi == "")
			{
				cmbDepartamenti.DisplayMember = "EmriDepartamentit";
				cmbDepartamenti.DataSource = _shenimet.Tables[0];
				cmbDepartamenti.SelectedIndex = -1;
			}
		}



		private void switchButton1_ValueChanged(object sender, EventArgs e)
		{
			//snMeny.Enabled = true;
		}

		private void sideNavPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void radioButton6_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			gbVetit.Visible = true;
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			gbVetit.Visible = true;

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			gbVetit.Visible = true;

		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			gbVetit.Visible = true;

		}

		private void snMeny_Click(object sender, EventArgs e)
		{

		}

		private void labelX10_Click(object sender, EventArgs e)
		{

		}

		private void btnIRi_Click(object sender, EventArgs e)
		{

			txtNrIdentifikues.Enabled = true;
			txtEmri1.Enabled = true;
			txtMbiemri.Enabled = true;
			txtEmail.Enabled = true;
			txtNrKontaktues.Enabled = true;
			dtiDitelindja.Enabled = true;
			cmbPozita.Enabled = true;
			dtiDataRegjistrimti.Enabled = true;
			cmbDepartamenti.Enabled = true;
			txtNrIdentifikues.Clear();
			txtEmri1.Clear();
			txtMbiemri.Clear();
			txtEmail.Clear();
			txtNrKontaktues.Clear();
			dtiDitelindja.Value = DateTime.Now;
			cmbPozita.SelectedIndex = -1;
			dtiDataRegjistrimti.Value = DateTime.Now;
			cmbDepartamenti.SelectedIndex = -1;



		}

		private void sideNavPanel2_Paint(object sender, PaintEventArgs e)
		{
			mbushListenStafi();
			MbushKombot();
		}
		public void mbushListenStafi()
		{
			DataSet ds = objLidhja.Lexo("Select * from Stafi  where Emri LIKE '%" + txtKerkoEmri.Text + "%'");
			if (objLidhja.mesazhi != "")
			{
				MessageBox.Show(objLidhja.mesazhi);
				return;
			}
			dgvPunetoret.DataSource = ds.Tables[0];

		}
		public void mbushListenDepartamentet()
		{
			DataSet ds = objLidhja.Lexo("Select * from Departamentet");
			if (objLidhja.mesazhi != "")
			{
				MessageBox.Show(objLidhja.mesazhi);
				return;
			}
			dgvDepartamentet.DataSource = ds.Tables[0];
			dgvDepartamentet.Columns["DepartamentiId"].Visible = false;


		}
		public void mbushListenProfesor()
		{
			DataSet ds = objLidhja.Lexo("Select * from Stafi  where Pozita = 'Profesor'");
			if (objLidhja.mesazhi != "")
			{
				MessageBox.Show(objLidhja.mesazhi);
				return;
			}
			dgvPagesa.DataSource = ds.Tables[0];
			dgvPagesa.Columns["IdPunetori"].Visible = false;
			dgvPagesa.Columns["NrIdentifikues"].Visible = false;
			dgvPagesa.Columns["Email"].Visible = false;
			dgvPagesa.Columns["NrKontaktues"].Visible = false;
			dgvPagesa.Columns["Ditelindja"].Visible = false;
			dgvPagesa.Columns["Pozita"].Visible = false;
			dgvPagesa.Columns["DataRegjistrimit"].Visible = false;




		}
		public void mbushListenAsistent()
		{
			DataSet ds = objLidhja.Lexo("Select * from Stafi  where Pozita = 'Asistent'");
			if (objLidhja.mesazhi != "")
			{
				MessageBox.Show(objLidhja.mesazhi);
				return;
			}
			dgvPagesa.DataSource = ds.Tables[0];
			dgvPagesa.Columns["IdPunetori"].Visible = false;
			dgvPagesa.Columns["NrIdentifikues"].Visible = false;
			dgvPagesa.Columns["Email"].Visible = false;
			dgvPagesa.Columns["NrKontaktues"].Visible = false;
			dgvPagesa.Columns["Ditelindja"].Visible = false;
			dgvPagesa.Columns["Pozita"].Visible = false;
			dgvPagesa.Columns["DataRegjistrimit"].Visible = false;

		}
		public void mbushListenReferent()
		{
			DataSet ds = objLidhja.Lexo("Select * from Stafi  where Pozita = 'Referent'");
			if (objLidhja.mesazhi != "")
			{
				MessageBox.Show(objLidhja.mesazhi);
				return;
			}
			dgvPagesa.DataSource = ds.Tables[0];
			dgvPagesa.Columns["IdPunetori"].Visible = false;
			dgvPagesa.Columns["NrIdentifikues"].Visible = false;
			dgvPagesa.Columns["Email"].Visible = false;
			dgvPagesa.Columns["NrKontaktues"].Visible = false;
			dgvPagesa.Columns["Ditelindja"].Visible = false;
			dgvPagesa.Columns["Pozita"].Visible = false;
			dgvPagesa.Columns["DataRegjistrimit"].Visible = false;

		}
		public void mbushListenPunetorNdihmes()
		{
			DataSet ds = objLidhja.Lexo("Select * from Stafi  where Pozita = 'PunetorNdihmes'");
			if (objLidhja.mesazhi != "")
			{
				MessageBox.Show(objLidhja.mesazhi);
				return;
			}
			dgvPagesa.DataSource = ds.Tables[0];
			dgvPagesa.Columns["IdPunetori"].Visible = false;
			dgvPagesa.Columns["NrIdentifikues"].Visible = false;
			dgvPagesa.Columns["Email"].Visible = false;
			dgvPagesa.Columns["NrKontaktues"].Visible = false;
			dgvPagesa.Columns["Ditelindja"].Visible = false;
			dgvPagesa.Columns["Pozita"].Visible = false;
			dgvPagesa.Columns["DataRegjistrimit"].Visible = false;

		}


		private void sideNavPanel3_Paint(object sender, PaintEventArgs e)
		{
			mbushListenDepartamentet();
		}

		private void buttonX6_Click(object sender, EventArgs e)
		{
			try
			{
				string _query = "";
				_query = "INSERT INTO Departamentet ( EmriDepartamentit,UdheheqesiDepartamentit) Values ('" + txtEmriDepartamentit.Text + "','" + txtUdheheqesiDepartamentit.Text + "')";
				string _mesazhi = objLidhja.InsUpdDel(_query);
				if (_mesazhi == "")
				{
					_mesazhi = "Sukses";
					mbushListenDepartamentet();
					txtEmriDepartamentit.Enabled = false;
					txtUdheheqesiDepartamentit.Enabled = false;

				}
				MessageBox.Show(_mesazhi);
			}
			catch (Exception)
			{

				throw;
			}
		}

		private void btnFshijeDpt_Click(object sender, EventArgs e)
		{
			try
			{
				int _indeksi = dgvDepartamentet.CurrentRow.Index;
				string _query = "";
				_query = "DELETE FROM Departamentet  where EmriDepartamentit='" + dgvDepartamentet.Rows[_indeksi].Cells["EmriDepartamentit"].Value + "'";
				string _mesazhi = objLidhja.InsUpdDel(_query);
				if (_mesazhi == "")
				{
					_mesazhi = "test";
					mbushListenDepartamentet();
				}
				MessageBox.Show(_mesazhi);
			}
			catch (Exception)
			{

				throw;
			}
		}

		private void sideNavPanel4_Paint(object sender, PaintEventArgs e)
		{
			if (rdbProfesor.Checked)
			{
				mbushListenProfesor();
			}
			else
				if (rdbAsisten.Checked)
				{
					mbushListenAsistent();
				}
				else
					if (rdbReferent.Checked)
					{
						mbushListenReferent();
					}
					else
						if (rdbPunetorNdihmes.Checked)
						{
							mbushListenPunetorNdihmes();
						}
		}

		private void btnRuaj1_Click(object sender, EventArgs e)
		{
			try
			{
				int _indeksi = dgvPagesa.CurrentRow.Index;
				string _query = "";
				_query = "INSERT INTO Pagesa(Emri,Mbiemri,DataFillimit,DataMbarimit,NumriLlogaris,Paga) Values ('" + dgvPagesa.Rows[_indeksi].Cells["Emri"].Value + "','" + dgvPagesa.Rows[_indeksi].Cells["Mbiemri"].Value + "','" + dtiDataFillimitPagesa.Text + "','" + dtiDataMbarimitPagesa.Text + "','" + txtNrLlogaris.Text + "','" + txtPaga.Text + "')";
				string _mesazhi = objLidhja.InsUpdDel(_query);
				if (_mesazhi == "")
				{
					_mesazhi = "test";
				}
				MessageBox.Show(_mesazhi);
			}
			catch (Exception)
			{

				throw;
			}
		}


		private void btnKerkoRaport_Click(object sender, EventArgs e)
		{
			try
			{
				DataSet emri = objLidhja.Lexo("Select Emri from Pagesa  where Emri LIKE '%" + txtEmriRaport.Text + "%'");

			}
			catch (Exception)
			{
				MessageBox.Show("Gabim");
			}
			DataSet PagaTotale = objLidhja.Lexo("Select SUM(Paga) As PagaTotale from Pagesa where Emri LIKE '%" + txtEmriRaport.Text + "%'and Mbiemri Like '%" + txtMbiemriRaport.Text + "%'");
			DataSet ds = objLidhja.Lexo("Select * from Pagesa  where Emri LIKE '%" + txtEmriRaport.Text + "%'and Mbiemri Like '%" + txtMbiemriRaport.Text + "%'");
			try
			{
				DataSet emri = objLidhja.Lexo("Select Emri from Pagesa  where Emri LIKE '%" + txtEmriRaport.Text + "%' and Mbiemri Like '%" + txtMbiemriRaport.Text + "%'");
				DataSet mbiemri = objLidhja.Lexo("Select Mbiemri from Pagesa  where Emri LIKE '%" + txtEmriRaport.Text + "%' and Mbiemri Like '%" + txtMbiemriRaport.Text + "%'");
				lblMbiemri.Text = mbiemri.Tables[0].Rows[0]["Mbiemri"].ToString();
				lblEmri.Text = emri.Tables[0].Rows[0]["Emri"].ToString();
				lblPagaTotale.Text = PagaTotale.Tables[0].Rows[0]["PagaTotale"].ToString();

			}
			catch (Exception)
			{
				MessageBox.Show("Nuk ka asnje punetor te regjistruar me ate emer");
				lblEmri.Text = "";
				lblMbiemri.Text = "";
				lblPagaTotale.Text = "";
			}
			if (objLidhja.mesazhi != "")
			{
				MessageBox.Show(objLidhja.mesazhi);
				return;
			}
			dgvRaporti.DataSource = ds.Tables[0];
			dgvRaporti.Columns["PagesaId"].Visible = false;
			dgvRaporti.Columns["NumriLlogaris"].Visible = false;




		}

		private void btnnRuaj_Click(object sender, EventArgs e)
		{
			try
			{
				string _query = "";
				_query = "INSERT INTO Stafi ( NrIdentifikues,Emri,Mbiemri,Email,NrKontaktues,Ditelindja,Pozita,DataRegjistrimit,Departamenti) Values ('" + txtNrIdentifikues.Text + "','" + txtEmri1.Text + "','" + txtMbiemri.Text + "','" + txtEmail.Text + "','" + txtNrKontaktues.Text + "','" + dtiDitelindja.Text + "','" + cmbPozita.SelectedItem + "','" + dtiDataRegjistrimti.Text + "','" + cmbDepartamenti.Text + "')";
				string _mesazhi = objLidhja.InsUpdDel(_query);
				if (_mesazhi == "")
				{
					_mesazhi = "Te dhenat u regjistruan me sukses!";
					txtNrIdentifikues.Clear();
					txtEmri1.Clear();
					txtMbiemri.Clear();
					txtEmail.Clear();
					txtNrKontaktues.Clear();
					dtiDitelindja.Value = DateTime.Now;
					cmbPozita.SelectedIndex = -1;
					dtiDataRegjistrimti.Value = DateTime.Now;
					cmbDepartamenti.SelectedIndex = -1;
					txtNrIdentifikues.Enabled = false;
					txtEmri1.Enabled = false;
					txtMbiemri.Enabled = false;
					txtEmail.Enabled = false;
					txtNrKontaktues.Enabled = false;
					dtiDitelindja.Enabled = false;
					cmbPozita.Enabled = false;
					dtiDataRegjistrimti.Enabled = false;
					cmbDepartamenti.Enabled = false;
					mbushListenStafi();
				}
				MessageBox.Show(_mesazhi);
			}
			catch (Exception)
			{
				throw;
			}


		}

		private void btnFshije_Click(object sender, EventArgs e)
		{
			try
			{
				int _indeksi = dgvPunetoret.CurrentRow.Index;
				string _query = "";
				_query = "DELETE FROM Stafi  where Emri='" + dgvPunetoret.Rows[_indeksi].Cells["Emri"].Value + "'" + " AND Mbiemri='" + dgvPunetoret.Rows[_indeksi].Cells["Mbiemri"].Value + "'";
				string _mesazhi = objLidhja.InsUpdDel(_query);
				if (_mesazhi == "")
				{
					_mesazhi = "Fshierja eshte kryer me sukses!";
					mbushListenStafi();
				}
				MessageBox.Show(_mesazhi);
			}
			catch (Exception)
			{

				throw;
			}
		}


		private void dgvPunetoret_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dgvPunetoret.Rows[e.RowIndex];
				txtNrIdentifikues.Text = row.Cells[1].Value.ToString();
				txtEmri1.Text = row.Cells[2].Value.ToString();
				txtMbiemri.Text = row.Cells[3].Value.ToString();
				txtEmail.Text = row.Cells[4].Value.ToString();
				txtNrKontaktues.Text = row.Cells[5].Value.ToString();
				dtiDitelindja.Text = row.Cells[6].Value.ToString();
				cmbPozita.Text = row.Cells[7].Value.ToString();
				dtiDataRegjistrimti.Text = row.Cells[8].Value.ToString();
				cmbDepartamenti.Text = row.Cells[9].Value.ToString();


			}
		}

		private void btnEdito1_Click(object sender, EventArgs e)
		{
			txtNrIdentifikues.Enabled = true;
			txtEmri1.Enabled = true;
			txtMbiemri.Enabled = true;
			txtEmail.Enabled = true;
			txtNrKontaktues.Enabled = true;
			dtiDitelindja.Enabled = true;
			cmbPozita.Enabled = true;
			dtiDataRegjistrimti.Enabled = true;
			cmbDepartamenti.Enabled = true;

		}

		private void buttonX1_Click(object sender, EventArgs e)
		{
			try
			{

				int _indeksi = dgvPunetoret.CurrentRow.Index;

				string _query = "";
				_query = "Update Stafi Set" + " NrIdentifikues='" + txtNrIdentifikues.Text + "',Emri='" + txtEmri1.Text
					+ "',Mbiemri='" + txtMbiemri + "',Email='" + txtEmail.Text + "',NrKontaktues='"
					+ txtNrKontaktues.Text + "',Ditelindja='" + dtiDitelindja.Text + "',Pozita='"
					+ cmbPozita.SelectedValue + "',DataRegjistrimit='" + dtiDataRegjistrimti.Text
					+ "',Departamenti='" + cmbDepartamenti.Text + "' Where IdPunetori=" + 20;// + dgvPunetoret.Rows[_indeksi].Cells[0];
				string mesazhi = objLidhja.InsUpdDel(_query);
				if (mesazhi == "")
				{
					MessageBox.Show("Ndryshimi u krye me sukses");
					mbushListenStafi();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		}

		private void dgvDepartamentet_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dgvDepartamentet.Rows[e.RowIndex];
				txtEmriDepartamentit.Text = row.Cells[1].Value.ToString();
				txtUdheheqesiDepartamentit.Text = row.Cells[2].Value.ToString();



			}
		}

		private void btnKrijo_Click(object sender, EventArgs e)
		{
			txtEmriDepartamentit.Enabled = true;
			txtUdheheqesiDepartamentit.Enabled = true;
		}

		private void groupPanel3_Click(object sender, EventArgs e)
		{

		}

		private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
		{
			pnlGrafikaDepartmentet.Visible = true;
			gpTedhenat.Visible = true;
			lblAutomatik.Visible = true;
			lblKompjuterik.Visible = true;
			lblElektronike.Visible = true;
			lblPergjithshem.Visible = true;
			labelX4.Visible = true;
			labelX5.Visible = true;
			labelX6.Visible = true;
			labelX7.Visible = true;
		}

		private void sideNavPanel6_Paint(object sender, PaintEventArgs e)
		{
			//if(rdbGrafikuDepartment.CheckedChanged)
			//{
			//    pnlGrafikaDepartmentet.Visible = true;
			//    gpTedhenat.Visible = true;
			//    lblAutomatik.Visible = true;
			//    lblKompjuterik.Visible = true;
			//    lblElektronike.Visible = true;
			//    lblPergjithshem.Visible = true;
			//    labelX4.Visible = true;
			//    labelX5.Visible = true;
			//    labelX6.Visible = true;
			//    labelX7.Visible = true;
			//}


		}

		private void pnlGrafikaDepartmentet_Click(object sender, EventArgs e)
		{
			  
		}

		private void buttonX2_Click(object sender, EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.Show();
		}

		private void pnlGrafikaDepartmentet_Paint(object sender, PaintEventArgs e)
		{
			try
			{
				DataSet NrPunetoreveKompjuterik = objLidhja.Lexo("Select count(IdPunetori) AS 'NrKompjuterik' from Stafi  where Departamenti = 'Kompjuterike'");
				DataSet NrPunetoreveAutomatik = objLidhja.Lexo("Select count(IdPunetori) AS 'NrAutomatik' from Stafi  where Departamenti = 'Automatike'");
				DataSet NrPunetoreveElektronik = objLidhja.Lexo("Select count(IdPunetori) AS 'NrElektronik' from Stafi  where Departamenti = 'Elektronike'");

				DataSet NrPergjithshem = objLidhja.Lexo("Select count(IdPunetori) AS 'NrPergjithshem' from Stafi ");

				lblKompjuterik.Text = NrPunetoreveKompjuterik.Tables[0].Rows[0]["NrKompjuterik"].ToString();
				lblPergjithshem.Text = NrPergjithshem.Tables[0].Rows[0]["NrPergjithshem"].ToString();
				lblAutomatik.Text = NrPunetoreveAutomatik.Tables[0].Rows[0]["NrAutomatik"].ToString();
				lblElektronike.Text = NrPunetoreveElektronik.Tables[0].Rows[0]["NrElektronik"].ToString();


				string a = lblKompjuterik.Text;
				string b = lblPergjithshem.Text;
				string c = lblAutomatik.Text;
				string d = lblElektronike.Text;

				double Kompjuterika = Convert.ToInt32(a);
				double pergjithshem = Convert.ToInt32(b);
				double nrKompjuterika = (Kompjuterika / pergjithshem) * 360;
				float nr1 = Convert.ToSingle(nrKompjuterika);
				double Automatika = Convert.ToInt32(c);
				double nrAutomatika = (Automatika / pergjithshem) * 360;
				float nr2 = Convert.ToSingle(nrAutomatika);
				double Elektronike = Convert.ToInt32(d);
				double nrElektronike = (Elektronike / pergjithshem) * 360;
				float nr3 = Convert.ToSingle(nrElektronike);

				Graphics objGrafika = e.Graphics;
				SolidBrush brushaKompjuterik = new SolidBrush(Color.Blue);
				SolidBrush brushaAutomatik = new SolidBrush(Color.Red);
				SolidBrush brushaElektronik = new SolidBrush(Color.Green);


				Rectangle katrori = new Rectangle(0, 0, 409, 275);
				Pen lapsiB = new Pen(Color.Blue);
				objGrafika.DrawRectangle(lapsiB, katrori);
				objGrafika.FillPie(brushaKompjuterik, katrori, 0,nr1);
				objGrafika.FillPie(brushaAutomatik, katrori, nr1, nr2);
				objGrafika.FillPie(brushaElektronik, katrori, nr1+nr2, nr3);




			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void sideNavItem2_Click(object sender, EventArgs e)
		{
			
		}

		private void sideNavItem6_Click(object sender, EventArgs e)
		{

		}

		private void buttonX2_Click_1(object sender, EventArgs e)
		{
			txtNrIdentifikues.Enabled = false;
			txtEmri1.Enabled = false;
			txtMbiemri.Enabled = false;
			txtEmail.Enabled = false;
			txtNrKontaktues.Enabled = false;
			dtiDitelindja.Enabled = false;
			cmbPozita.Enabled = false;
			dtiDataRegjistrimti.Enabled = false;
			cmbDepartamenti.Enabled = false;
		}

		private void sideNavItem4_Click(object sender, EventArgs e)
		{
			txtNrIdentifikues.Enabled = false;
			txtEmri1.Enabled = false;
			txtMbiemri.Enabled = false;
			txtEmail.Enabled = false;
			txtNrKontaktues.Enabled = false;
			dtiDitelindja.Enabled = false;
			cmbPozita.Enabled = false;
			dtiDataRegjistrimti.Enabled = false;
			cmbDepartamenti.Enabled = false;
		}

		private void btnKerko_Click(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
		{
			
				gj = "KNKProjekti.Gjuhet.LangEl";
				CultureInfo ci = new CultureInfo("en-US"); //sme bene VStudio al-AL
				NdrroGjuhen(ci, gj);
				//this.Text = "Modify address";
			
		}

		private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
		{
		   
				gj = "KNKProjekti.Gjuhet.LangAl";
				CultureInfo ci = new CultureInfo("en-US");
				NdrroGjuhen(ci, gj);
			
		}
		private void MbusheListen()
		{
			DataSet ds =
				objLidhja.Lexo("Select * From Stafi Where " +
				"Emri LIKE '%" + txtKerkoEmri.Text + "%' OR " +
				"NrIdentifikues LIKE '%" + txtKerkoEmri.Text + "%'");
			if (objLidhja.mesazhi != "")
			{
				MessageBox.Show(objLidhja.mesazhi);
				return;
			}
			dgvPunetoret.DataSource = ds.Tables[0];
			dgvPunetoret.Columns["IdPunetori"].Visible = false;
		}

		private void txtKerkoEmri_TextChanged(object sender, EventArgs e)
		{
			MbusheListen();
		}
		
	}
}

