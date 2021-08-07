using ACMEFactoryDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEFactoryBL
{
   public class WorkerBL
    {
        WorkerDAL obj;
        public WorkerBL()
        {
            obj = new WorkerDAL();
        }
        //public List<DTO> Login(int id, string username, string password, out int rowAffected)
        public List<ACMEFactoryDTO.DTO> LoginCheck(int id, string username, string password, out int rowAffected)
        {
            try
            {
                var ret = obj.Login(id, username, password, out rowAffected);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertALoginTime(int Iplgtime, out int rowAffected)
        {
            try
            {
                var ret = obj.InsertAppLoginTime(Iplgtime,out rowAffected);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertALogoutTime(int Iplgotime, out int rowAffected)
        {
            try
            {
                var ret = obj.InsertAppLogoutTime(Iplgotime, out rowAffected);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //for m1
        public int InsertALoginTimeForM1(int Iplgtime, out int rowAffected)
        {
            try
            {
                var ret = obj.InsertAppLoginTime(Iplgtime, out rowAffected);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertALogoutTimeForM1(int Iplgotime, out int rowAffected)
        {
            try
            {
                var ret = obj.InsertAppLogoutTime(Iplgotime, out rowAffected);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //For m2
        public int InsertALoginTimeForM2(int Iplgtime, out int rowAffected)
        {
            try
            {
                var ret = obj.InsertAppLoginTime(Iplgtime, out rowAffected);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertALogoutTimeForM2(int Iplgotime, out int rowAffected)
        {
            try
            {
                var ret = obj.InsertAppLogoutTime(Iplgotime, out rowAffected);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //for m3
        public int InsertALoginTimeForM3(int Iplgtime, out int rowAffected)
        {
            try
            {
                var ret = obj.InsertAppLoginTime(Iplgtime, out rowAffected);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertALogoutTimeForM3(int Iplgotime, out int rowAffected)
        {
            try
            {
                var ret = obj.InsertAppLogoutTime(Iplgotime, out rowAffected);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
