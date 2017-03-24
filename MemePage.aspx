<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemePage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="MemePageStyle.css"  type="text/css" />
</head>

    <!--UPDATE SCROLLING TEXT -->
<h2 class="scroll-left" style ="position:absolute; TOP:-14px; LEFT:-1px;" >
<p style ="position:absolute; TOP:18px;">You know me, I gotta put in a big tree.</p>
</h2>
    <!--BACKGROUND DECLARATION -->
<body background ="bobross background.jpg">
    <form id="form1" runat="server">
        <a style ="position:absolute; TOP:20px; LEFT:1500px; WIDTH:70px; HEIGHT:30px"href="SignIn.aspx">Sign in</a>

        <a style ="position:absolute; TOP:20px; LEFT:1350px; WIDTH:70px; HEIGHT:30px"href="SignUp.aspx">Sign up</a>
    <div>
        
                 <asp:Image style="position:absolute; WIDTH:480px; z-index: +1; top:200px; left:36%" 
                    ID="srcImg" runat="server" ImageURL="~/Images/MemeMachine Icon.jpg">  </asp:Image> 
        
                 <asp:Image style="position:absolute;top:200px; left:36%; width:480px" ID="tempImg" runat="server" ImageURL="~/Images/MemeMachine Icon.jpg"> </asp:Image>
                 
           <!-- <button type="button" class ="memeButton" style = "position:absolute; left:45.8%; top:730px" ID="Button4" runat="server" OnServerClick="Button1_Click" >Generate Meme</button>-->
            <asp:Button class ="memeButton" style = "position:absolute; left:45.8%; top:730px" ID="Button1" runat="server" Text="Generate Meme" OnClick="Button1_Click"/>
                
         s
       <%-- <asp:Image ID="srcImgT" runat="server" >  </asp:Image> 
        <asp:Image style="position:absolute; width:380px" ID="tempImgT" runat="server" ImageURL="~/Images/MemeMachine Icon.jpg"> </asp:Image>--%>
        
    </div>
       
        <!--
        <asp:Label style = "position:absolute; top:500px" ID ="Label1" runat="server" Text="Picture"></asp:Label>
        <p>
            &nbsp;</p> -->
       <!-- <button id="button12" style = "position:absolute; left:47%; top:730px"  runat="server" onServerClick="Button1_Click" >Submit</button>-->
        <asp:DropDownList ID="DropDownList1" runat="server"  AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_Change" style ="position:absolute; left:20%; top:300px">
                 </asp:DropDownList>

            <asp:DropDownList ID="DropDownList2" runat="server"  AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_Change" style ="position:absolute; left:20%; top:380px">
                 </asp:DropDownList>
         <asp:Button class ="memeButton" style = "position:absolute; left:20%; top:250px" ID="Button2" runat="server" Text="Change Source   " OnClick="Button2_Click"/>

         <asp:Button class ="memeButton" style = "position:absolute; left:20%; top:330px" ID="Button3" runat="server" Text="Change Template" OnClick="Button3_Click"/>

          
            
    </form>
</body>
</html>
