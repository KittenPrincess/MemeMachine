using System;
using System.Data;
using System.Web.Security;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class SignIn : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    SqlConnection con = new SqlConnection();
    SqlDataAdapter sda = new SqlDataAdapter();
    DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        //Opens connection to the Database
        con.ConnectionString = "Data source =stusql;initial catalog=MemeMachine;integrated Security=true";
        con.Open();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        /*
         * Goes into our Database, checking if the username and password exists
         * userName = Username Text Field
         * passWord = Password Text Field
         * Label1 = Text label that shows if data is or is not found
         */
        cmd.CommandText = "SELECT * FROM USERS WHERE Username='" + userName.Text + "' AND UserPass='" + passWord.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        sda.Fill(ds, "USERS");
        if (ds.Tables[0].Rows.Count > 0)
        {
            Response.Redirect("MemePage.aspx?Scr=");
        }
        else
        {
            Label1.Text = "Wrong Username or Password";
        }
    }
}