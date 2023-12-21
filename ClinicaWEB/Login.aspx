<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ClinicaWEB.Login" %>
<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Acceder</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <!-- Custom styles for this template -->
    <style>
        body {
            height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .form-signin {
            width: 100%;
            max-width: 330px;
            padding: 15px;
            margin: auto;
        }
    </style>
</head>
<body class="text-center">
    
    <form class="form-signin" id="form1" runat="server">
        <img class="mb-4" src="Images/login.png" alt="" width="72" height="57">
        <h1 class="h3 mb-3 fw-normal">Inicio de Sesión</h1>

        <div class="form-floating mb-3">
            <asp:Textbox ID="txtUsuario" type="email" class="form-control"  placeholder="Correo Electrónico" runat="server"/>
            <label for="txtUsuario">Correo Electrónico</label>
        </div>
        <div class="form-floating ">
            <asp:Textbox ID="txtPass" type="password" class="form-control" placeholder="Contraseña" runat="server"/>
            <label for="floatingPassword">Contraseña</label>
        </div>

        <asp:Button ID="btnRegistrar" runat="server" class="w-100 btn btn-lg btn-primary mt-5"  type="submit" OnClick="btnIniciar_Click" Text="Iniciar Sesion"/>
         <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Red" CssClass="labelErrores"></asp:Label>
        <p class="mt-5 mb-3 text-muted">&copy; 2023</p>
    </form>

    <!-- Bootstrap JS (Optional, depending on your needs) -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>
