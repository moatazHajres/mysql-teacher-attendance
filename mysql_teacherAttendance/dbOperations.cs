using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace mysql_teacherAttendance
{
    class dbOperations
    {
    
    public static string constring = "datasource=localhost;port=3306;username=root;password=";
    public static string query = "";
    public static MySqlCommand cmd = default(MySqlCommand);
    public static MySqlConnection con = new MySqlConnection(constring);

        public static DataTable execute(MySqlCommand c)
        {  
            DataTable dt = new DataTable();   
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = c;
            adapter.Fill(dt);
            return dt;
        }
    
        

   
    }
}
