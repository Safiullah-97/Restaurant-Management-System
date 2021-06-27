<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminSale.aspx.cs" Inherits="WebApplication8.AdminSale" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
         <h1 style="color:indianred"><b>Add Product </b></h1><br /><br />
<label> Product Name</label><br />
    <asp:TextBox ID="pname" runat="server"></asp:TextBox> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" />  <br /> <br />

    
<label> Product Price</label><br />
    <asp:TextBox ID="pprice" runat="server"></asp:TextBox>   <br /> <br />

                  
            
    <label> Category</label>
    <asp:DropDownList ID="cat" runat="server" DataSourceID="SqlDataSource1" DataTextField="cat_name" DataValueField="cat_id"></asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RestaurantMSConnectionString %>" SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>
    <br /><br /> <br /> <br />
        <asp:Button runat="server" ID="click" Text="Add Product" BackColor="#3399FF" Height="35px" OnClick="click_Click" Width="169px" />
  <br /> <br /><br /> <br />

        <h1 style="color:indianred"><b >Sale </b></h1>
        
        <br /> <br /> 
        <div style=" page-break-before: always;"></div>
          <div style="display:flex; padding-left:02ch;">
          <asp:Calendar Style=" background-color:lightblue" ID="CalenderFrom"  runat="server"></asp:Calendar> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Calendar Style=" background-color:lightblue" ID="CalenderTo"  runat="server"></asp:Calendar>
              <br /><br /><br />
         </div>
            <br /> <br />
            <asp:Button Style="margin-left:10ch" runat="server" id="Date" BackColor="#0066CC" Height="43px" Text="Search by date" Width="224px" OnClick="Date_Click"/>
        <asp:GridView ID="GridView1" runat="server">

        </asp:GridView>
        
    </form>

</asp:Content>
