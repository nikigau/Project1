<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style3.css" />
    
    <style>
        body{
            background: linear-gradient(115deg, #56d8e4 10%, #9f01ea 90%);
        }
    </style>
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        
            
            <table style="margin-top:150px">
                <tr>
                    <td>
            <asp:Image ID="Image1" runat="server" Height="211px" Width="297px"  ImageUrl="~/store/p1.jpg"/>
&nbsp;<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="College " OnClick="Button1_Click" CssClass="btn" />
                        </td>
                    <td>
            <asp:Image ID="Image2" runat="server" Height="215px" Width="294px" ImageUrl="~/store/p2.jpg" />
&nbsp;<br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Student " OnClick="Button2_Click" CssClass="btn1" />
                        </td>
                   
                    </tr>
                </table>
               
        
    </form>
        </center>
</body>
</html>
