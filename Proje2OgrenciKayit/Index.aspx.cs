using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje2OgrenciKayit
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLOGRENCILERTableAdapter tableAdapter = new DataSet1TableAdapters.TBLOGRENCILERTableAdapter();
            tableAdapter.OgrenciEkle(txtAdSoyad.Text, txtNumber.Text, txtMail.Text, DropDownList1.Text, DropDownList2.Text);
        }
    }
}