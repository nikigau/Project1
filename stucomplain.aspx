<%@ Page Title="" Language="C#" MasterPageFile="~/student.Master" AutoEventWireup="true" CodeBehind="stucomplain.aspx.cs" Inherits="WebApplication1.stucomplain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" href="style3.css" />
    <p>
        College Name:
        <asp:TextBox ID="txtCname" runat="server" CssClass="t1"></asp:TextBox>
    </p>
    <p>
        Student Name:<asp:TextBox ID="txtSname" runat="server" CssClass="t1"></asp:TextBox>
    </p>
    <p>
        Email:<asp:TextBox ID="txtEmail" runat="server" CssClass="t1"></asp:TextBox>
    </p>
    <p>
        Branch:<asp:TextBox ID="txtBranch" runat="server" CssClass="t1"></asp:TextBox>
    </p>
    <p>
        Complain To:<asp:DropDownList ID="ddlComplain" runat="server" CssClass="custom-dropdown">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>ACCOUNT</asp:ListItem>
            <asp:ListItem>EXAM</asp:ListItem>
            <asp:ListItem>SPORT</asp:ListItem>
            <asp:ListItem>ADMISSION</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Message:<asp:TextBox ID="txtMsg" runat="server" CssClass="t1"></asp:TextBox>
    </p>
    <p>
        Date:<asp:TextBox ID="txtDate" runat="server" CssClass="t1"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
    </p>
     <p>
        <asp:Button ID="btnSubmit" runat="server" Text="SUBMIT" CssClass="btn" OnClick="btnSubmit_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnShow" runat="server" Text="SHOW" CssClass="btn1" OnClick="btnShow_Click" />
    </p>
     <p>
         &nbsp;</p>
     <p>
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="231px" Width="816px">
             <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
             <Columns>
                 <asp:TemplateField HeaderText="Sno">
                     <ItemTemplate>
                         <%#Container.DataItemIndex+1 %>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:BoundField DataField="Cname" HeaderText="College Name" />
                 <asp:BoundField DataField="StuName" HeaderText="Student Name" />
                 <asp:BoundField DataField="Branch" HeaderText="Branch" />
                 <asp:BoundField DataField="Complain" HeaderText="Complain To" />
                 <asp:BoundField DataField="Msg" HeaderText="Message" />
                 <asp:BoundField DataField="Date" HeaderText="Date" />
                 <asp:TemplateField HeaderText="Action">
                     <ItemTemplate>
                         <asp:Button ID="btnDelete" runat="server" Text="Delete" />
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
