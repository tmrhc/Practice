<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" %>

!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

    <title>Gift Finder</title>
   <link rel="stylesheet" href="http://code.jquery.com/mobile/1.3.2/jquery.mobile-1.3.2.min.css" />
<script src="http://code.jquery.com/jquery-1.9.1.min.js"></script>
<script src="http://code.jquery.com/mobile/1.3.2/jquery.mobile-1.3.2.min.js"></script>
    
</head>

<body>

    <div data-role ="page" id ="signup" >
        <div data-role="header" data-position="fixed"  data-theme ="b">
             <a data-rel="back"data-icon="back">Back</a> 
             <h1> Gift Finder User SignUp </h1>
        </div>
        <form id="SignupForm" runat="server">
        <div data-role ="content" data-theme="b">
             <div data-role="fieldcontain">
            <label for= "Signupfirstname" > First Name : </label>
            <asp:TextBox ID="txtSignupfirstname" runat="server"></asp:TextBox>
                 </div>
            <div data-role ="fieldcontain">
                <label for="Signuplastname"> Last Name : </label>
                <asp:TextBox ID="txtSignuplastname" runat="server"></asp:TextBox>
            </div>
            <div data-role ="fieldcontain">
                <label for="Signupusernamename"> User Name : </label>
                <asp:TextBox ID="txtSignupusername" runat="server" ></asp:TextBox>
            </div>
            <div data-role ="fieldcontain">
                <label for="Signupemail"> Email Address : </label>
                <asp:TextBox ID="txtSignupemail" runat="server"></asp:TextBox>
            </div>
            <div data-role ="fieldcontain">
                <label for="Signuppassword"> Password : </label>
                <asp:TextBox ID="txtSignuppassword" runat="server" TextMode ="Password"></asp:TextBox>

            </div>
                  <asp:button ID="btnSignup" runat="server" Text="Singup" OnClick="btnSignup_Click" />             
                  <asp:Label ID="lblSuccess" runat="server" style="font-size: large; font-family: 'Engravers MT'"></asp:Label>
                </div>
        
       </form>
        <div data-role ="footer" data-position="fixed" data-theme ="b">
            <h4> @ ASE Hackathon </h4>
        </div>
    </div>
</body>
</html>
