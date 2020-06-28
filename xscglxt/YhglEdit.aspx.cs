using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace xscglxt
{
    public partial class YhglEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebData.CurrentMenu = "修改用户";
            if (!IsPostBack)
            {
                string s_yhzh = Request.QueryString["yhzh"];
                string sql = "select * from yhxx where yhzh=N'{0}'".AsFormat(s_yhzh);
                DataTable table = new SqlServerHelper().QuerySqlDataTable(sql);
                if (table != null && table.Rows.Count > 0)
                {
                    yhzh.Text = table.Rows[0]["yhzh"].AsString();
                    yhxm.Text = table.Rows[0]["yhxm"].AsString();
                    yhmm.Text = table.Rows[0]["yhmm"].AsString();
                }
                else
                {
                    Response.Write("<script>alert('用户信息不存在');window.location.href='Yhgl.aspx';</script>");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                string s_yhzh = yhzh.Text;
                string s_yhxm = yhxm.Text;
                string s_yhmm = yhmm.Text;

                string sql = "update yhxx set yhxm='{1}',yhmm='{2}' where yhzh='{0}'".AsFormat(s_yhzh,s_yhxm,s_yhmm);

                new SqlServerHelper().ExecuteSql(sql);

                Response.Write("<script>alert('修改用户成功');window.location.href='Yhgl.aspx';</script>");

            }
        }
    }
}