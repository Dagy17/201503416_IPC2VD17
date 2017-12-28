using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warlockbeta
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lbl_nombre.Text = Session["nickname"].ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["id"] = 0;
            Session["nickname"] = "";
            Response.Redirect("Login.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

        }
    }
}