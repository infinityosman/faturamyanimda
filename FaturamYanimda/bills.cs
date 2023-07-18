using System;
using System.Collections;
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
    public partial class bills : Form
    {
        public bills()
        {
            InitializeComponent();
        }
        public string sorgulinki = "";
        public string contractNo = "";
        private void bills_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (bills_datagridview.Columns[e.ColumnIndex].Name == "Sorgula")
                {
                    DataGridViewRow row = bills_datagridview.Rows[e.RowIndex];
                    string faturaTuru = row.Cells["Fatura Türü"].Value.ToString();
                    string kurumAdi = row.Cells["Kurum Adı"].Value.ToString();
                    contractNo = row.Cells["Abone Numarası"].Value.ToString();
                    
                    try
                    {
                        OleDbConnection con = connection.con;
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                        con.Open();
                        string query = "SELECT Kurumlar.sorgulinki FROM Kurumlar WHERE(((Kurumlar.turu) = '" + faturaTuru+ "') AND((Kurumlar.adı) = '" + kurumAdi + "') AND((Kurumlar.kullanici) = 'Ev')); ";
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

                    connection.browserform.loadpagefrombill();
                    connection.browserform.ShowDialog();
                }
                else if (bills_datagridview.Columns[e.ColumnIndex].Name == "Sil")
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz ?", "Kayıt Silme", buttons);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = bills_datagridview.Rows[e.RowIndex];
                        string faturaTuru = row.Cells["Fatura Türü"].Value.ToString();
                        string kurumAdi = row.Cells["Kurum Adı"].Value.ToString();
                        contractNo = row.Cells["Abone Numarası"].Value.ToString();
                        try
                        {
                            OleDbConnection con = connection.con;
                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }
                            con.Open();
                            string query = "DELETE Faturalar.* FROM Faturalar WHERE(((Faturalar.faturaturu) = '" + faturaTuru + "') AND((Faturalar.kurumadi) = '" + kurumAdi + "') AND((Faturalar.contractno) = '" + contractNo + "') AND((Faturalar.kullaniciid) = " + connection.loggeduserid + "));";
                            OleDbCommand command = new OleDbCommand(query, con);
                            command.ExecuteNonQuery();



                            con.Close();
                            connection.updatedata();

                        }
                        catch (OleDbException ex)
                        {
                            MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
                        }
                    }
                    else
                    {
                        
                    }
                    


                }
            }
        }


    }
}
