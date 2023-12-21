<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Graficos2.aspx.cs" Inherits="sitioWebClinica.Reportes.Graficos2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
     <style>
        /* Estilos personalizados aquí */
        body {
            font-family: 'Poppins', sans-serif;
            margin: 0;
            padding: 0;
            background: none !important;
        }

        h2 {
            color: #333;
        }

        canvas {
            margin-top: 0;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Cantidad de Atenciones por Medico</h2>
    <canvas id="myChart" width="400" height="200"></canvas>

    <script>
   function CargarGrafico(estadisticas) {
      var ctx = document.getElementById('myChart').getContext('2d');
      var myChart = new Chart(ctx, {
         type: 'bar',
         data: {
            labels: estadisticas.labels,
            datasets: [{
               label: 'Número de Atenciones por Medico',
               data: estadisticas.data,
               backgroundColor: 'rgba(75, 192, 192, 0.2)',
               borderColor: 'rgba(75, 192, 192, 1)',
               borderWidth: 1
            }]
         },
         options: {
            scales: {
               y: {
                  beginAtZero: true
               }
            }
         }
      });
   }
    </script>

</asp:Content>
