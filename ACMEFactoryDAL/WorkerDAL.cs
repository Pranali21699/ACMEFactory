using ACMEFactoryDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ACMEFactoryDAL
{
    public class WorkerDAL

    {
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;
        public WorkerDAL()
        {
            sqlConObj = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ToString());

        }

        public List<DTO> Login(int id,string username,string password, out int rowAffected)
        {
            List<DTO> lstCheck = new List<DTO>();
            sqlCmdObj = new SqlCommand("dbo.CheckPassword", sqlConObj);
            sqlCmdObj.CommandType = System.Data.CommandType.StoredProcedure;
            //sqlCmdObj.Parameters.AddWithValue("@ID", id);
            //sqlCmdObj.Parameters.AddWithValue("@Username", username);
            //sqlCmdObj.Parameters.AddWithValue("@Password", password);
            sqlCmdObj.Parameters.Equals(id);
            try
            {
                sqlConObj.Open();


                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                rowAffected = sqlCmdObj.ExecuteNonQuery();
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oopppss, Something went Wrong !");
                rowAffected = 0;
                return 0;
            }
            finally
            {
                sqlConObj.Close();
            }
        }

        public int InsertAppLoginTime(int Iplgtime,  out int rowAffected)
        {

            sqlCmdObj = new SqlCommand("dbo.uspInsertAppLoginTime", sqlConObj);
            sqlCmdObj.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmdObj.Parameters.AddWithValue("@LoginTime", Iplgtime);
            
            try
            {
                sqlConObj.Open();


                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                rowAffected = sqlCmdObj.ExecuteNonQuery();
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oopppss, Something went Wrong !");
                rowAffected = 0;
                return 0;
            }
            finally
            {
                sqlConObj.Close();
            }
        }

        public int InsertAppLogoutTime(int Iplgotime, out int rowAffected)
        {

            sqlCmdObj = new SqlCommand("dbo.uspInsertAppLogoutTime", sqlConObj);
            sqlCmdObj.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmdObj.Parameters.AddWithValue("@LogoutTime", Iplgotime);

            try
            {
                sqlConObj.Open();


                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                rowAffected = sqlCmdObj.ExecuteNonQuery();
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oopppss, Something went Wrong !");
                rowAffected = 0;
                return 0;
            }
            finally
            {
                sqlConObj.Close();
            }
        }
        //m1
        public int InsertLoginTimeForM1(int Iplgtime, out int rowAffected)
        {

            sqlCmdObj = new SqlCommand("dbo.uspInsertLoginTime", sqlConObj);
            sqlCmdObj.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmdObj.Parameters.AddWithValue("@LoginTime", Iplgtime);

            try
            {
                sqlConObj.Open();


                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                rowAffected = sqlCmdObj.ExecuteNonQuery();
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oopppss, Something went Wrong !");
                rowAffected = 0;
                return 0;
            }
            finally
            {
                sqlConObj.Close();
            }
        }

        public int InsertLogoutTimeForM1(int Iplgotime, out int rowAffected)
        {

            sqlCmdObj = new SqlCommand("dbo.uspInsertLogoutTime", sqlConObj);
            sqlCmdObj.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmdObj.Parameters.AddWithValue("@LogoutTime", Iplgotime);

            try
            {
                sqlConObj.Open();


                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                rowAffected = sqlCmdObj.ExecuteNonQuery();
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oopppss, Something went Wrong !");
                rowAffected = 0;
                return 0;
            }
            finally
            {
                sqlConObj.Close();
            }
        }
        //m2

        public int InsertLoginTimeForM2(int Iplgtime, out int rowAffected)
        {

            sqlCmdObj = new SqlCommand("dbo.uspInsertLoginTime", sqlConObj);
            sqlCmdObj.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmdObj.Parameters.AddWithValue("@LoginTime", Iplgtime);

            try
            {
                sqlConObj.Open();


                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                rowAffected = sqlCmdObj.ExecuteNonQuery();
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oopppss, Something went Wrong !");
                rowAffected = 0;
                return 0;
            }
            finally
            {
                sqlConObj.Close();
            }
        }

        public int InsertLogoutTimeForM2(int Iplgotime, out int rowAffected)
        {

            sqlCmdObj = new SqlCommand("dbo.uspInsertLogoutTime", sqlConObj);
            sqlCmdObj.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmdObj.Parameters.AddWithValue("@LogoutTime", Iplgotime);

            try
            {
                sqlConObj.Open();


                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                rowAffected = sqlCmdObj.ExecuteNonQuery();
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oopppss, Something went Wrong !");
                rowAffected = 0;
                return 0;
            }
            finally
            {
                sqlConObj.Close();
            }
        }
        //m3
        public int InsertLoginTimeForM3(int Iplgtime, out int rowAffected)
        {

            sqlCmdObj = new SqlCommand("dbo.uspInsertLoginTime", sqlConObj);
            sqlCmdObj.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmdObj.Parameters.AddWithValue("@LoginTime", Iplgtime);

            try
            {
                sqlConObj.Open();


                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                rowAffected = sqlCmdObj.ExecuteNonQuery();
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oopppss, Something went Wrong !");
                rowAffected = 0;
                return 0;
            }
            finally
            {
                sqlConObj.Close();
            }
        }

        public int InsertLogoutTimeForM3(int Iplgotime, out int rowAffected)
        {

            sqlCmdObj = new SqlCommand("dbo.uspInsertLogoutTime", sqlConObj);
            sqlCmdObj.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmdObj.Parameters.AddWithValue("@LogoutTime", Iplgotime);

            try
            {
                sqlConObj.Open();


                SqlParameter rm = sqlCmdObj.Parameters.Add("RetVal", SqlDbType.Int);
                rm.Direction = ParameterDirection.ReturnValue;
                rowAffected = sqlCmdObj.ExecuteNonQuery();
                int returnValue = (int)rm.Value;
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oopppss, Something went Wrong !");
                rowAffected = 0;
                return 0;
            }
            finally
            {
                sqlConObj.Close();
            }
        }



    }
}

