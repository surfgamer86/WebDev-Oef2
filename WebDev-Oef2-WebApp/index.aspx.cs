using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebDev_Oef2_Domain.Business;

namespace WebDev_Oef2_WebApp
{
    public partial class index : System.Web.UI.Page
    {
        Bc _bc = new Bc();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void VerstuurBTN_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.Naam = txtName.Value;
            newUser.Mail = txtMail.Value;

            _bc.SaveUserRegistration(newUser);
            
            int result = _bc.SaveUserRegistration(newUser);

            if (result == 1)
            {
                Response.Write("<script>alert('Gebruiker succesvol weggeschreven in databank.');</script>");
            }
            else Response.Write("<script>alert('no workey sadge.');</script>");
        }
    }
}