<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ImageUploader.aspx.cs" Inherits="WebApplication8.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form  runat="server">
     <asp:FileUpload ID="FileUpload2" runat="server" />

    <asp:Button ID="btn1" runat="server" Text="Submit" OnClick="btn1_Click" Style="background-color:dodgerblue; border-radius:7%" Width="181px" Height="37px" />


        </form>
</asp:Content>
