using PinPayment.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PinPayment.Models
{
    public class CustomerModel
    {
        public int AddCustomer(SiteSubscriber customer)
        {
            int id = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["con"].ToString();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CustomerInsert", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@primaryContact", SqlDbType.VarChar).Value = customer.FirstName+" "+customer.LastName;
                        cmd.Parameters.Add("@companyName", SqlDbType.VarChar).Value = customer.Company;
                        cmd.Parameters.Add("@primaryContactEmail", SqlDbType.VarChar).Value = customer.Email;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = customer.Password;
                        cmd.Parameters.Add("@serviceLevel", SqlDbType.VarChar).Value = customer.SubscriptionId.ToString();
                        cmd.Parameters.Add("@promoCode", SqlDbType.VarChar).Value = customer.PromoCode;


                        con.Open();
                        //var dd = cmd.ExecuteNonQuery();
                        //var idd = cmd.Parameters["@newCustomerID"].Value;
                        var d = cmd.ExecuteScalar();
                        id = Convert.ToInt32(d);
                    }
                }
            }
            catch { }
            return id;
        }

        public bool IsEmailExist(string Email)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["con"].ToString();
            DataTable table = new DataTable("allPrograms");
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                string command = "select * from Customer where primaryContactEmail=@Email";
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", Email);

                    conn.Open();
                    var dd = cmd.ExecuteScalar();
                    if (dd != null)
                    {
                        return false;
                    }
                    conn.Close();
                }
            }

            return true;
        }
    }
}