using BS.Mantenimientos;
using DAL.Mantenimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_Web_Forms
{
    public partial class FrmVehiculosShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cars> carros = new List<Cars>();

            carros = BS.Mantenimientos.MantCarro._Instancia.Mostrar();

            gvTablaUno.DataSource = carros;
            gvTablaUno.DataBind();

            gvTablaUno.HeaderRow.Cells[1].Visible = false;
                foreach (GridViewRow gvr in gvTablaUno.Rows)
                {
                  gvr.Cells[1].Visible = false;
                }
            }
    

        protected void gvTablaUno_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int r;
                r = gvTablaUno.Columns.Count;
                var row = e.CommandArgument;

            }
        }

        protected void gvTablaUno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}