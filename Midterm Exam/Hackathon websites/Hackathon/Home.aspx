<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Gift Finder</title>
   <link rel="stylesheet" href="http://code.jquery.com/mobile/1.3.2/jquery.mobile-1.3.2.min.css" />
<script src="http://code.jquery.com/jquery-1.9.1.min.js"></script>
<script src="http://code.jquery.com/mobile/1.3.2/jquery.mobile-1.3.2.min.js"></script>
    
</head>

<body>
   
    <div data-role ="page" id ="home" data-add-back-btn="true" >
        <div data-role="header" data-position="fixed" data-theme ="b">
            <img src="gift.jpg" alt="Logo" style="float:left;display:inline"/>
                        <h1> Gift Finder APP</h1>
           </div>
        <div data-role ="content" data-theme="b">
        <a href ="login.aspx", data-role="button", data-theme ="e">Login</a>
        <a href ="Signup.aspx", data-role="button", data-theme ="e">Signup</a>

        </div>

        <div data-role ="footer" data-position="fixed" data-theme ="b">
            <h4> @ ASE Hackathon </h4>
        </div>
    </div>

 
</body>
</html>
