<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="YhglEdit.aspx.cs" Inherits="xscglxt.YhglEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="form-group">
    <asp:Label ID="Label1" runat="server" Text="账号" for="yhzh"></asp:Label>
    <asp:TextBox ID="yhzh" runat="server" placeholder="请输入账号" CssClass="form-control" Enabled="false"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="账号不能为空" ControlToValidate="yhzh" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
</div>
<div class="form-group">
    <asp:Label ID="Label2" runat="server" Text="姓名" for="yhxm"></asp:Label>
    <asp:TextBox ID="yhxm" runat="server" placeholder="请输入姓名" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="姓名不能为空" ControlToValidate="yhxm" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
</div>
<div class="form-group">
    <asp:Label ID="Label3" runat="server" Text="密码" for="yhmm"></asp:Label>
    <asp:TextBox ID="yhmm" runat="server" placeholder="请输入密码" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="密码不能为空" ControlToValidate="yhmm" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
</div>
<asp:Button ID="Button1" runat="server" Text="修改" CssClass="btn btn-primary" OnClick="Button1_Click"/>
<a href="Yhgl.aspx" class="btn btn-light ml-1">返回用户管理</a>
</asp:Content>
