<%@ Page Title="" Language="C#" MasterPageFile="~/Cadmin.Master" AutoEventWireup="true" CodeBehind="departuser.aspx.cs" Inherits="WebApplication1.departuser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="style3.css" />
    <p>
        College Name:<asp:TextBox ID="txtCname" CssClass="t1" runat="server"></asp:TextBox>
    </p>
    <p>
        College Code:<asp:TextBox ID="txtCcode" CssClass="t1" runat="server"></asp:TextBox>
    </p>
    <p>
        Department Name:<asp:DropDownList ID="ddlDepart" runat="server" CssClass="custom-dropdown">
        </asp:DropDownList>
    </p>
    <p>
        Faculty Name:<asp:TextBox ID="txtFaculty" runat="server" CssClass="t1"></asp:TextBox>
    </p>
    <p>
        UserId:<asp:TextBox ID="txtUser" runat="server" CssClass="t1"></asp:TextBox>
    </p>
    <p>
        Password:<asp:TextBox ID="txtPass" runat="server" CssClass="t1" TextMode="Password" ></asp:TextBox>
    </p>
    <p>
        Date:<asp:TextBox ID="txtDate" runat="server" CssClass="t1"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" CssClass="btn1" />
    </p>
    <p>
        <asp:DropDownList ID="ddlDepart1" runat="server" CssClass="custom-dropdown" >
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" CssClass="btn1" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="262px" Width="836px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="Sno">
                    <ItemTemplate>
                        <%#Container.DataItemIndex+1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="College Name">
                    <ItemTemplate>
                        <asp:TextBox ID="txtClg" runat="server" Text='<%#Eval("Cname") %>' ></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Department Name">
                    <ItemTemplate>
                        <asp:TextBox ID="txtDepart" runat="server" Text='<%#Eval("Dname") %>' ></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Faculty Name">
                    <ItemTemplate>
                        <asp:TextBox ID="txtFac" runat="server" Text='<%#Eval("Uname") %>' ></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="UserId">
                    <ItemTemplate>
                        <asp:TextBox ID="txtUid" runat="server" Text='<%#Eval("uid") %>' ></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                
                
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:Button ID="btnEdit" runat="server" Text="Edit" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </p>
</asp:Content>
