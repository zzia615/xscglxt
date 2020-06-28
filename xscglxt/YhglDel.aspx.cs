using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace xscglxt
{
    public partial class YhglDel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_yhzh = Request.QueryString["yhzh"];
            if (!string.IsNullOrEmpty(s_yhzh))
            {
                string sql = "delete from yhxx where yhzh='{0}'".AsFormat(s_yhzh);
                new SqlServerHelper().ExecuteSql(sql);
                Response.Write("<script>alert('删除用户信息成功');window.location.href='Yhgl.aspx';</script>");
            }
        }
    }
}