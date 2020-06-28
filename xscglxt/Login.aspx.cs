using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace xscglxt
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //页面验证通过
            if (Page.IsValid)
            {
                //获取账户
                string yhzh = name.Text;
                //获取密码
                string yhmm = pwd.Text;
                //调用登录验证方法

                string sql = "select * from yhxx where yhzh='{0}' and yhmm='{1}'"
                    .AsFormat(yhzh, yhmm);
                int ret = new SqlServerHelper().QuerySqlCount(sql);

                //如果ret返回true，则验证通过，允许用户登录本系统。
                //如果ret返回false，则验证不通过，不允许用户登录本系统
                if (ret>0)
                {
                    WebData.LoginUser = yhzh;
                    WebData.LoginUserName = yhzh;

                    //将登录信息保存在会话里
                    Session[WebData.登录用户] = WebData.LoginUser;
                    Session[WebData.登录用户名] = WebData.LoginUserName;
                    //提示用户登录成功，并跳转到主页面
                    Response.Write("<script>alert('用户登录成功');window.location.href='Default.aspx'</script>");
                }
                else
                {
                    //提示用户账户密码错误
                    Response.Write("<script>alert('用户名密码错误，请重新输入');</script>");
                }
            }
        }
    }
}