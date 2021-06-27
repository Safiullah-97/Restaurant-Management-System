<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sale.aspx.cs" Inherits="WebApplication8.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="16px" Width="134px">
        </asp:GridView>
        <br />
        <asp:Button runat="server" ID="btn1" OnClick="btn1_click" Text="Submit" Width="105px" />

        <div id="main" style="width: 500px">
            
            
            <table>
                <tr>
                    <td>
                        <asp:PlaceHolder ID="placeHolder1" runat="server" />
                    <td>
                </tr>
            </table>
        </div>
        <div>
        </div>
    </form>
</asp:Content>
