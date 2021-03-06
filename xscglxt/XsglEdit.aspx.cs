﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace xscglxt
{
    public partial class XsglEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            WebData.CurrentMenu = "修改新生";
            if (!IsPostBack)
            {
                string s_xsbm = Request.QueryString["xsbm"];
                string sql = "select * from xsxx where xsbm='{0}'".AsFormat(s_xsbm);
                DataTable table = new SqlServerHelper().QuerySqlDataTable(sql);
                if (table != null && table.Rows.Count > 0)
                {
                    xsbm.Text = table.Rows[0]["xsbm"].AsString();
                    xsxm.Text = table.Rows[0]["xsxm"].AsString();
                    xsxb.Value = table.Rows[0]["xsxb"].AsString();
                    xszy.Text = table.Rows[0]["xszy"].AsString();
                    xsbj.Text = table.Rows[0]["xsbj"].AsString();
                    rxrq.Text = table.Rows[0]["rxrq"].AsD10();
                }
                else
                {
                    Response.Write("<script>alert('新生信息不存在');window.location.href='Xsgl.aspx';</script>");
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
                string s_rxrq = rxrq.Text;
                //修改新生
                string sql = ("update xsxx set xsxm='{1}',xsxb='{2}',xszy='{3}',xsbj='{4}',rxrq='{5}'" +
                    " where xsbm='{0}'")
                    .AsFormat(s_xsbm, s_xsxm, s_xsxb, s_xszy, s_xsbj, s_rxrq);
                new SqlServerHelper().ExecuteSql(sql);
                //提示用户
                Response.Write("<script>alert('修改新生成功');window.location.href='Xsgl.aspx';</script>");

            }
        }
    }
}