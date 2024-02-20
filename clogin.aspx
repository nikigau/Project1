<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clogin.aspx.cs" Inherits="WebApplication1.clogin" %>

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
                College Login
            </div>
            <div class="form-row">
                <div class="input-data">
                    <div class="underline"></div>
                    <h4>Enter College ID/CODE</h4>
                    <asp:TextBox ID="txtCid" runat="server" CssClass="t1"></asp:TextBox>
                </div>
            </div>
            <div class="form-row">
                <div class="input-data">
                    <div class="underline"></div>
                    <h4>Enter Password</h4>
                    <asp:TextBox ID="txtPass" runat="server" CssClass="t1" TextMode="Password"></asp:TextBox>
                </div>
                <asp:Button ID="btnSubmit" runat="server" Text="SUBMIT" CssClass="btn" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnAcc" runat="server" Text="NEW ACCOUNT" CssClass="btn1" OnClick="Button2_Click" />
            </div>
        </div>
    </form>
</body>
</html>
