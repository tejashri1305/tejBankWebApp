﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankAppWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblNews.Text = "Welcome on  " +DateTime.Now.ToShortDateString() + " For Internal demo3";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin1")
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}