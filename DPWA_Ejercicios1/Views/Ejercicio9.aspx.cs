﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DPWA_Ejercicios1.Views
{
    public partial class Ejercicio9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            Models.Ejercicios process = new Models.Ejercicios();
            lblAnswer.Text = process.Ejercicio9(txtA.Text, txtB.Text, txtC.Text);
        }
    }
}