using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Graficos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected string getData()
        {
            DataTable data = new DataTable();

            data.Columns.Add(new DataColumn("Task", typeof(string)));
            data.Columns.Add(new DataColumn("Hours per day", typeof(string)));

            data.Rows.Add(new Object[] { "Work", 11});

           
            data.Rows.Add(new Object[] { "Eat", 2 });
            data.Rows.Add(new Object[] { "Commute", 2 });
            data.Rows.Add(new Object[] { "Watch Tv", 2 });
            data.Rows.Add(new Object[] { "Sleep", 7 });
            string strData = "[['Task', 'Hours per day'],";
            foreach (DataRow tr in data.Rows)
            {
                strData = strData + "[";
                strData = strData + "'"+tr[0]+"'"+","+tr[1];
                strData = strData + "],";
            }
            strData = strData + "]";
            return strData;
        }
    }
}