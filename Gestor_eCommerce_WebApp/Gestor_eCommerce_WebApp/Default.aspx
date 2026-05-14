<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Gestor.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Gestor_eCommerce_WebApp.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>¡Comienza la venta!</h1>
    <% if (user != "" && user != null) { %>
        <!-- Solo entra acá si venís del Login con datos -->
        <h2>¡Ingresaste!</h2>
        <asp:Label ID="lblUser" runat="server" Text=""></asp:Label>
        <p>Bienvenido, <%= user %></p>

        <asp:GridView runat="server" ID="dgvCommerce"></asp:GridView>
    <% } else { %>
        <!-- Esto es lo que debería verse al arrancar el proyecto -->
        <h2>Debes loguearte...</h2>
        <a href="Login.aspx" class="btn btn-primary">Ir al Login</a>
    <% } %>
</asp:Content>
