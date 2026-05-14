<%@ Page Title="Home" Language="C#" MasterPageFile="~/Mi_Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Portfolio_WebApp.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Arrancamos...!</h1>
        <div>
            <div class="container text-center">
                <div class="row">
                    <div class="col-4"></div>
                    <div class="col-4">
                        <label>Escribe tu nombre aquí:</label>
                        <asp:TextBox ID="txtBoxNombre" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-4"></div>
                </div>
                <asp:Button ID="BtnRegistro" runat="server" OnClick="BtnRegistro_Click" Text="Registro" CssClass="btn btn-primary" />
                <asp:Label Text="" ID="lblSaludo" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
