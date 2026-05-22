<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Gestor.Master" AutoEventWireup="true" CodeBehind="ArticulosLista.aspx.cs" Inherits="Gestor_eCommerce_WebApp.ArticulosLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class= "row">
                <div class="col">
                    <asp:GridView runat="server" ID="dgvCommerce" DataKeyNames="Id" 
                        OnSelectedIndexChanged="dgvCommerce_SelectedIndexChanged" AutogenerateColumns="false" 
                        CssClass="table table-secondary" OnPageIndexChanging="dgvCommerce_PageIndexChanging"
                        AllowPaging="true" PageSize="5">
                        <Columns>
                            <%--<asp:BoundField HeaderText="Id" DataField="Id" />--%>
                            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                            <asp:BoundField HeaderText="Categoria" DataField="categoriaArticulo.Descripcion" />
                            <asp:BoundField HeaderText="Marca" DataField="marcaArticulo.Descripcion" />
                            <asp:BoundField HeaderText="Precio" DataField="Precio" />
                            <asp:CommandField ShowSelectButton="true" SelectText="👉" HeaderText="Acción" />
                        </Columns>
                    </asp:GridView> 
                    <a href="ArticuloForm.aspx">Agregar</a>
                </div>
            </div>
</asp:Content>
