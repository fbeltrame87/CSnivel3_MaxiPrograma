<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Gestor.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Gestor_eCommerce_WebApp.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row justify-content-center">
        <div class="col-12 col-md-4 card shadow p-4 mt-5">
            <h3 class="text-center mb-4">Iniciar Sesión</h3>
            <div class="mb-3">
                <label for="txtBoxUser" class="form-label">Usuario</label>
                <asp:TextBox ID="txtBoxUser" Text="Ingresar Usuario" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtBoxPassword" class="form-label">Contraseña</label>
                <asp:TextBox ID="txtBoxPassword" Type="password" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:Label ID="lblSignUp" runat="server" Text="">¿No tienes usuario?</asp:Label>
                <a class="icon-link" href="SignUp.aspx">
                    <svg xmlns="http://www.w3.org/2000/svg" class="bi" viewBox="0 0 16 16" aria-hidden="true">
                        <path d="M8.186 1.113a.5.5 0 0 0-.372 0L1.846 3.5l2.404.961L10.404 2l-2.218-.887zm3.564 1.426L5.596 5 8 5.961 14.154 3.5l-2.404-.961zm3.25 1.7-6.5 2.6v7.922l6.5-2.6V4.24zM7.5 14.762V6.838L1 4.239v7.923l6.5 2.6zM7.443.184a1.5 1.5 0 0 1 1.114 0l7.129 2.852A.5.5 0 0 1 16 3.5v8.662a1 1 0 0 1-.629.928l-7.185 2.874a.5.5 0 0 1-.372 0L.63 13.09a1 1 0 0 1-.63-.928V3.5a.5.5 0 0 1 .314-.464L7.443.184z" />
                    </svg>
                    Registrate
                </a>
            </div>
            <asp:Button Text="Ingresar" CssClass="btn btn-primary" ID="BtnIngresar" OnClick="BtnIngresar_Click" runat="server" />
        </div>
    </div>
</asp:Content>
