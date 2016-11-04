using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week2_boiler_plate
{
    public class AssignmentContainer : System.Web.UI.Page
    {
        public void AssignmentWeek2()
        {
            //HttpResponse Response = new HttpResponse(new System.IO.StringWriter());
            HttpContext.Current.Response.Write("Hello From AssignmentWeek2");
        }
    }
}