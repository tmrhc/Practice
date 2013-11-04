<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User Home.aspx.cs" Inherits="User_Home" %>

!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

    <title>Gift Finder</title>
   <link rel="stylesheet" href="http://code.jquery.com/mobile/1.3.2/jquery.mobile-1.3.2.min.css" />
<script src="http://code.jquery.com/jquery-1.9.1.min.js"></script>
<script src="http://code.jquery.com/mobile/1.3.2/jquery.mobile-1.3.2.min.js"></script>
    
</head>

<body>

   <div data-role ="page" id ="userhome">
        <div data-role="header" data-position="fixed" data-theme ="b">
            <img src="gift.jpg" alt="Logo" style="float:left;display:inline"/>
            <h1> Gift Finder User Home</h1>
           </div>
        <div data-role ="content" data-theme="b">
        <a href ="createevents.aspx", data-role="button", data-theme ="e">Create a Event</a>
        <a href ="invitefriends.cshtml", data-role="button", data-theme ="e">Invite Friends to Event</a>
        <a href ="Wishlist.aspx", data-role="button", data-theme ="e">Wish List</a>
        </div>

        <div data-role ="footer" data-position="fixed" data-theme ="b">
            <h4> @ ASE Hackathon </h4>
        </div>
    </div>

 
</body>
</html>
