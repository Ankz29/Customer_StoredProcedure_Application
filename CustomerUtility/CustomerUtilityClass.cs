using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Customer_Application.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Customer_Application.CustomerUtility
{
    public static class CustomerUtilityClass
    {
        public static void InsertData(Customer modelData)
        {
          
            try
            {
                string Connection_String = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
                using (var sqlConnection = new SqlConnection(Connection_String))
                {

                    using (SqlCommand command = new SqlCommand("sp_Customer_Application", sqlConnection))
                    {
                        command.Connection = sqlConnection;
                        sqlConnection.Open();

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CustomerID", 0);
                        command.Parameters.AddWithValue("@Name", modelData.Name);
                        command.Parameters.AddWithValue("@Address", modelData.Address);
                        command.Parameters.AddWithValue("@Phone_Number", (modelData.PhoneNumber));
                        command.Parameters.AddWithValue("@DOB",(modelData.DOB));
                        command.Parameters.AddWithValue("@Email_ID", modelData.Email_ID);
                        command.Parameters.AddWithValue("@Query", 1);                                    
                    }
                }
            }

            catch (Exception ex)
            {
                new Exception("data not saved !!");
            }
          
        }
    }
}