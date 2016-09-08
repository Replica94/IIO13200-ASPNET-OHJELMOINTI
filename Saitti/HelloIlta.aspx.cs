using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HelloIlta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSayHello_Click(object sender, EventArgs e)
    {
        string messu = "";
        messu ="Hello " + txtName.Text;
        lblMessage.Text = messu;
    }
}