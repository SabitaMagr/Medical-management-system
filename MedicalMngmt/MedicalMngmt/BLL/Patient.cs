using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MedicalMngmt.BLL
{
    public class Patient
    {
        #region gettersetter
        private string _name;

        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        }
        public string Age { get; set; }
        #endregion
        public int CreateUser(string Name, string Age, string Address, string Mobile_No, int Medicine_No, string Medicine_Name, string Manufacturer_Name, string Disease_Name, string Relative_Name, bool Gender)
        {
            string sql = "CreateUser";
            SqlParameter[] param = new SqlParameter[]
            {
               new SqlParameter("@a",Name),
               new SqlParameter("@b",Age),
               new SqlParameter("@c",Address),
               new SqlParameter("@d",Mobile_No),
               new SqlParameter("@f",Medicine_No),
               new SqlParameter("@g",Medicine_Name),
               new SqlParameter("@h",Manufacturer_Name),
               new SqlParameter("@i",Disease_Name),
               new SqlParameter("@j",Relative_Name),
               new SqlParameter("@e",Gender),
            };
            return Connect.IUD(sql, param,CommandType.StoredProcedure);
        }
        public DataTable GetPatient()
        {
            string sql = "GetPatient";
            return Connect.GetTable(sql, null,CommandType.StoredProcedure);

        }
        public DataTable GetPatientById(int Registration_No)
        {
            string sql = "GetPatientbyId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",Registration_No),
            };
            return Connect.GetTable(sql, param,CommandType.StoredProcedure);
        }
        public int UpdatePatient(string Name, string Age, string Address, string Mobile_No, int Medicine_No, string Medicine_Name, string Manufacturer_Name, string Disease_Name, string Relative_Name, int Registration_No, bool Gender)
        {
            string sql = "UpdatePatient";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",Name),
                new SqlParameter("@b",Age),
                new SqlParameter("@c",Address),
                new SqlParameter("@d",Mobile_No),
                new SqlParameter("@f",Medicine_No),
                new SqlParameter("@g",Medicine_Name),
                new SqlParameter("@h",Manufacturer_Name),
                new SqlParameter("@i",Disease_Name),
                new SqlParameter("@j",Relative_Name),
                new SqlParameter("@k",Registration_No),
                new SqlParameter("@e",Gender),
            };
            return Connect.IUD(sql, param,CommandType.StoredProcedure);
        }
        public int DeletePatient(int Registration_No)
        {
            string sql = "DeletePatient";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@a",Registration_No),
            };
            return Connect.IUD(sql, param,CommandType.StoredProcedure);
        }
        public int Addition(int admitdays, int charge, int doctorfee, int medicinefee)
        {
            return admitdays * charge + doctorfee + medicinefee;
        }

    }

}
