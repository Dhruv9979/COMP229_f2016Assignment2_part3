using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using statements that are required to connect to EF_DB
using System.Web.ModelBinding;
using COMP229_F2016_Assignment2_Part3.Models;

namespace COMP229_F2016_Assignment2_Part3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if loading the page for the first time 
            //populate the cricket grid

            if (!IsPostBack)
            {
                this.getCricket();
            }
        }
        private void getCricket()
        {
            using (CricketContext db = new CricketContext())
            {
                //query the students table using EF and LINQ
                var Cricket = (from allTeams in db.Crickets
                               select allTeams);
                //BIND THE RESULT TO TEAM GRID VIEW 
                teamGridView.DataSource = Cricket.ToList();
                teamGridView.DataBind();
            }
        }
    }
}