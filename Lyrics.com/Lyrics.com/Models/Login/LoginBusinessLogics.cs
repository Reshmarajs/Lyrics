using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lyrics.com.Models.Login
{
    public class LoginBusinessLogics
    {
        public void SaveCustomer(UserModel userModel)
        {
            using (SqlConnection con = new SqlConnection(DBAccess.GetConnectionString()))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_SaveCustomer", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", userModel.Name);
                    cmd.Parameters.AddWithValue("@Address", userModel.Address);
                    cmd.Parameters.AddWithValue("@Email", userModel.Email);
                    cmd.Parameters.AddWithValue("@PhoneNo", userModel.PhoneNo);
                    cmd.Parameters.AddWithValue("@PinCode", userModel.PinCode);
                    cmd.Parameters.AddWithValue("@Username", userModel.Username);
                    cmd.Parameters.AddWithValue("Password", userModel.Password);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public List<UserModel> GetCustomer(int Id)
        {
            List<UserModel> ListUser = new List<UserModel>();
            using (SqlConnection con = new SqlConnection(DBAccess.GetConnectionString()))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SP_SelectUser", con);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if(rdr.HasRows)
                    {
                        while(rdr.Read())
                        {
                            UserModel userModel = new UserModel();
                            userModel.Id = Convert.ToInt32(rdr["Id"].ToString());
                            userModel.Name = rdr["Name"].ToString();
                            userModel.Address = rdr["Address"].ToString();
                            userModel.Email = rdr["Email"].ToString();
                            userModel.PinCode = rdr["PinCode"].ToString();
                            userModel.PhoneNo = Convert.ToInt64(rdr["PhoneNo"].ToString());
                            userModel.Username = rdr["Username"].ToString();
                            userModel.Password = rdr["Password"].ToString();
                            ListUser.Add(userModel);
                        }
                    }
                    return ListUser;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    con.Close();

                }
            }
        }
    }
}