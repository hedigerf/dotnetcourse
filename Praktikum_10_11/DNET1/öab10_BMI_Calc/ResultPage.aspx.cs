using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ResultPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string bmi = Request.Form["myBMItxtB"];
        this.BMI.Text = bmi;
        string date = Request.Form["dateField$date"];
        this.Date.Text = date;
        this.BMIcc.Text = bmi;
    }
}