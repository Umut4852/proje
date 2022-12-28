using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proje
{
    public partial class Login : System.Web.UI.Page
    {
        public string adi;
        private string kullanici;
        private string Sifre;

        // Sınıflar.Kurye Kurye = new Sınıflar.Kurye();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Sınıflar.Mudur mudur = new Sınıflar.Mudur();
            adi = mudur.Kullanici_Adi(kullanici);

            TextBox1.Text = adi;

            Sifre = mudur.Sifre(Sifre);
            TextBox2.Text = Sifre;



            if (TextBox1.Text == adi && TextBox2.Text == Sifre)
            {
                Response.Redirect("Admin.aspx");
            }
            else
            {
                Label4.Text = ("Lütfen ID ve Şifrenizi Kontrol Ediniz !");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("siparis.aspx");
            
        }
    }
}