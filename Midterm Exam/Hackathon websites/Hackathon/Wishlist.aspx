<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Wishlist.aspx.cs" Inherits="Wishlist" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
<meta charset="utf-8">
<title>Create Event</title>
<link href="styles/main.css" rel="stylesheet" type="text/css">
<!--The following script tag downloads a font from the Adobe Edge Web Fonts server for use within the web page. We recommend that you do not modify it.--><script>var __adobewebfontsappname__ = "dreamweaver"</script><script src="http://use.edgefonts.net/source-sans-pro:n2,n6:default.js" type="text/javascript"></script>
</head>

<body>

    <form id="form1" runat="server">

   <div data-role="header" data-position="fixed" data-theme ="b">
            <a href ="User Home.aspx" data-role="button" data-icon ="home" data-iconpos="right"> Home </a>
            <h1> Create Event</h1>
           </div>

    <div data-role="content" data-theme="b">
        <div data-role="field contain">
<label for= "eventname" > Wish an Item : </label>
            <asp:TextBox ID="txtwishlist" runat="server"></asp:TextBox>

            <asp:button ID="btnadditems" runat="server" Text="Add Item" OnClick="btnadditem_Click" />

            <asp:Label ID="lblSuccess3" runat="server" style="font-size: large; font-family: 'Engravers MT'"></asp:Label>
    
  </div>
        </div>

    </form>
</body>
</html>
