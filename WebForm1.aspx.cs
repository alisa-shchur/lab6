using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonForError_Click(object sender, EventArgs e)
        {
            Response.Redirect("fake.aspx");
        }

        protected void ButtonFirstPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("FirstPage.aspx");
        }

        protected void ButtonSecondPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("SecondPage.aspx");
        }

        protected void ButtonLab62_Click(object sender, EventArgs e)
        {
            Response.Redirect("lab62.aspx");
        }
    }
}