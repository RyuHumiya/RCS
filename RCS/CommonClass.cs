using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace RCS
{
    class CommonClass
    {
        public DataTable throwSelect(string sql)
        {
            DataTable dt = new DataTable();

            string ConnectionString = "";
            ConnectionString = "DATA SOURCE = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.70)(PORT = 1521)))";
            ConnectionString += "(CONNECT_DATA = (SERVICE_NAME = UBIZDB)));";
            ConnectionString += "USER ID=RCS;PASSWORD=RCS";

            OracleConnection conn = new OracleConnection(ConnectionString);

            conn.Open();

            OracleCommand oracmd = new OracleCommand();
            oracmd.Connection = conn;
            oracmd.CommandType = CommandType.Text;

            oracmd.CommandText = sql;

            OracleDataAdapter adapter = new OracleDataAdapter();

            adapter.SelectCommand = oracmd;

            //adapter.Fill(ds);
            adapter.Fill(dt);

            return dt;
        }
    }
}
