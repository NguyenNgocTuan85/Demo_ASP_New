using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Demo_GitHub
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! Page.IsPostBack)
            {
                Bind();

            }
        }


        public void Bind()
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("column 1");
            dt.Columns.Add("column 2");
            dt.Columns.Add("column 3");

            for (int i=0; i<5; i++)
            {
                DataRow row = dt.NewRow();
                row["column 1"] = "row " + (i + 1) + ",column 1";
                row["column 2"] = "row " + (i + 1) + ",column 2";
                row["column 3"] = "row " + (i + 1) + ",column 3";

                dt.Rows.Add(row);
            }

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
            

    }
}