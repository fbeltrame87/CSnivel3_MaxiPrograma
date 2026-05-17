<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Gestor.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Gestor_eCommerce_WebApp.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>¡Comienza la venta!</h1>
    <% if (user != "" && user != null) { %>
        <!-- Solo entra acá si venís del Login con datos -->
        <h2>¡Ingresaste!</h2>
        <p>Bienvenido, <%= user %></p>
            <div class= "row">
                <div class="col">
                    <asp:GridView runat="server" ID="dgvCommerce" DataKeyNames="Id" OnSelectedIndexChanged="dgvCommerce_SelectedIndexChanged" CssClass="table table-secondary">
                        <Columns>
                            <asp:BoundField HeaderText="Id" DataField="Id" />
                            <asp:BoundField HeaderText="Código" DataField="Codigo" />
                            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                            <asp:BoundField HeaderText="Descripción" DataField="Descripcion" />
                            <asp:BoundField HeaderText="Categoria" DataField="Categoria" />
                            <asp:BoundField HeaderText="Marca" DataField="Marca" />
                            <asp:BoundField HeaderText="Imagen" DataField="ImagenUrl" />
                            <asp:BoundField HeaderText="Precio" DataField="Precio" />
                        </Columns>
                    </asp:GridView>
                    <a href="ArticuloForm.aspx">Agregar</a>
                </div>
            </div>
    <% } else { %>
        <!-- Esto es lo que debería verse al arrancar el proyecto -->
        <h2>Debes loguearte...</h2>
        <a href="Login.aspx" class="btn btn-primary">Ir al Login</a>
    <% } %>
</asp:Content>
