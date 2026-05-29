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
    <a class="icon-link" href="Login.aspx">
        <svg xmlns="http://www.w3.org/2000/svg" class="bi" viewBox="0 0 16 16" aria-hidden="true">
            <path d="M8.186 1.113a.5.5 0 0 0-.372 0L1.846 3.5l2.404.961L10.404 2l-2.218-.887zm3.564 1.426L5.596 5 8 5.961 14.154 3.5l-2.404-.961zm3.25 1.7-6.5 2.6v7.922l6.5-2.6V4.24zM7.5 14.762V6.838L1 4.239v7.923l6.5 2.6zM7.443.184a1.5 1.5 0 0 1 1.114 0l7.129 2.852A.5.5 0 0 1 16 3.5v8.662a1 1 0 0 1-.629.928l-7.185 2.874a.5.5 0 0 1-.372 0L.63 13.09a1 1 0 0 1-.63-.928V3.5a.5.5 0 0 1 .314-.464L7.443.184z" />
        </svg>
        Ir al Login
    </a>
    <% } %>
</asp:Content>
