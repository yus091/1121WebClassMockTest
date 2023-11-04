using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace moni1
{
    public partial class parter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            eventSearchDataSource.DataBind();
            userLB.Text = Session["name"] + " 歡迎你，已參加下列活動：<br>";
        }

        protected void eventSearchBT_Click(object sender, EventArgs e)
        {
            Session["eventSearch"] = eventSearchTB.Text;
        }

        protected void insertEventBT_Click(object sender, EventArgs e)
        {
            Session["insertEvent"] = insertEventTB.Text;
        }
    }
}