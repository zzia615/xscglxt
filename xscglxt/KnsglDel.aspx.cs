using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace xscglxt
{
    public partial class KnsglDel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_xsbm = Request.QueryString["xsbm"];
            if (!string.IsNullOrEmpty(s_xsbm))
            {
                string sql = "delete from knsxx where xsbm='{0}'".AsFormat(s_xsbm);
                new SqlServerHelper().ExecuteSql(sql);
                Response.Write("<script>alert('删除困难生信息成功');window.location.href='Knsgl.aspx';</script>");
            }
        }
    }
}