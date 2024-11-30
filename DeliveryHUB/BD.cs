using System.Data.SqlClient;

namespace DeliveryHUB
{
    internal class BD
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DeliveryHUB;Integrated Security=True");


        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }


        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }


        public SqlConnection GetSqlConnection()
        {
            return sqlConnection;
        }
    }
}
