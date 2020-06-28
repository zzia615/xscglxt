<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="XsglEdit.aspx.cs" Inherits="xscglxt.XsglEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="form-group">
    <asp:Label ID="Label1" runat="server" Text="学号" for="xsbm"></asp:Label>
    <asp:TextBox ID="xsbm" runat="server" placeholder="请输入学号" CssClass="form-control" Enabled="false"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="学号不能为空" ControlToValidate="xsbm" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
</div>
<div class="form-group">
    <asp:Label ID="Label2" runat="server" Text="姓名" for="xsxm"></asp:Label>
    <asp:TextBox ID="xsxm" runat="server" placeholder="请输入姓名" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="姓名不能为空" ControlToValidate="xsxm" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
</div>
<div class="form-group">
    <asp:Label ID="Label4" runat="server" Text="性别" for="xsxb"></asp:Label>
    <select class="form-control" runat="server" id="xsxb">
        <option value="">请选择性别</option>
        <option value="男">男</option>
        <option value="女">女</option>
    </select>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="性别不能为空" ControlToValidate="xsxb" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
</div>
    
<div class="form-group">
    <asp:Label ID="Label5" runat="server" Text="专业" for="xszy"></asp:Label>
    <asp:TextBox ID="xszy" runat="server" placeholder="请输入专业" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="专业不能为空" ControlToValidate="xszy" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
</div>
    
<div class="form-group">
    <asp:Label ID="Label6" runat="server" Text="班级" for="xsbj"></asp:Label>
    <asp:TextBox ID="xsbj" runat="server" placeholder="请输入班级" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="班级不能为空" ControlToValidate="xsbj" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
</div>


<div class="form-group">
    <asp:Label ID="Label7" runat="server" Text="入学日期" for="rxrq"></asp:Label>
    <asp:TextBox ID="rxrq" runat="server" placeholder="yyyy/MM/dd" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="入学日期不能为空" ControlToValidate="rxrq" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="入学日期输入不合法" ControlToValidate="rxrq" ForeColor="Red" Display="Dynamic" Type="Date" MaximumValue="2999-12-31" MinimumValue="2000-01-01"></asp:RangeValidator>
</div>

<asp:Button ID="Button1" runat="server" Text="修改" CssClass="btn btn-primary" OnClick="Button1_Click"/>
<a href="Xsgl.aspx" class="btn btn-light ml-1">返回新生管理</a>
</asp:Content>
