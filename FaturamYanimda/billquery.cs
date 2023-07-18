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

namespace FaturamYanimda
{
    public partial class billquery : Form
    {
        public billquery()
        {
            InitializeComponent();
        }

        private void billtype_combobox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (billtype_combobox.SelectedIndex != -1)
            {
                try
                {
                    OleDbConnection con = connection.con;
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    string query = "SELECT Kurumlar.adı FROM Kurumlar WHERE(((Kurumlar.turu) = '" + billtype_combobox.SelectedValue + "') AND((Kurumlar.kullanici) = 'Ev'));";
                    OleDbDataAdapter da = new OleDbDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Kurumlar");
                    corpname_combobox.DisplayMember = "adı";
                    corpname_combobox.ValueMember = "adı";
                    corpname_combobox.DataSource = ds.Tables["Kurumlar"];

                    con.Close();


                    corpname_combobox.Enabled = true;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
                }
                corpname_combobox.SelectedIndex = -1;
            }
            else
            {
                corpname_combobox.Enabled = false;
            }
        }
        public string sorgulinki;
        private void corpname_combobox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (corpname_combobox.SelectedIndex != -1)
            {
                try
                {
                    OleDbConnection con = connection.con;
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    string query = "SELECT Kurumlar.sorgulinki FROM Kurumlar WHERE(((Kurumlar.turu) = '"+billtype_combobox.SelectedValue.ToString()+"') AND((Kurumlar.adı) = '"+corpname_combobox.SelectedValue.ToString()+"') AND((Kurumlar.kullanici) = 'Ev')); ";
                    OleDbCommand command = new OleDbCommand(query, con);
                    OleDbDataReader DR1 = command.ExecuteReader();

                    if (DR1.Read())
                    {
                        sorgulinki = (string)DR1[0];
                    }

                    con.Close();


                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
                }

                contractno_textbox.Clear();
                input_panel.Visible = true;
                kvkk_checkbox.Checked = false;
            }
            else
            {
                contractno_textbox.Clear();
                kvkk_checkbox.Checked = false;
                input_panel.Visible = false;
            }
        }


        private void help_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elektrik faturalarınız için Tesisat No'yu giriniz,diğer faturalarınız için Abone No giriniz.");
        }

        private void contractno_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void contractsubmit_button_Click(object sender, EventArgs e)
        {
            if (contractno_textbox.Text != "")
            {
                if (kvkk_checkbox.Checked)
                {
                    bool varmi = false;
                    try
                    {
                        OleDbConnection con = connection.con;
                        string query;
                        con.Open();
                        query = "SELECT count(ID) FROM Faturalar WHERE (((Faturalar.faturaturu)='"+billtype_combobox.SelectedValue.ToString()+"') AND ((Faturalar.kurumadi)='"+corpname_combobox.SelectedValue.ToString()+"') AND ((Faturalar.contractno)='"+contractno_textbox.Text+"') AND ((Faturalar.kullaniciid)="+connection.loggeduserid+"));";
                        OleDbCommand command = new OleDbCommand(query, con);
                        OleDbDataReader DR1 = command.ExecuteReader();

                        if (DR1.Read())
                        {
                            if (Convert.ToInt32(DR1[0]) == 1)
                            {
                                varmi = true;
                            }
                            else
                            {
                                varmi = false;
                            }
                        }

                        con.Close();

                        if (varmi == true)
                        {
                            MessageBox.Show("Açılan sayfada ben robot değilim butonuna basıp fatura borç sorgula butonuna basınız.");
                            connection.browserform.loadpage();
                            connection.browserform.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Açılan sayfada ben robot değilim butonuna basıp fatura borç sorgula butonuna basınız.");
                            DateTime tarih = DateTime.Now;
                            string kayittarihi = tarih.ToShortDateString();
                            string kayitsaati = tarih.ToShortTimeString();

                            try
                            {
                                con.Open();
                                query = "INSERT INTO Faturalar ( faturaturu, kurumadi, contractno, kullaniciid, kayittarihi, kayitsaati) values('" + billtype_combobox.Text + "','" + corpname_combobox.Text + "','" + contractno_textbox.Text + "'," + connection.loggeduserid + ",'" + kayittarihi + "','" +kayitsaati + "')";
                                OleDbCommand cmd = new OleDbCommand(query, con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                            catch (OleDbException ex)
                            {
                                MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
                            }

                            connection.browserform.loadpage();
                            connection.browserform.ShowDialog();
                        }
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Faturanızı sorgulayabilmeniz için KVKK koşullarını kabul etmeniz gerekmektedir.");
                }
            }
            else
            {
                MessageBox.Show("Abone No - Tesisat No boş bırakılamaz.");
            }
        }
    }
}
