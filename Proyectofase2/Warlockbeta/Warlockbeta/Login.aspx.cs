using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warlockbeta
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        IngresoDB.Agregar_dato IDB = new IngresoDB.Agregar_dato();
        ConsultarDB.Consultar CDB = new ConsultarDB.Consultar();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Tb_Email_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            IDB.Agregar_Usuario(Tb_Nickname.Text,Tb_Name.Text,Tb_Email.Text,Tb_Password.Text);
            int idlog = CDB.Validar_Login(Tb_Nickname.Text, Tb_Password.Text);
          
                Session["id"] = idlog;
                Session["nickname"] = Tb_Nickname.Text;
                Response.Redirect("Perfilpopo.aspx");
          
            Tb_Email.Text = "";
            Tb_Nickname.Text = "";
            Tb_Name.Text = "";
            Tb_Password.Text = "";


        }

        protected void Bt_Log_Click(object sender, EventArgs e)
        {
            
            int idlog = CDB.Validar_Login(Tb_LNickname.Text,Tb_Lpass.Text);
            if (idlog!=0)
            {
                Session["id"] = idlog;
                Session["nickname"] = Tb_LNickname.Text;
                Response.Redirect("Perfilpopo.aspx");
            }
            else
            {
                Tb_LNickname.Text = "Algun dato es erroneo";
                Tb_Lpass.Text = "";
            }
        }
    }
}