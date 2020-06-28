using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace xscglxt
{
    public partial class YhglAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            WebData.CurrentMenu = "新增用户";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //获取页面数据
                string s_yhzh = yhzh.Text;
                string s_yhxm = yhxm.Text;
                string s_yhmm = yhmm.Text;
                //新增用户


                string sql = "insert into yhxx(yhzh,yhxm,yhmm)" +
                    "values('{0}','{1}','{2}')".AsFormat(s_yhzh, s_yhxm, s_yhmm);

                new SqlServerHelper().ExecuteSql(sql);
                
                //提示
                Response.Write("<script>alert('新增用户成功');window.location.href='Yhgl.aspx';</script>");

            }
        }
    }
}