using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HepsiSurada
{
    class Database
    {
        public SqlConnection conn;
        public SqlCommand cmd;

        public void Baglan()
        {
            conn = new SqlConnection("Data Source=DESKTOP-68V49NQ;Initial Catalog=HepsiSurada;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
    }
}
