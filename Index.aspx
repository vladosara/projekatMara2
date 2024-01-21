<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PROJEKAT!</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="Index.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css"/>
</head>
<body>
 
    <form id="form1" runat="server">
        <div id="drzava">
            <h1>PRITISNI DUGME ZA 1 OD 1001 RAZLOGA</h1>
        </div>
        <video autoplay="autoplay" loop="loop" muted="muted" playsinline="playsinline" class="vidoo">
            <source src="Images/Untitled video - Made with Clipchamp (1).mp4" type="video/mp4" />
        </video>
        <div id="dvojika">


<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">
     <i class="fas fa-play"></i>
</asp:LinkButton>
            
        </div>
        <div id="odgovor" runat="server"> </div>
    </form>
</body>
</html>
