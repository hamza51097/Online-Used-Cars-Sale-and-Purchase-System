using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sign_Up : System.Web.UI.Page
{
    SqlCommand CMD = new SqlCommand();
    SqlConnection CON = new SqlConnection();
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
    protected void BTN_REGISTER_Click(object sender, EventArgs e)
    {
        try
        {
            if (TXT_PASSWORD.Text == TXT_CONFIRM_PASSWORD.Text)
            {
                CMD.CommandText = "SELECT * FROM TBL_REGISTRATION WHERE R_LOGIN_NAME = '" + TXT_LOGIN_NAME.Text + "'";
                CMD.CommandType = CommandType.Text;
                CMD.Connection = CON;
                DR = CMD.ExecuteReader();
                DT.Clear();
                DT.Load(DR);
                if (DT.Rows.Count > 0)
                {
                    LBL_MESSAGE.ForeColor = Color.Red;
                    LBL_MESSAGE.Text = "Login name already exist";
                    TXT_LOGIN_NAME.Focus();
                }
                else
                {
                    int NO_OF_ROWS = 0;
                    string QUERY;
                    QUERY = "INSERT INTO TBL_REGISTRATION (R_LOGIN_NAME, R_USER_TYPE, R_USER_NAME, R_LOGIN_PASSWORD, R_REQUEST_STATUS, R_REQUSET_DATE) VALUES ('";
                    QUERY += TXT_LOGIN_NAME.Text + "', '" + TXT_USER_TYPE.Text + "', '" + TXT_USER_NAME + "', '" + TXT_PASSWORD + "', 0, GETDATE())";
                    CMD.Connection = CON;
                    CMD.CommandText = QUERY;
                    CMD.CommandType = CommandType.Text;
                    NO_OF_ROWS = CMD.ExecuteNonQuery();
                    if (NO_OF_ROWS > 0)
                    {
                        LBL_MESSAGE.ForeColor = Color.Green;
                        LBL_MESSAGE.Text = "LOGIN REQUESTED SUCCESSFULLY SAVED";
                        TXT_LOGIN_NAME.Text = null;
                        TXT_PASSWORD.Text = null;
                        TXT_USER_NAME.Text = null;
                        TXT_CONFIRM_PASSWORD.Text = null;
                        TXT_LOGIN_NAME.Focus();
                    }
                    else
                    {
                        LBL_MESSAGE.ForeColor = Color.Red;
                        LBL_MESSAGE.Text = "ERROR OCCURED";
                    }
                }
            }
            else
            {
                LBL_MESSAGE.ForeColor = Color.Red;
                LBL_MESSAGE.Text = "PASSWORD DIDNOT MATCHED";
                TXT_CONFIRM_PASSWORD.Focus();
            }
        }
        catch (Exception EX)
        {
            LBL_MESSAGE.ForeColor = Color.Red;
            LBL_MESSAGE.Text = EX.Message;
        }
    }
}