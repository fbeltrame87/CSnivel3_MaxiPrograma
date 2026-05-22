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
                <a href="SignUp.aspx">Registrate</a>
            </div>
            <asp:Button Text="Ingresar" CssClass="btn btn-primary" ID="BtnIngresar" OnClick="BtnIngresar_Click" runat="server" />
        </div>
    </div>
</asp:Content>
