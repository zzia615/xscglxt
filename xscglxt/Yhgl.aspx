<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="Yhgl.aspx.cs" Inherits="xscglxt.Yhgl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="form-inline mt-2">
    <select class="form-control" runat="server" id="cxlb">
        <option value="">请选择查询类别</option>
        <option value="yhzh">账号</option>
        <option value="yhxm">姓名</option>
    </select>
    
    <asp:TextBox ID="cxnr" runat="server" placeholder="请输入查询内容" CssClass="form-control ml-1"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="查询" CssClass="btn btn-primary ml-1" OnClick="Button1_Click"/>
    <a href="YhglAdd.aspx" class="btn btn-primary ml-1">新增用户</a>
</div>
<div class="mt-2">
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped" AutoGenerateColumns="False" DataKeyNames="yhzh" DataSourceID="SqlDataSource1" style="border-color:#efefef;" EmptyDataText="没有查询到数据">
        <Columns>
            <asp:BoundField DataField="yhzh" HeaderText="账号" ReadOnly="True" SortExpression="yhzh" />
            <asp:BoundField DataField="yhxm" HeaderText="姓名" SortExpression="yhxm" />
            <asp:BoundField DataField="yhmm" HeaderText="密码" DataFormatString="******" SortExpression="yhmm" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"YhglEdit.aspx?yhzh="+Eval("yhzh") %>' Text="编辑" CssClass="btn btn-info btn-sm"></asp:HyperLink>
                    <%--<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="" Text="删除"></asp:HyperLink>--%>
                    <a class="btn btn-danger btn-sm" href="javascript:void(0);" onclick="if(confirm('确定删除用户信息？')){window.location.href='YhglDel.aspx?yhzh=<%# Eval("yhzh") %>';}" >删除</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:xscglxtConnectionString %>" SelectCommand="SELECT * FROM [yhxx]"></asp:SqlDataSource>
</div>
</asp:Content>
