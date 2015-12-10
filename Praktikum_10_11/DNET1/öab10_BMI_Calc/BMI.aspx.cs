using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BMI : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /**ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
        {
            Path = "~/scripts/jquery-1.10.2.min.js",
            DebugPath = "~/scripts/jquery-1.10.2.min.js",
            CdnPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.4.1.min.js",
            CdnDebugPath = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.4.1.js"
        });**/
    }
    public void Reset(object sender, EventArgs e)
    {
        myHeight.Text = "";
        myWeight.Text = "";
        myBMI.Text = "";
    }
    public void CalculateBMI(object sender, EventArgs e)
    {
        double height = Convert.ToDouble(myHeight.Text);
        double weight = Convert.ToDouble(myWeight.Text);
        double bmi = weight / (height * height);
        myBMI.Text = "BMI: " + bmi;
        myBMItxtB.Text = bmi.ToString();
        
    }

    public void transferPage(object sender, EventArgs e)
    {
        CalculateBMI(sender, e);
        Server.Transfer("ResultPage.aspx", true);
    }
}