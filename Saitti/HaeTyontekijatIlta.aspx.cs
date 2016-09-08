using System;
using System.Configuration; //webconfigia varten
using System.Data; //ADO.NETin luokkia varten
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HaeTyontekijatIlta : System.Web.UI.Page
{
    string xmlfilu;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Tässä luetaan webconfigista XML-tiedoston nimi
        xmlfilu = ConfigurationManager.AppSettings["tiedosto"];
        lblMessage.Text = xmlfilu;
    }

    protected void btnHae_Click(object sender, EventArgs e)
    {
        //luetaan XML-tiedostosta työntekijöitten tiedot ja esitetään ne GridView:ssä
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        ds.ReadXml(Server.MapPath(xmlfilu));
        dt = ds.Tables[0];
        dv = dt.DefaultView;
        //datan sitominen UI-kontrolliin
        gvData.DataSource = dv;
        gvData.DataBind();
        lblMessage.Text = string.Format("Löytyi {0} työntekijää", dt.Rows.Count);
    }
}