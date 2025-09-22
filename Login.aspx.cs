using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    SqlConnection CON = new SqlConnection();
    SqlCommand CMD = new SqlCommand();
    SqlDataReader DR;
    DataTable DT = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (CON.State != ConnectionState.Open)
        {
            CON.ConnectionString = "Data Source=(local);Initial Catalog=VEHICLE_DB;Integrated Security=True";
            CON.Open();
        }
    }
    protected void BTN_LOGIN_Click(object sender, EventArgs e)
    {
        try
        {
            string QUERY;
            QUERY = "SELECT LOGIN_NAME, LOGIN_PASSWORD, USER_TYPE FROM TBL_LOGIN WHERE LOGIN_NAME = '" + TXT_LOGIN_NAME.Text + "' AND LOGIN_PASSWORD = '" + TXT_PASSWORD.Text + "'";
            CMD.CommandText = QUERY;
            CMD.Connection = CON;
            CMD.CommandType = CommandType.Text;
            DR = CMD.ExecuteReader();
            DT.Clear();
            DT.Load(DR);
            if (DT.Rows.Count > 0)
            {
                if (DT.Rows[0]["USER_TYPE"].ToString() == "Admin")
                {
                    Session["LOGIN_NAME"] = DT.Rows[0]["LOGIN_NAME"].ToString();
                    Response.Redirect(@"~\Admin\Admin_Default.aspx");
                }
                else if (DT.Rows[0]["USER_TYPE"].ToString() == "Buyer")
                {
                    Session["LOGIN_NAME"] = DT.Rows[0]["LOGIN_NAME"].ToString();
                    Response.Redirect(@"~\Buyer\Buyer_Default");
                }
                else if (DT.Rows[0]["USER_TYPE"].ToString() == "Seller")
                {
                    Session["LOGIN_NAME"] = DT.Rows[0]["LOGIN_NAME"].ToString();
                    Response.Redirect(@"~\Seller\Seller_Default");
                }
            }
            else
            {
                LBL_MESSAGE.ForeColor = Color.Red;
                LBL_MESSAGE.Text = "Invalid User Name or Password";
                TXT_LOGIN_NAME.Focus();
                Session["LOGIN_NAME"] = null;
            }
        }
        catch (Exception EX)
        {
            LBL_MESSAGE.ForeColor = Color.Red;
            LBL_MESSAGE.Text = EX.Message;
        }
    }
}