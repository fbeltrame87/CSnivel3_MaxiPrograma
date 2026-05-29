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
            <div class="d-flex justify-content-between align-items-start w-100 mb-3">
                <div class="d-flex gap-2">   
                    <asp:Button ID="btnAgregar" OnClick="btnAgregar_Click" CssClass="btn btn-primary" runat="server" Text="Agregar" />
                <asp:Button ID="btnModificar" OnClick="btnModificar_Click" CssClass="btn btn-secondary" runat="server" Text="Modificar" />
                </div>
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <div>   
                    <asp:UpdatePanel runat="server" RenderMode="Inline">
                    <ContentTemplate>
                        <div class="d-flex flex-column align-items-end gap-2">   
                            <asp:Button ID="btnEliminar" OnClick="btnEliminar_Click" CssClass="btn btn-danger" runat="server" Text="Eliminar" />
                            <%if (ConfirmaEliminacion)
                                {%>
                            <div class="card p-2 bg-light border-danger mt-1 d-flex flex-row align-items-center gap-2">   
                                <asp:CheckBox Text="Confirmar Eliminación" ID="chkBoxConfirmaEliminar" runat="server" />
                                <asp:Button ID="btnConfirmar" CssClass="btn btn-outline-danger" OnClick="btnConfirmar_Click" runat="server" Text="Confirmar" />
                            </div>
                            <% } %>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                </div>
            </div>
            <a class="icon-link" href="Default.aspx">
                <svg xmlns="http://www.w3.org/2000/svg" class="bi" viewBox="0 0 16 16" aria-hidden="true">
                    <path d="M8.186 1.113a.5.5 0 0 0-.372 0L1.846 3.5l2.404.961L10.404 2l-2.218-.887zm3.564 1.426L5.596 5 8 5.961 14.154 3.5l-2.404-.961zm3.25 1.7-6.5 2.6v7.922l6.5-2.6V4.24zM7.5 14.762V6.838L1 4.239v7.923l6.5 2.6zM7.443.184a1.5 1.5 0 0 1 1.114 0l7.129 2.852A.5.5 0 0 1 16 3.5v8.662a1 1 0 0 1-.629.928l-7.185 2.874a.5.5 0 0 1-.372 0L.63 13.09a1 1 0 0 1-.63-.928V3.5a.5.5 0 0 1 .314-.464L7.443.184z" />
                </svg>
                Cancelar
            </a>
        </div>
        <div class="col-6">
            <div class="mb-3">
                <label for="lblDescripcion" class="form-label">Descripción</label>
                <asp:TextBox ID="txtBoxDescripcion" TextMode="MultiLine" CssClass="form-control" runat="server" />
            </div>
               
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
    <a class="icon-link" href="Login.aspx">
                <svg xmlns="http://www.w3.org/2000/svg" class="bi" viewBox="0 0 16 16" aria-hidden="true">
                    <path d="M8.186 1.113a.5.5 0 0 0-.372 0L1.846 3.5l2.404.961L10.404 2l-2.218-.887zm3.564 1.426L5.596 5 8 5.961 14.154 3.5l-2.404-.961zm3.25 1.7-6.5 2.6v7.922l6.5-2.6V4.24zM7.5 14.762V6.838L1 4.239v7.923l6.5 2.6zM7.443.184a1.5 1.5 0 0 1 1.114 0l7.129 2.852A.5.5 0 0 1 16 3.5v8.662a1 1 0 0 1-.629.928l-7.185 2.874a.5.5 0 0 1-.372 0L.63 13.09a1 1 0 0 1-.63-.928V3.5a.5.5 0 0 1 .314-.464L7.443.184z" />
                </svg>
                Ir al Login
            </a>
    <% } %>
</asp:Content>
