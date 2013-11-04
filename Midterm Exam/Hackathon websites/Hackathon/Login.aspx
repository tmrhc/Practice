<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

    <title>Gift Finder</title>
   <link rel="stylesheet" href="http://code.jquery.com/mobile/1.3.2/jquery.mobile-1.3.2.min.css" />
<script src="http://code.jquery.com/jquery-1.9.1.min.js"></script>
<script src="http://code.jquery.com/mobile/1.3.2/jquery.mobile-1.3.2.min.js"></script>
    
</head>

<body>

    <div data-role ="page" id ="login" >
        <div data-role="header" data-position="fixed" data-theme ="b">
            <h1> Gift Finder UserLogin </h1>
            <a data-rel="back"data-icon="back">Back</a> 
        </div>
        <form id="LoginForm" runat="server">
        <div data-role ="content" data-theme="b">
             <div data-role="fieldcontain">
            <label for= "loginusername" > User Name : </label>
            <asp:TextBox ID="txtLoginusername" runat="server"></asp:TextBox>
                 </div>
            <div data-role ="fieldcontain">
                <label for="loginpassword"> Password : </label>
                <asp:TextBox ID="txtpassword" runat="server" textmode= "password"></asp:TextBox>
            </div>
            <asp:button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <asp:Label ID="lblSuccess2" runat="server" style="font-size: large; font-family: 'Engravers MT'"></asp:Label>

            </div>
        </form>
        <div data-role ="footer" data-position="fixed" data-theme ="b">
            <h4> @ ASE Hackathon </h4>
        </div>
    </div>

 
</body>
</html>
