<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LoginDetails.aspx.cs" Inherits="WebApplication8.LoginDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server"><br />
        
        <div > <br /> <br />
        <h1 style="color:darkblue"><b> Resturant Management System</b></h1>
        <br /><br />
        <label> Email </label> 
     <asp:TextBox Style="margin-left:6.5ch"  runat="server" ID="id" Height="37px" Width="123px"></asp:TextBox><br /> <br /><br />
        
        <label> Password</label>
             <asp:textbox  Style="margin-left:3.5ch" id="pass" runat="server" TextMode="Password" Height="37px" Width="126px"></asp:textbox>
            <br /> <br />
            
            <br /> <br />
            <asp:Button Style="border-block-color:red;border-width:3px;border-radius: 12px;background-color:palevioletred;margin-left:3ch" runat="server" ID="button" text="Login" Width="222px" Height="52px" OnClick="button_Click"/>
    <br /> <br /><br /> <br />  </div><br /> <br /><br /> <br /><br /> <br />
            </form>

</asp:Content>
