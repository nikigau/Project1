<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentreg.aspx.cs" Inherits="WebApplication1.studentlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style1.css" />
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h4>Select Your College</h4>
            <asp:DropDownList ID="ddlClg" runat="server" CssClass="custom-dropdown"></asp:DropDownList>
            <h4>Student Name</h4>
            <asp:TextBox ID="txtSname" runat="server" CssClass="t1"></asp:TextBox>
            <h4>Select Branch</h4>
            <asp:DropDownList ID="ddlBranch" runat="server" CssClass="custom-dropdown"></asp:DropDownList>
            <h4>Email</h4>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="t1"></asp:TextBox>
            <h4>Mobile</h4>
            <asp:TextBox ID="txtMobile" runat="server" CssClass="t1"></asp:TextBox>
            <h4>Semester</h4>
            <asp:TextBox ID="txtSemester" runat="server" CssClass="t1"></asp:TextBox>
            <h4>Password</h4>
            <asp:TextBox ID="txtPass" runat="server" CssClass="t1" TextMode="Password"></asp:TextBox>
            <h4>Date</h4>
            <asp:TextBox ID="txtDate" runat="server" CssClass="t1"></asp:TextBox>
            <br />
            <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn1" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
