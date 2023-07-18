using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FaturamYanimda
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            username_textbox.Text = "Kullanıcı Adı";
            password_textbox.Text = "Şifre";
            connection.GetConnection();
        }

        private void username_textbox_Enter(object sender, EventArgs e)
        {
            if (username_textbox.Text == "Kullanıcı Adı")
            {
                username_textbox.Text = "";
            }
        }

        private void username_textbox_Leave(object sender, EventArgs e)
        {
            if (username_textbox.Text =="")
            {
                username_textbox.Text = "Kullanıcı Adı";
            }
        }

        private void password_textbox_Enter(object sender, EventArgs e)
        {
            if (password_textbox.Text == "Şifre")
            {
                password_textbox.Text = "";
                password_textbox.Password = true;
            }
        }

        private void password_textbox_Leave(object sender, EventArgs e)
        {
            if (password_textbox.Text == "")
            {
                password_textbox.Text = "Şifre";
                password_textbox.Password = false;
            }
            else
            {
                password_textbox.Password = true;
                
            }
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            if (username_textbox.Text == "Kullanıcı Adı" || password_textbox.Text == "Şifre")
            {
                MessageBox.Show("Gerekli alanları doldurun !");
            }
            else
            {
                OleDbConnection con = connection.con;
                con.Open();
                string query = "SELECT Kullanıcılar.kullaniciadi, Kullanıcılar.şifre, Kullanıcılar.Kimlik FROM Kullanıcılar WHERE (((Kullanıcılar.kullaniciadi)='"+username_textbox.Text+"'));";
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader DR1 = command.ExecuteReader();

                if (DR1.Read())
                {
                    if (DR1.GetValue(0) == null)
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı !");
                    }
                    else
                    {
                        if (username_textbox.Text == DR1.GetValue(0).ToString() && password_textbox.Text ==DR1.GetValue(1).ToString())
                        {
                            MessageBox.Show("Giriş başarılı !");
                            connection.loggeduserid = Convert.ToInt32(DR1.GetValue(2));
                            con.Close();
                            this.Hide();
                            connection.Mainpage.Show();
                            
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı !");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı !");
                }
                con.Close();
            }
        }

        private void register_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            connection.Register.ShowDialog();
        }

        private void Mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
