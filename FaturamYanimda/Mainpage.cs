using MaterialSkin.Controls;
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
    public partial class Mainpage : MaterialForm
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void Mainpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void Mainpage_Load(object sender, EventArgs e)
        {


        }
        Form lastknownform;
        private void FormGetir(Form frm)
        {
            mdipanel.Controls.Clear();
            frm.TopLevel = false;
            mdipanel.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            lastknownform = frm;
            frm.Show();

        }
        private void FormGizle(Form frm)
        {
            frm.Hide();
        }

        private void calculatewithindex_button_Click(object sender, EventArgs e)
        {
            if (lastknownform != null)
            {
                FormGizle(lastknownform);
            }
            connection.updatedata();
            FormGetir(connection.calculatewithindex);
            calculatewithindex_button.Enabled = false;
            billquery_button.Enabled = true;
            bills_button.Enabled = true;
            lastindexes_button.Enabled =true;
            
        }

        private void billquery_button_Click(object sender, EventArgs e)
        {
            if (lastknownform != null)
            {
                FormGizle(lastknownform);
            }
            connection.updatedata();
            FormGetir(connection.billquery);
            calculatewithindex_button.Enabled = true;
            billquery_button.Enabled = false;
            bills_button.Enabled = true;
            lastindexes_button.Enabled = true;
            
        }
        int count = 0;
        private void bills_button_Click(object sender, EventArgs e)
        {
            if (lastknownform != null)
            {
                FormGizle(lastknownform);
            }
            connection.updatedata();
            FormGetir(connection.bills);
            connection.updatedata();
            if (count == 0)
            {
                MessageBox.Show("Bu sayfada sorgula tuşuna bastığınzda KVKK koşullarını kabul etmiş sayılırsınız !");
                count++;
            }
            calculatewithindex_button.Enabled = true;
            billquery_button.Enabled = true;
            bills_button.Enabled = false;
            lastindexes_button.Enabled = true;
            
        }

        private void lastindexes_button_Click(object sender, EventArgs e)
        {
            if (lastknownform != null)
            {
                FormGizle(lastknownform);
            }
            connection.updatedata();
            FormGetir(connection.lastindexes);
            connection.updatedata();
            calculatewithindex_button.Enabled = true;
            billquery_button.Enabled = true;
            bills_button.Enabled = true;
            lastindexes_button.Enabled = false;
            
        }
    }
}
