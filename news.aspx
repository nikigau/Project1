<%@ Page Title="" Language="C#" MasterPageFile="~/Cadmin.Master" AutoEventWireup="true" CodeBehind="news.aspx.cs" Inherits="WebApplication1.news" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="style3.css" />
    <p>
        College Code:
        <asp:Label ID="lblCCode" runat="server" Text="Label" ></asp:Label>
    </p>
    <br />
    <p>
        College Name:<asp:Label ID="lblCname" runat="server" Text="Label" ></asp:Label>
    </p>
    <br />
    <p>
        News Title:
        <asp:TextBox ID="txtNews" runat="server" CssClass="t1" ></asp:TextBox>
    </p>
    <p>
        &nbsp;Message:<asp:TextBox ID="txtMsg" runat="server" CssClass="t1"></asp:TextBox>
    </p>
    <p>
        &nbsp;Date:<asp:TextBox ID="txtDate" runat="server" CssClass="t1"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Show" CssClass="btn1" OnClick="Button2_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="Sno">
                    <ItemTemplate>
                        <%#Container.DataItemIndex+1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="College Code">
                    <ItemTemplate>
                        <asp:TextBox ID="txtCcode" runat="server" Text='<%#Eval("Ccode") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:TextBox ID="txtCname" runat="server" Text='<%#Eval("Cname") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Title">
                    <ItemTemplate>
                        <asp:TextBox ID="txtTitle" runat="server" Text='<%#Eval("NewsT") %>' ></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Message">
                    <ItemTemplate>
                        <asp:TextBox ID="txtMsg" runat="server" Text='<%#Eval("Msg") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Action1">
                    <ItemTemplate>
                        <asp:Button ID="btnEdit" runat="server" Text="Edit" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Action2">
                    <ItemTemplate>
                        <asp:Button ID="btnDel" runat="server" Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
