using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proje
{
    public partial class siparis : System.Web.UI.Page
    {
        private string[] yemekleri;

        public string Yemekler { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Clear();
            Sınıflar.Asci yemekler = new Sınıflar.Asci();
            string [] yemekleri = yemekler.Yemek(Yemekler);
            string yeme;
            for(int i=0; i < 3; i++)
            {
                DropDownList1.Items.Add(yemekleri[i]);
            }
            
            
            
            
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
           

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedItem.ToString();

        }
    }
}