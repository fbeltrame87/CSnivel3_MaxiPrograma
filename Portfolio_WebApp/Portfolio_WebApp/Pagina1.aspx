<%@ Page Title="" Language="C#" MasterPageFile="~/Mi_Master.Master" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="Portfolio_WebApp.Pagina1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Perfil - Facundo Beltrame</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header class="py-5 bg-dark text-white text-center">
        <div class="container">
            <h1 class="display-4 fw-bold">Facundo Beltrame</h1>
            <p class="lead">C# .NET Developer Trainee</p>
        </div>
    </header>

    <!-- Sección Sobre mí -->
    <section class="py-5">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-md-2 text-center mb-3 mb-md-0">
                    <!-- Icono más grande y con color -->
                    <i class="bi bi-person-badge text-primary" style="font-size: 5rem;"></i>
                </div>
                <div class="col-md-10">
                    <h2 class="border-bottom pb-2">Sobre mí:</h2>
                    <p class="lead">Developer trainee en C# .NET, estudiante perpetuo de nuevas habilidades y herramientas que sumen a mi perfil y a mis proyectos.</p>
                    <p>Mis intereses se centran en proyectos desafiantes que me lleven a implementar lo aprendido.</p> 
                </div>
            </div>
        </div>
    </section>

    <!-- Sección Herramientas -->
    <section class="py-5 bg-light">
        <div class="container">
            <h2 class="text-center mb-5">Conocimientos y herramientas</h2>
            <!-- Fila con alineación vertical para que los logos se vean ordenados -->
            <div class="row row-cols-2 row-cols-md-5 g-4 justify-content-center align-items-center text-center">
                <div class="col">
                    <img src="https://www.svgrepo.com/show/354520/visual-studio.svg" class="img-fluid" style="max-height: 80px;" alt="Visual Studio">
                </div>
                <div class="col">
                    <img src="https://upload.wikimedia.org/wikipedia/commons/4/4f/Csharp_Logo.png" class="img-fluid" style="max-height: 80px;" alt="C#">
                </div>
                <div class="col">
                    <img src="https://365cloudstore.com/wp-content/uploads/2023/02/sql-server-500x500-01-1200x900.png" class="img-fluid" style="max-height: 100px;" alt="SQL">
                </div>
                <div class="col">
                    <img src="https://git-scm.com/images/logos/downloads/Git-Icon-1788C.png" class="img-fluid" style="max-height: 80px;" alt="Git">
                </div>
                <div class="col">
                    <img src="https://cdn-icons-png.flaticon.com/512/5968/5968282.png" class="img-fluid" style="max-height: 80px;" alt="Bootstrap">
                </div>
            </div>
        </div>
    </section>

    <!-- Sección Certificaciones -->
    <section class="py-5 bg-dark">
        <div class="container">
            <h2 class="text-center mb-4 text-white">Certificaciones</h2>
            <div class="row justify-content-center g-4">
                <!-- Tarjeta C# Nivel 1 -->
                <div class="col-12 col-md-5 col-lg-4 d-flex justify-content-center">
                    <div class="card shadow-lg border-0" style="width: 18rem;">
                        <img src="Imagenes/CertificadoNivel1.png" class="card-img-top" alt="Certificado C# Nivel 1">
                        <div class="card-body d-flex flex-column text-center">
                            <h5 class="card-title fw-bold">C# nivel 1</h5>
                            <p class="card-text flex-grow-1">Fundamentos, Lógica y aplicaciones de consola.</p>
                            <a href="#" class="btn btn-primary mt-auto">Ver Certificado</a>
                        </div>
                    </div>
                </div>

                <!-- Tarjeta C# Nivel 2 -->
                <div class="col-12 col-md-5 col-lg-4 d-flex justify-content-center">
                    <div class="card shadow-lg border-0" style="width: 18rem;">
                        <img src="Imagenes/CertificadoNivel2.png" class="card-img-top" alt="Certificado C# Nivel 2">
                        <div class="card-body d-flex flex-column text-center">
                            <h5 class="card-title fw-bold">C# nivel 2</h5>
                            <p class="card-text flex-grow-1">POO, Git/Github, DB y WinForms.</p>
                            <a href="#" class="btn btn-primary mt-auto">Ver Certificado</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
