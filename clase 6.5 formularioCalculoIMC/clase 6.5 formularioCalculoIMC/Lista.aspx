<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Lista.aspx.cs" Inherits="clase_6._5_formularioCalculoIMC.Lista" %>




<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <asp:Button ID="Button1" runat="server" OnClick="btnListar" Text="Button" />

    <asp:GridView ID="gridviewlista" runat="server"></asp:GridView>



</asp:Content>
