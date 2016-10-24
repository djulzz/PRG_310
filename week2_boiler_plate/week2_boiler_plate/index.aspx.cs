using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace week2_boiler_plate
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AssignmentContainer ctn = new AssignmentContainer();
            ctn.AssignmentWeek2();
        }
    }
}