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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FaturamYanimda
{
    public partial class calculatewithindex : Form
    {
        public calculatewithindex()
        {
            InitializeComponent();
        }

        private void calculatewithindex_Load(object sender, EventArgs e)
        {

        }
        public string birim;
        public double birimfiyati1,birimfiyati2;
        public int basamak;

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
                    string query = "SELECT Kurumlar.kullanici FROM Kurumlar WHERE(((Kurumlar.adı) = '" + corpname_combobox.SelectedValue + "')); ";
                    OleDbDataAdapter da = new OleDbDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Kullanıcı");
                    usagetype_combobox.DisplayMember = "kullanici";
                    usagetype_combobox.ValueMember = "kullanici";
                    usagetype_combobox.DataSource = ds.Tables["Kullanıcı"];

                    con.Close();


                    usagetype_combobox.Enabled = true;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
                }
                usagetype_combobox.SelectedIndex = -1;
            }
            else
            {
                usagetype_combobox.Enabled = false;
            }
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elektrik faturaları için ev tüketicileri günlük 8kWh tüketime kadar olan tüketimler için "+birimfiyati1+" TL ile, 8kWh ve üzerindeki tüketimler için ise "+birimfiyati2+" TL ile çarparak elektrik faturası hesaplanır.");
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            if (firstindex_textbox.Text != "" & secondindex_textbox.Text != "")
            {
                if ((Convert.ToInt32(firstindex_textbox.Text) < Convert.ToInt32(secondindex_textbox.Text)))
                {
                    double usage;
                    double billprice = 0;
                    DateTime tarih = DateTime.Now;
                    string sorgutarihi = tarih.ToShortDateString();
                    string sorgusaati = tarih.ToShortTimeString();
                    result_panel.Visible = true;
                    if (billtype_combobox.SelectedValue.ToString() == "Doğalgaz" || billtype_combobox.SelectedValue.ToString() == "Su")
                    {
                        help_button.Visible = false;
                        result_billtype.Text = billtype_combobox.Text;
                        resultcorpname_label.Text = corpname_combobox.Text;
                        resultusagetype_label.Text = usagetype_combobox.Text;
                        resultunitprice_label.Text = unitprice_textbox.Text + " TL";
                        resultfirstindex_label.Text = firstindex_textbox.Text;
                        resultsecondindex_label.Text = secondindex_textbox.Text;
                        usage = (Convert.ToDouble(secondindex_textbox.Text) - Convert.ToDouble(firstindex_textbox.Text));
                        resultusage_label.Text = usage.ToString() + birim;
                        billprice = (usage * birimfiyati1);
                        resultbillprice_label.Text = billprice.ToString() + " TL";
                    }
                    else
                    {
                        //unit price a iki price ı da ekle
                        help_button.Visible = true;
                        result_billtype.Text = billtype_combobox.Text;
                        resultcorpname_label.Text = corpname_combobox.Text;
                        resultusagetype_label.Text = usagetype_combobox.Text;
                        resultunitprice_label.Text = birimfiyati1 + " TL ve " + birimfiyati2 + " TL";
                        resultfirstindex_label.Text = firstindex_textbox.Text;
                        resultsecondindex_label.Text = secondindex_textbox.Text;
                        usage = (Convert.ToDouble(secondindex_textbox.Text) - Convert.ToDouble(firstindex_textbox.Text));
                        resultusage_label.Text = usage.ToString() + birim;
                        if (usage > basamak)
                        {
                            double kalan = usage - basamak;
                            billprice = (basamak * Convert.ToDouble(birimfiyati1)) + (kalan * Convert.ToDouble(birimfiyati2));
                        }
                        else
                        {
                            billprice = usage * Convert.ToDouble(birimfiyati1);
                        }
                        resultbillprice_label.Text = billprice.ToString() + " TL";

                    }

                    try
                    {
                        OleDbConnection con = connection.con;
                        string query;
                        con.Open();
                        query = "INSERT INTO Indeksler ( faturaturu, kurumadi, kullanimturu, birimfiyati, ilkokuma, sonokuma, tuketilen, faturatutari, sorgutarihi, sorgusaati, kullaniciid) values('" + billtype_combobox.Text + "','" + corpname_combobox.Text + "','" + usagetype_combobox.Text + "','" + birimfiyati1.ToString() + "','" + firstindex_textbox.Text + "','" + secondindex_textbox.Text + "','" + usage.ToString() + "','"+ billprice.ToString()+ "','" + sorgutarihi.ToString() + "','" + sorgusaati.ToString() + "','" +connection.loggeduserid.ToString()+"')";
                        OleDbCommand cmd = new OleDbCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("İlk okuma ikinci okumadan küçük veya eşit olamaz !");
                }
            }
            else
            {
                MessageBox.Show("Okuma değerlerini giriniz !");
            }
            
        }

        private void firstindex_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void secondindex_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void usagetype_combobox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (usagetype_combobox.SelectedIndex != -1)
            {
                try
                {
                    OleDbConnection con = connection.con;
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();
                    string query = "SELECT Kurumlar.birimi, Kurumlar.birimfiyati1, Kurumlar.birimfiyati2, Kurumlar.basamak FROM Kurumlar WHERE(((Kurumlar.adı) = '" + corpname_combobox.SelectedValue + "') AND((Kurumlar.kullanici) = '" + usagetype_combobox.SelectedValue + "'));";

                    OleDbCommand command = new OleDbCommand(query, con);
                    OleDbDataReader DR1 = command.ExecuteReader();

                    if (DR1.Read())
                    {
                        birim = DR1.GetValue(0).ToString();
                        birimfiyati1 = Convert.ToDouble(DR1.GetValue(1));
                        birimfiyati2 = Convert.ToDouble(DR1.GetValue(2));
                        basamak = Convert.ToInt32(DR1.GetValue(3));
                    }

                    con.Close();

                    unitprice_textbox.Text = birimfiyati1.ToString();




                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
                }

                firstindex_textbox.Clear();
                secondindex_textbox.Clear();
                calculateinput_panel.Visible = true;
                result_panel.Visible = false;
            }
            else
            {
                firstindex_textbox.Clear();
                secondindex_textbox.Clear();
                calculateinput_panel.Visible = false;
                result_panel.Visible = false;
            }
        }

    }
}
