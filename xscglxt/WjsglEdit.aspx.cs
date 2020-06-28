using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace xscglxt
{
    public partial class WjsglEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            WebData.CurrentMenu = "修改违纪生";
            if (!IsPostBack)
            {
                string s_id = Request.QueryString["id"];
                string sql = "select * from wjsxx where id={0}".AsFormat(s_id);
                DataTable table = new SqlServerHelper().QuerySqlDataTable(sql);
                if (table != null && table.Rows.Count > 0)
                {
                    id.Text = table.Rows[0]["id"].AsString();
                    xsbm.Text = table.Rows[0]["xsbm"].AsString();
                    xsxm.Text = table.Rows[0]["xsxm"].AsString();
                    xsxb.Value = table.Rows[0]["xsxb"].AsString();
                    xszy.Text = table.Rows[0]["xszy"].AsString();
                    xsbj.Text = table.Rows[0]["xsbj"].AsString();
                    wjnr.Text = table.Rows[0]["wjnr"].AsString();
                    wjcf.Text = table.Rows[0]["wjcf"].AsString();
                }
                else
                {
                    Response.Write("<script>alert('违纪生信息不存在');window.location.href='Xsgl.aspx';</script>");
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
                string s_wjnr = wjnr.Text;
                string s_wjcf = wjcf.Text;
                string s_id = id.Text;
                //修改违纪生
                string sql = ("update wjsxx set xsbm='{1}',xsxm='{2}',xsxb='{3}',xszy='{4}',xsbj='{5}',wjnr='{6}',wjcf='{7}'" +
                    " where id={0}")
                    .AsFormat(s_id,s_xsbm, s_xsxm, s_xsxb, s_xszy, s_xsbj, s_wjnr,s_wjcf);
                new SqlServerHelper().ExecuteSql(sql);
                //提示用户
                Response.Write("<script>alert('修改违纪生成功');window.location.href='Wjsgl.aspx';</script>");

            }
        }
    }
}