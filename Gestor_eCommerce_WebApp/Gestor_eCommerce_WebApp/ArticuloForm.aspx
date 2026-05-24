<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Gestor.Master" AutoEventWireup="true" CodeBehind="ArticuloForm.aspx.cs" Inherits="Gestor_eCommerce_WebApp.ArticuloForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <% if (user != "" && user != null)
        { %>
    <!-- Solo entra acá si venís del Login con datos -->
    <h2>¡Ingresaste!</h2>
    <p>Bienvenido, <%= user %></p>
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="lblId" class="form-label">Id</label>
                <asp:TextBox ID="txtBoxId" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label for="lblCodigo" class="form-label">Código</label>
                <asp:TextBox ID="txtBoxCodigo" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label for="lblNombre" class="form-label">Nombre</label>
                <asp:TextBox ID="txtBoxNombre" CssClass="form-control" runat="server" />
            </div>
            <div class="mb-3">
                <label for="lblMarca" class="form-label">Marca</label>
                <asp:DropDownList ID="ddlMarca" DataTextField="Descripcion" DataValueField="Id" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="lblCategoria" class="form-label">Categoria</label>
                <asp:DropDownList ID="ddlCategoria" DataTextField="Descripcion" DataValueField="Id" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="lblPrecio" class="form-label">Precio</label>
                <asp:TextBox ID="txtBoxPrecio" CssClass="form-control" runat="server" />
            </div>
            <asp:Button ID="btnAceptar" OnClick="btnAceptar_Click" CssClass="btn btn-primary" runat="server" Text="Aceptar" />
            <asp:Button ID="btnModificar" OnClick="btnModificar_Click" CssClass="btn btn-secondary" runat="server" Text="Modificar" />
            <asp:Button ID="btnEliminar" OnClick="btnEliminar_Click" CssClass="btn btn-danger" runat="server" Text="Eliminar" />
            <a href="Default.aspx">Cancelar</a>
        </div>
        <div class="col-6">
            <div class="mb-3">
                <label for="lblDescripcion" class="form-label">Descripción</label>
                <asp:TextBox ID="txtBoxDescripcion" TextMode="MultiLine" CssClass="form-control" runat="server" />
            </div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>   
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <label for="lblImagenUrl" class="form-label">Imagen</label>
                        <asp:TextBox ID="txtBoxImagen" CssClass="form-control" runat="server" AutoPostBack="true" OnTextChanged="txtBoxImagen_TextChanged" />
                    </div>
                    <asp:Image ImageUrl="https://www.neuco.com/assets/img/product-placeholder.webp" runat="server" ID="imagenArticulo" Width="60%" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <% }
    else
    { %>
    <!-- Esto es lo que debería verse al arrancar el proyecto -->
    <h2>Debes loguearte...</h2>
    <a href="Login.aspx" class="btn btn-primary">Ir al Login</a>
    <% } %>
</asp:Content>
