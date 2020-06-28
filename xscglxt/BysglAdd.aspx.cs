using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace xscglxt
{
    public partial class BysglAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            WebData.CurrentMenu = "新增毕业生";
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
                string s_byrq = byrq.Text;
                //新增毕业生
                string sql = ("insert into bysxx(xsbm,xsxm,xsxb,xszy,xsbj,byrq)" +
                    "values('{0}','{1}','{2}','{3}','{4}','{5}')")
                    .AsFormat(s_xsbm, s_xsxm, s_xsxb, s_xszy, s_xsbj, s_byrq);
                new SqlServerHelper().ExecuteSql(sql);
                //提示用户
                Response.Write("<script>alert('新增毕业生成功');window.location.href='Bysgl.aspx';</script>");

            }
        }
    }
}