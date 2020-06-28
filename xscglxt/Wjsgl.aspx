<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="Wjsgl.aspx.cs" Inherits="xscglxt.Wjsgl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="form-inline mt-2">
    <select class="form-control" runat="server" id="cxlb">
        <option value="">请选择查询类别</option>
        <option value="xsbm">学号</option>
        <option value="xsxm">姓名</option>
        <option value="xsxb">性别</option>
        <option value="xszy">专业</option>
        <option value="xsbj">班级</option>
    </select>
    
    <asp:TextBox ID="cxnr" runat="server" placeholder="请输入查询内容" CssClass="form-control ml-1"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="查询" CssClass="btn btn-primary ml-1" OnClick="Button1_Click"/>
    <a href="WjsglAdd.aspx" class="btn btn-primary ml-1">新增违纪生</a>
</div>
<div class="mt-2">
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" style="border-color:#efefef;" EmptyDataText="没有查询到数据">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="编号" ReadOnly="True" Visible="false" SortExpression="id" />
            <asp:BoundField DataField="xsbm" HeaderText="学号" SortExpression="xsbm" />
            <asp:BoundField DataField="xsxm" HeaderText="姓名" SortExpression="xsxm" />
            <asp:BoundField DataField="wjnr" HeaderText="违纪内容" SortExpression="wjnr" />
            <asp:BoundField DataField="wjcf" HeaderText="违纪惩罚" SortExpression="wjcf" />
            <asp:BoundField DataField="xsxb" HeaderText="性别" SortExpression="xsxb" />
            <asp:BoundField DataField="xszy" HeaderText="专业" SortExpression="xszy" />
            <asp:BoundField DataField="xsbj" HeaderText="班级" SortExpression="xsbj" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"WjsglEdit.aspx?id="+Eval("id") %>' Text="编辑" CssClass="btn btn-info btn-sm"></asp:HyperLink>
                    <%--<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="" Text="删除"></asp:HyperLink>--%>
                    <a class="btn btn-danger btn-sm" href="javascript:void(0);" onclick="if(confirm('确定删除违纪生信息？')){window.location.href='WjsglDel.aspx?id=<%#Eval("id") %>';}" >删除</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:xscglxtConnectionString %>" SelectCommand="SELECT * FROM [wjsxx]"></asp:SqlDataSource>
</div>
</asp:Content>
