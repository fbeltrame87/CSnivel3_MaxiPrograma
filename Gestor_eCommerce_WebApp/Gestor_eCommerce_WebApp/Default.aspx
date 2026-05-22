<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Gestor.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Gestor_eCommerce_WebApp.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>¡Comienza la venta!</h1>
    <% if (user != "" && user != null) { %>
        <!-- Solo entra acá si venís del Login con datos -->
        <h2>¡Ingresaste!</h2>
        <p>Bienvenido, <%= user %></p>
            
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <%--<%
            foreach (CapaDominio.Articulo art in ListaArticulo)
            {%>
            <div class="col">
                <div class="card">
                    <img src="<%: art.ImagenUrl %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%: art.Nombre %></h5>
                        <p class="card-text"><%: art.Descripcion %></p>
                        <a href="DetalleArticulo.aspx?Id=<%: art.Id %>">Ver Detalle</a>
                    </div>
                </div>
            </div>
        <% } %>--%>

        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>
                <div class="col">
                <div class="card">
                    <img src="<%#Eval("ImagenUrl")%>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Nombre")%></h5>
                        <p class="card-text"><%#Eval("Descripcion")%></p>
                        <a href="DetalleArticulo.aspx?Id=<%#Eval("Id")%>">Ver Detalle</a>
                        <asp:Button Text="Ejemplo" CssClass="btn btn-primary" runat="server" ID="btnEjemplo" CommandArgument='<%#Eval("Id") %>' CommandName="ArticuloId" OnClick="btnEjemplo_Click"/>
                    </div>
                </div>
            </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <% } else { %>
        <!-- Esto es lo que debería verse al arrancar el proyecto -->
        <h2>Debes loguearte...</h2>
        <a href="Login.aspx" class="btn btn-primary">Ir al Login</a>
    <% } %>
</asp:Content>
