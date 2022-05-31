using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab6
{
    public partial class lab62 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonDatabase_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            GridViewDatabase.DataSource = client.GetClients();
            GridViewDatabase.DataBind();
            LabelData.Text = "Data loaded from the database";
            if (Cache["data"] == null)
            {
                Cache["data"] = client.GetClients();
            }
        }
        protected void ButtonCache_Click(object sender, EventArgs e)
        {
            GridViewCache.DataSource = Cache["data"];
            GridViewCache.DataBind();
            LabelCache.Text = "Data loaded from Cache";
        }
    }
}