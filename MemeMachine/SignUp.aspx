<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="SignUpStyle.css"  type="text/css" />
</head>
<body background ="bobross background.jpg">
    <form id="form1" runat="server">

        <asp:Label ID="Label1" runat="server" Text=""  style ="position:absolute; TOP:395px;  left:45%; z-index: +1;"></asp:Label>

        <asp:Image style="position:absolute;top:200px; left:36%; width:480px" ID="tempImg" runat="server" ImageURL="~/Images/MemeMachine Icon.jpg"> </asp:Image>
    <div>
        <p style ="position:absolute; TOP:585px; LEFT:700px;">
        Username:<br>
        </p>
       
        <p style ="position:absolute; TOP:635px; LEFT:700px;">
        Password:<br>
        </p>

        <p style ="position:absolute; TOP:685px; LEFT:645px;">
        Confirm Password:<br>
        </p>
       

        <asp:TextBox ID="userName" runat="server" style ="position:absolute; TOP:600px; LEFT:780px;"></asp:TextBox>
        <asp:TextBox ID="passWord" runat="server" style ="position:absolute; TOP:650px; LEFT:780px;"></asp:TextBox>
        <asp:TextBox ID="confirmPass" runat="server" style ="position:absolute; TOP:700px; LEFT:780px;"></asp:TextBox>

    </div>
        <h3 style = "position:absolute; left:43.5%; top:513px">Already a member? <a href="SignIn.aspx">Log In...</a></h3>

        <asp:Button class ="SignUp" style = "position:absolute; left:47%; top:770px" ID="Button1" runat="server" Text="Sign Up" OnClick="Button3_Click"/>
    </form>
</body>
</html>