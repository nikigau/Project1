<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="slogin.aspx.cs" Inherits="WebApplication1.slogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" href="style1.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div class="container">
                <div class="text">
               Student Login
            </div>
            <div class="form-row">
                <div class="input-data">
                    <div class="underline"></div>
                    <h4>Enter Student Email</h4>
                    <asp:TextBox ID="txtSemail" runat="server" CssClass="t1"></asp:TextBox>
                </div>
                <div class="form-row">
                <div class="input-data">
                    <div class="underline"></div>
                    <h4>Enter Student Password</h4>
                    <asp:TextBox ID="txtSpass" runat="server" CssClass="t1" TextMode="Password"></asp:TextBox>
                </div>
        </div>
                <asp:Button ID="btnSubmit" runat="server" Text="SUBMIT" CssClass="btn" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnAccount" runat="server" Text="NEW ACCOUNT" CssClass="btn1" OnClick="btnAccount_Click1" />
            </div>
                </div>

    </form>
</body>
</html>
