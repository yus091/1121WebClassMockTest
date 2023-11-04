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
            userLB.Text = Session["name"] + " 歡迎你，已參加下列活動：<br>";
        }

    }
}