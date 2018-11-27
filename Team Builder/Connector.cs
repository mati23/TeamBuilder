using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Team_Builder
{
    class Connector
    {
        private string connectionString = @"Server=localhost;Database=teambuilder;Uid=root;Password=123456789;";
        
            public Connector(string sql_query, bool is_read_operation)
            {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(sql_query);
            command.CommandType = System.Data.CommandType.Text;
            connection.Open();
             }
           
    }
}
