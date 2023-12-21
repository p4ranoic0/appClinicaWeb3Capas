using Clinica_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Data;
using Clinica_BE;

namespace ClinicaWEB.Reportes
{
    public partial class Graficos3 : System.Web.UI.Page
    {
        AtencionBL atencionBL = new AtencionBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Obtener datos estadísticos
            List<AtencionBE> listaAtenciones = atencionBL.ListarAtencion();


            // Calcular la cantidad de atenciones por sede
            var estadisticas = listaAtenciones
                .GroupBy(atencion => new { atencion.Cod_suc })
                .Select(g => new
                {
                    NombreSucursal = atencionBL.ConsultarNombreSucursalPorCod(g.Key.Cod_suc),
                    CantidadAtenciones = g.Count()
                })
                .OrderByDescending(stat => stat.CantidadAtenciones) // Ordenar de mayor a menor cantidad de atenciones
                .Take(5); // Tomar solo las 5 primeras salas


            // Convertir datos a formato JSON
            var jsonEstadisticas = Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                labels = estadisticas.Select(stat => stat.NombreSucursal),
                data = estadisticas.Select(stat => stat.CantidadAtenciones)
            });

            // Pasar datos al frontend
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CargarGrafico", $"CargarGrafico({jsonEstadisticas});", true);
        }
    }
}
