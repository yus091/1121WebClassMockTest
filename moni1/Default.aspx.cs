using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace moni1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loginStateLB.Text = "";
            phoneDetailsView.DataBind();
        }

        protected void loginBT_Click(object sender, EventArgs e)
        {
            phoneDetailsView.Visible = false;
            entryLBT.Visible = false;

            if (phoneDetailsView.DataItemCount == 1)
            {
                Session["name"] = phoneDetailsView.Rows[0].Cells[1].Text;
                Session["phone"] = phoneDetailsView.Rows[1].Cells[1].Text;
                phoneDetailsView.Visible = false;
                entryLBT.Visible = true;
                loginStateLB.Text = "登入成功！";
            }
            else
            {
                Session["phone"] = null;
                phoneDetailsView.Visible = true;
            }
        }

        protected void entryLBT_Click(object sender, EventArgs e)
        {

        }
    }
}