<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Gestor.Master" AutoEventWireup="true" CodeBehind="ArticuloForm.aspx.cs" Inherits="Gestor_eCommerce_WebApp.ArticuloForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="lblId" class="form-label">Id</label>
                <asp:textbox ID="txtBoxId" cssClass="form-control" runat="server"/>  
            </div>
            <div class="mb-3">
                <label for="lblCodigo" class="form-label">Código</label>
                <asp:textbox ID="txtBoxCodigo" cssClass="form-control" runat="server"/>
            </div>
            <div class="mb-3">
                <label for="lblNombre" class="form-label">Nombre</label>
                <asp:textbox ID="txtBoxNombre" cssClass="form-control" runat="server"/>
            </div>
            <div class="mb-3">
                <label for="lblDescripcion" class="form-label">Descripción</label>
                <asp:textbox ID="txtBoxDescripcion" TextMode="MultiLine" cssClass="form-control" runat="server" />  
            </div>
            <div class="mb-3">
                <label for="lblMarca" class="form-label">Marca</label> 
                <asp:DropDownList ID="ddlMarca" cssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="lblCategoria" class="form-label">Categoria</label>
                <asp:DropDownList ID="ddlCategoria" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="lblImagenUrl" class="form-label">Imagen</label>
                <asp:textbox ID="txtBoxImagen" cssClass="form-control" runat="server"/>  
            </div>
            <div class="mb-3">
                <label for="lblPrecio" class="form-label">Precio</label>
                <asp:textbox ID="txtBoxPrecio" cssClass="form-control" runat="server"/>  
            </div>
            <asp:Button ID="btnAceptar" OnClick="btnAceptar_Click" CssClass="btn btn-primary" runat="server" Text="Aceptar" />
            <a href="Default.aspx">Cancelar</a>
        </div>
    </div>
</asp:Content>
