<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CReg.aspx.cs" Inherits="WebApplication1.CReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style1.css" />
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div class="container">
                 <h4>Enter College Name</h4>
                 <asp:TextBox ID="txtCname" runat="server" CssClass="t1"></asp:TextBox>
                 <h4>Enter College Code</h4>
                 <asp:TextBox ID="txtCcode" runat="server" CssClass="t1"></asp:TextBox>
                 <h4>Principle name</h4>
                 <asp:TextBox ID="txtPname" runat="server" CssClass="t1"></asp:TextBox>
                 <h4>Email Id</h4>
                 <asp:TextBox ID="txtEmail" runat="server" CssClass="t1"></asp:TextBox>
                 <h4>Mobile Number</h4>
                 <asp:TextBox ID="txtMobile" runat="server" CssClass="t1"></asp:TextBox>
                 <h4>Enter Password</h4>
                 <asp:TextBox ID="txtPass" runat="server" CssClass="t1" TextMode="Password"></asp:TextBox>
                 <h4>Date</h4>
                 <asp:TextBox ID="txtDate" runat="server" CssClass="t1"></asp:TextBox>
                 <br />
                 <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
                 <br />
                 <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn" OnClick="btnSubmit_Click" />
                 <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn1" OnClick="btnLogin_Click" />
                 </div>
        </div>
    </form>
</body>
</html>
