using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.App_Code;
using WebApplication1.App_Code.dsFirmaTableAdapters;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dsFirma.FirmaDataTable firma = new dsFirma.FirmaDataTable();

            firma.NewFirmaRow();

            FirmaTableAdapter.

        }
    }
}