<%@ Page Title="" Language="C#" MasterPageFile="~/Cadmin.Master" AutoEventWireup="true" CodeBehind="department.aspx.cs" Inherits="WebApplication1.department" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="style3.css" />
   
    <p>
        College Name:
        <asp:TextBox ID="txtCName" runat="server" CssClass="t1"></asp:TextBox>
    </p>
    <p>
        College Code:<asp:TextBox ID="txtCcode" runat="server" CssClass="t1"></asp:TextBox>
    </p>
    <p>
        Department Name:
        <asp:TextBox ID="txtDepart" runat="server" CssClass="t1"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
       
    </p>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"  CssClass="btn"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" CssClass="btn1" />
       
    </p>
       
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="SNo.">
                    <ItemTemplate>
                        <%#Container.DataItemIndex+1 %>
                    </ItemTemplate>

                </asp:TemplateField>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:CheckBox ID="check" runat="server" />
                    </ItemTemplate>


                </asp:TemplateField>
                <asp:BoundField DataField="CCode" HeaderText="College Code" />
                <asp:BoundField DataField="DName" HeaderText="Department Name" />
                
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
    <p>
        <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />
    </p>
</asp:Content>
