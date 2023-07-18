using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FaturamYanimda
{
    public static class connection
    {
        public static OleDbConnection con = new OleDbConnection();
        
        public static Login login = new Login();
        public static Register Register = new Register();
        public static Mainpage Mainpage = new Mainpage(); 
        public static calculatewithindex calculatewithindex = new calculatewithindex();
        public static billquery billquery = new billquery();
        public static bills bills = new bills();
        public static lastindexes lastindexes = new lastindexes();
        public static browserform browserform = new browserform();



        static string workingDirectory = Environment.CurrentDirectory;
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static string DBPath = projectDirectory+"\\FaturamYanimda\\Database.accdb";
        public static OleDbConnection GetConnection()
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBPath);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
            }
            return con;
        }
        public static int loggeduserid;


        public static void updatedata()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                string query = "SELECT Kurumlar.turu FROM Kurumlar GROUP BY Kurumlar.turu;";
                OleDbDataAdapter da = new OleDbDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Turu");
                calculatewithindex.billtype_combobox.DisplayMember = "turu";
                calculatewithindex.billtype_combobox.ValueMember = "turu";
                calculatewithindex.billtype_combobox.DataSource = ds.Tables["Turu"];
                calculatewithindex.billtype_combobox.SelectedIndex = -1;
                billquery.billtype_combobox.DisplayMember = "turu";
                billquery.billtype_combobox.ValueMember = "turu";
                billquery.billtype_combobox.DataSource = ds.Tables["Turu"];
                billquery.billtype_combobox.SelectedIndex = -1;



                
                con.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
            }

            try
            {
                OleDbConnection con = connection.con;
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                string query = "SELECT Indeksler.faturaturu as [Fatura Türü], Indeksler.kurumadi as [Kurum Adı], Indeksler.kullanimturu as [Kullanım Türü], Indeksler.birimfiyati as [Birim Fiyatı], Indeksler.ilkokuma as [İlk Okuma], Indeksler.sonokuma as [Son Okuma], Indeksler.tuketilen as [Tüketilen], Indeksler.faturatutari as [Fatura Tutarı], Indeksler.sorgutarihi as [Sorgu Tarihi], Indeksler.sorgusaati as [Sorgu Saati] FROM Indeksler WHERE (((Indeksler.kullaniciid)=" + connection.loggeduserid + "));";
                OleDbDataAdapter da = new OleDbDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Indeksler");
                connection.lastindexes.lastindexes_datagridview.DataSource = ds.Tables["Indeksler"];

                con.Close();

            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
            }
            try //lastindexes formunda datagridviewdeki soldaki sayı sayacı
            {
                OleDbConnection con = connection.con;
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                string query = "SELECT COUNT(kullaniciid) FROM Indeksler WHERE(((Indeksler.kullaniciid) = "+loggeduserid+"));";
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader DR1 = command.ExecuteReader();
                int count =0;
                if (DR1.Read())
                {
                    count = Convert.ToInt32(DR1.GetValue(0));
                }

                con.Close();

                for (int i = 0; i < count; i++)
                {
                    connection.lastindexes.lastindexes_datagridview.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }

            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
            }
            bills.bills_datagridview.DataSource = null;
            bills.bills_datagridview.Rows.Clear();

            try
            {
                
                OleDbConnection con = connection.con;
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                string query = "SELECT Faturalar.faturaturu as [Fatura Türü], Faturalar.kurumadi as [Kurum Adı], Faturalar.contractno as [Abone Numarası], Faturalar.kayittarihi as [Kayıt Tarihi], Faturalar.kayitsaati as [Kayıt Saati] FROM Faturalar WHERE (((Faturalar.kullaniciid)=" + connection.loggeduserid+"));";
                OleDbDataAdapter da = new OleDbDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Faturalar");

                

                bills.bills_datagridview.DataSource = ds.Tables["Faturalar"];
                if (!bills.bills_datagridview.Columns.Contains("Sorgula"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.HeaderText = "Sorgula";
                    btn.Text = "Sorgula";
                    btn.Name = "Sorgula";
                    btn.UseColumnTextForButtonValue = true;
                    bills.bills_datagridview.Columns.Add(btn);
                }
                if (!bills.bills_datagridview.Columns.Contains("Sil"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.HeaderText = "Sil";
                    btn.Text = "Sil";
                    btn.Name = "Sil";
                    btn.UseColumnTextForButtonValue = true;
                    bills.bills_datagridview.Columns.Add(btn);
                }
                bills.bills_datagridview.Columns["Sorgula"].DisplayIndex = bills.bills_datagridview.ColumnCount - 1;
                bills.bills_datagridview.Columns["Sil"].DisplayIndex = bills.bills_datagridview.ColumnCount - 1;



                con.Close();

            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
            }
            try// bills formunda datagridviewdeki soldaki sayı sayacı
            {
                OleDbConnection con = connection.con;
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                string query = "SELECT Count(ID) FROM Faturalar WHERE (((Faturalar.kullaniciid)="+connection.loggeduserid+"));";
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader DR1 = command.ExecuteReader();
                int count = 0;
                if (DR1.Read())
                {
                    count = Convert.ToInt32(DR1.GetValue(0));
                }

                con.Close();

                for (int i = 0; i < count; i++)
                {
                    bills.bills_datagridview.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }

            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
            }

        }



    }
}
