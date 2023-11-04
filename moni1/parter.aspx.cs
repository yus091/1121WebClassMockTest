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
            isEventDetailsView.DataBind();
            //userJoinDataSource.DataBind();
            userLB.Text = Session["name"] + " 歡迎你，已參加下列活動：<br>";
        }

        protected void eventSearchBT_Click(object sender, EventArgs e)
        {
            Session["eventSearch"] = eventSearchTB.Text;
        }

        protected void insertEventBT_Click(object sender, EventArgs e)
        {
            
            if(isEventDetailsView.DataItemCount != 0)
            {
                Session["insertEvent"] = insertEventTB.Text;
                insertSuccessLB.Text = "新增成功！";
                insertSuccessLB.Visible = true;
                eventSearchDataSource.Insert();
                GridView1.DataBind();
            }
            else
            {
                Session["insertEvent"] = null;
                insertSuccessLB.Text = "新增失敗，請輸入正確的活動編號！";
                insertSuccessLB.Visible = true;
            }
        }
    }
}