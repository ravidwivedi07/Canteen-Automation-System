<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contact_Us.aspx.cs" Inherits="MobileSystem.Mobile.Contact_Us" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact Us</title>
    <meta charset="UTF-8" />
   <meta name="viewport" content="width=device-width, initial-scale=1" />
    <style>
 * {
    box-sizing: border-box;
}

        body {
    font-family: Arial;
    margin: 0;
     
        }

        .header {
            padding: 20px;
            text-align: center;
            background: #33CCFF;
            color: white;
            height:110px;
            
        }

        .header h1 {
    font-size: 30px;
    font-family:Arial;
}

        .info h1{
        font-size:22px;
        }
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="header">
        <marquee><h1>Ramnarain Ruia Autonomous College of Arts and Science.</h1></marquee>
    </div><br />
        <div class="info">
           <h1>&nbsp;&nbsp; <b>Postal address</b></h1>
                &nbsp;&nbsp;&nbsp; L. Nappo Road,<br />
&nbsp;&nbsp;&nbsp; Dadar East, Matunga,<br />
&nbsp;&nbsp;&nbsp; Mumbai, Maharashtra - 400 019.
        </div>
        <div class="info">
           <h1>&nbsp;&nbsp; <b>Telephone Number</b></h1>          
                &nbsp;&nbsp;&nbsp;
                91 22 24303733
                <br />&nbsp;&nbsp;&nbsp; 91 22 2430 3081
                  <br />&nbsp;&nbsp;&nbsp; 91 22 2436 1139
        </div>
         <div class="info">
           <h1>&nbsp;&nbsp; <b>Email</b></h1>          
                &nbsp;&nbsp;&nbsp;
                RuiaCanteen@gmail.com
                <br />&nbsp;&nbsp;&nbsp; principal@RuiaAutonomous.edu                
        </div>
        
    </form>
</body>
</html>
