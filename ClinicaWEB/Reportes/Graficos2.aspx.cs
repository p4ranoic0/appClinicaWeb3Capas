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

namespace sitioWebClinica.Reportes
{
    public partial class Graficos2 : System.Web.UI.Page
    {
        AtencionBL atencionBL = new AtencionBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Obtener datos estadísticos
            List<AtencionBE> listaAtenciones = atencionBL.ListarAtencion();
            MedicoBL medicoBL = new MedicoBL(); 

            // Calcular la cantidad de atenciones por médico
            var estadisticas = listaAtenciones
                .GroupBy(atencion => new { atencion.Cod_med })
                .Select(g => new
                {
                    CodMedico = g.Key,
                    NombreMedico = medicoBL.ConsultarNombreMedicoPorCod(g.Key.Cod_med),

                    CantidadAtenciones = g.Count()
                })
                .OrderByDescending(stat => stat.CantidadAtenciones)
                .Take(5);

            // Convertir datos a formato JSON
            var jsonEstadisticas = JsonConvert.SerializeObject(new
            {
                labels = estadisticas.Select(stat => stat.NombreMedico.ToString()),
                data = estadisticas.Select(stat => stat.CantidadAtenciones)
            });

            // Pasar datos al frontend
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CargarGrafico", $"CargarGrafico({jsonEstadisticas});", true);
        }
    }
}
