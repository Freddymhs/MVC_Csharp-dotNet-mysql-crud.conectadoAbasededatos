<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="clase_6._5_formularioCalculoIMC._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



<form id="form1" >

<div>

nombre <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />

peso <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox><br />

altura <asp:TextBox ID="txtAltura" runat="server"></asp:TextBox><br />

<asp:Button ID="Button1" runat="server" Text="Enviar" onClick="metodoIMC"/>
    <br /><br /><br /><br /><br /><br />
<asp:Label ID="txtResultado" runat="server">

　

</asp:Label>

</div>

</form>


 
</asp:Content>
