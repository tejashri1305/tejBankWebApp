﻿using BankAppWeb.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankAppWeb
{
    public partial class GetCustomers1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCustomerData();
                //Test
            }

        }

        private void LoadCustomerData()
        {
            try
            {
                BusinessLogic blLoadCustomer = new BusinessLogic();
                DataTable dtCust = blLoadCustomer.GetCustomerDetails();
                grdCustomers.DataSource = dtCust;
                grdCustomers.DataBind();
            }
            catch (Exception ex)
            {

            }
        }

           
        protected void grdCustomers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdCustomers.PageIndex = e.NewPageIndex;
            LoadCustomerData();
        }
    }
}