using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;    

namespace Tracking_Soft_v2
{
    class TalkDB_T
    {
        public static class myGlobal
        {
            public static string connectionString = getConnectionString();
        }

        public static string getConnectionString()
        {
            string fileName = "Track_Data.mdf";
            string fullPath;
            fullPath = Path.GetFullPath(fileName);
            return fullPath;
        }

        public static SqlConnection con = null;

        public TalkDB_T()
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string newpath = path.Remove(path.Length - 9, 9) + "Track_Data.mdf";
            string fullPath = newpath.Remove(0, 6);
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + fullPath + ";Integrated Security=True");
        }
        public void closeConnection()
        {
            con.Close();
        }
        public DataTable LoginT(String Username, String Password)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select Role, LoginID from LoginT Where Username= '" + Username + "' and Password= '" + Password + "'   ", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            return dt;
        }
        public SqlCommand AddUser()
        {
            String sql = "INSERT INTO LoginT (Username,Password,Role,Firstname,Lastname) VALUES (@Username, @Password, @Role, @Firstname, @Lastname)";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            return cmd;
        }
    }
}
