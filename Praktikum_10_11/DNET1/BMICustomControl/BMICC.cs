using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BMICustomControl
{
    public class BMICC : Label
    {
        protected override void Render(HtmlTextWriter w)
        {
            if (double.Parse(Text) < 21)
            {
                w.Write("<span style='background-color:red;'> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </span>");
            } else if (double.Parse(Text) < 23)
            {
                w.Write("<span style='background-color:yellow;'> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </span>");
            } else if (double.Parse(Text) < 25)
            {
                w.Write("<span style='background-color:green;'> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </span>");
            }
            else if (double.Parse(Text) < 27)
            {
                w.Write("<span style='background-color:yellow;'> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </span>");
            }
            else if (double.Parse(Text) < 29)
            {
                w.Write("<span style='background-color:red;'> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </span>");
            }
        }
    }
}
