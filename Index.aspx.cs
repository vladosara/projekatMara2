using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Index : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["KonekcioniString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            HtmlGenericControl div = new HtmlGenericControl("div");
            div.Attributes["class"] = "odgovor1";
            Label naslov = new Label();
            Label naslov2 = new Label();
            naslov.Attributes["class"] = "blok";
            naslov2.Attributes["class"] = "blok";
            string tekst = divKreiranje();
            naslov.Text = tekst;
            naslov2.Text = "Razlog zbog kojeg te volim:";
            div.Controls.Add(naslov2);
            div.Controls.Add(naslov);


            HtmlGenericControl odgovor = FindControl("odgovor") as HtmlGenericControl;
            if (odgovor != null)
            {
                odgovor.Controls.Add(div);
            }

        }



        public string divKreiranje()
        {
            string tekst = "123"; // Declare a string variable to store the value

            conn.Open();
            try
            {
                string naredba = "SELECT TOP 1 * FROM PORUKE ORDER BY NEWID();";
                SqlCommand komanda = new SqlCommand(naredba, conn);
                SqlDataReader citac = komanda.ExecuteReader();

                if (citac.HasRows)
                {
                    citac.Read();
                    // Assuming "TEXT" is the second column (index 1)
                    tekst = citac.GetString(1);
                    return tekst;
                }
                else
                {
                    // Handle the case where no data is found
                    tekst = "No data found.";
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception more gracefully
                tekst = "Error: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return tekst;
        }

    }
}