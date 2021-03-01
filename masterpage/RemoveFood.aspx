﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RemoveFood.aspx.cs" Inherits="RemoveFood" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Remove Food Items
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <style>
.dropbtn {
    background-color: rgb(10, 110, 178);
    color: white;
    padding: 12px;
    font-size: 13px;
    font-weight: bold;
    border: none;
    border-radius: 5px 5px 5px 5px;
    height: 40px;
    width: 100%;
   
}

.dropdown {
    position: relative;
    display: inline-block;
    float:left;
    
}

.dropdown-content {
    display: none;
    position: absolute;
    background-color: #f1f1f1;
    min-width: 100px;
    box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
    z-index: 1;
}

.dropdown-content a {
    color: black;
    padding: 12px 16px;
    text-decoration: none;
    display: block;
}

.dropdown-content a:hover {background-color: #ddd}

.dropdown:hover .dropdown-content {
    display: block;
}

.dropdown:hover .dropbtn {
    background-color: rgb(14, 79, 114);
}


.removefood {
    text-align: center;
    font-size: 17px;
            }



</style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" Runat="Server">
    
    <div class="dropdown">
  <button class="dropbtn">Add Details</button>
  <div class="dropdown-content">
    <a href="InventoryDetails.aspx">Inventory Details</a>
    <a href="AddFood.aspx">Add Food</a>
    <a href="AddOffers.aspx">Add Offers</a>
  </div>
</div>
    
    <div class="Menu">
        <ul>
                      
                     <li><a href="RemoveFood.aspx">Remove Food</a></li>  
                    <li><a href="UpdateDetails.aspx">Update Inventory Details</a></li>
                    <li><a href="Report.aspx">Report</a></li>
                    <li><a href="Logout.aspx">Logout</a></li>
        </ul>
    </div>
    
     <div class="removefood">
    <h2>Remove Food Items</h2><br />
    </div> 
    <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblcat" runat="server" Text="Category:" Font-Size="Medium"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>---Select---</asp:ListItem>
        <asp:ListItem>Starter</asp:ListItem>
        <asp:ListItem Value="Main Course"></asp:ListItem>
        <asp:ListItem Value="Desserts"></asp:ListItem>
        <asp:ListItem Value="Drinks"></asp:ListItem>
        <asp:ListItem Value="Salads"></asp:ListItem>
</asp:DropDownList>
    <br />
    <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblname" runat="server" Text="Food Name:" Font-Size="Medium"></asp:Label>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
    <br />
    <br />
    <br />
    <br />
    <center><asp:Button ID="btndel" runat="server" Text="Delete" Height="35px" Width="70px" OnClick="btndel_Click"></asp:Button></center>
    <br />
</asp:Content>
