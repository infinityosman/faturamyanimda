using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace FaturamYanimda
{
    public partial class Register : MaterialForm
    {
        public Register()
        {
            InitializeComponent();
        }

        
        private void Register_Load(object sender, EventArgs e)
        {
            username_textbox.Text = "Kullanıcı Adı";
            password_textbox.Text = "Şifre";
            email_textbox.Text ="E-posta";
            city_combobox.Text ="Şehir";
            name_textbox.Text = "Ad";
            surname_textbox.Text = "Soyad";
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
            if (username_textbox.Text == "")
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

        private void email_textbox_Enter(object sender, EventArgs e)
        {
            if (email_textbox.Text == "E-posta")
            {
                email_textbox.Text = "";
            }
        }

        private void email_textbox_Leave(object sender, EventArgs e)
        {
            if (email_textbox.Text == "")
            {
                email_textbox.Text = "E-posta";
            }
        }

        private void city_combobox_Enter(object sender, EventArgs e)
        {
            if (city_combobox.Text == "Şehir")
            {
                city_combobox.Text = "";
            }
        }

        private void city_combobox_Leave(object sender, EventArgs e)
        {
            if (city_combobox.Text == "")
            {
                city_combobox.Text = "Şehir";
            }
        }

        private void name_textbox_Enter(object sender, EventArgs e)
        {
            if (name_textbox.Text == "Ad")
            {
                name_textbox.Text = "";
            }
        }

        private void name_textbox_Leave(object sender, EventArgs e)
        {
            if (name_textbox.Text == "")
            {
                name_textbox.Text = "Ad";
            }
        }

        private void surname_textbox_Enter(object sender, EventArgs e)
        {
            if (surname_textbox.Text == "Soyad")
            {
                surname_textbox.Text = "";
            }
        }

        private void surname_textbox_Leave(object sender, EventArgs e)
        {
            if (surname_textbox.Text == "")
            {
                surname_textbox.Text = "Soyad";
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (name_textbox.Text =="Ad" || surname_textbox.Text =="Soyad" || username_textbox.Text =="Kullanıcı Adı" || password_textbox.Text =="Şifre" || email_textbox.Text == "E-posta" || phonenumber_textbox.Text == "(   )    -")
            {
                MessageBox.Show("Gerekli alanları doldurun !");
            }
            else
            {
                try
                {
                    OleDbConnection con = connection.con;
                    string query;
                    con.Open();
                    query = "INSERT INTO Kullanıcılar ( isim, soyad, kullaniciadi, şifre, eposta, telefonno, şehir ) values('" + name_textbox.Text + "','" + surname_textbox.Text + "','" + username_textbox.Text + "','" + password_textbox.Text + "','" + email_textbox.Text + "','" + phonenumber_textbox.Text + "','" + city_combobox.Text + "')";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Başarılı bir şekilde kayıt oldunuz.");
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Veritabanına bağlanırken hata oluştu !" + ex.Message);
                }
            }
        }
    }
}
