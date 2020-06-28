using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace xscglxt
{
    public partial class KnsglEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            WebData.CurrentMenu = "修改困难生";
            if (!IsPostBack)
            {
                string s_xsbm = Request.QueryString["xsbm"];
                string sql = "select * from knsxx where xsbm='{0}'".AsFormat(s_xsbm);
                DataTable table = new SqlServerHelper().QuerySqlDataTable(sql);
                if (table != null && table.Rows.Count > 0)
                {
                    xsbm.Text = table.Rows[0]["xsbm"].AsString();
                    xsxm.Text = table.Rows[0]["xsxm"].AsString();
                    xsxb.Value = table.Rows[0]["xsxb"].AsString();
                    xszy.Text = table.Rows[0]["xszy"].AsString();
                    xsbj.Text = table.Rows[0]["xsbj"].AsString();
                    beizhu.Text = table.Rows[0]["beizhu"].AsString();
                }
                else
                {
                    Response.Write("<script>alert('困难生信息不存在');window.location.href='Xsgl.aspx';</script>");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //获取页面数据
                string s_xsbm = xsbm.Text;
                string s_xsxm = xsxm.Text;
                string s_xsxb = xsxb.Value;
                string s_xszy = xszy.Text;
                string s_xsbj = xsbj.Text;
                string s_beizhu = beizhu.Text;
                //修改困难生
                string sql = ("update knsxx set xsxm='{1}',xsxb='{2}',xszy='{3}',xsbj='{4}',beizhu='{5}'" +
                    " where xsbm='{0}'")
                    .AsFormat(s_xsbm, s_xsxm, s_xsxb, s_xszy, s_xsbj, s_beizhu);
                new SqlServerHelper().ExecuteSql(sql);
                //提示用户
                Response.Write("<script>alert('修改困难生成功');window.location.href='Knsgl.aspx';</script>");

            }
        }
    }
}