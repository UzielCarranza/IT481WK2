using System;
using System.Data.SqlClient;

// data access layer
public class Database
{

	private SqlConnection connection = null;
    private String connectionString = null;
	public Database(String dataSource)
	{
        this.initConnection(dataSource);
	}
    public Database()
    {
        // default connection strin 
        this.initConnection(@"Data Source=DESKTOP-SNF4O05\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
    }
    private void initConnection(String connectionString)
    {
        this.connectionString = connectionString;
    }
    public SqlConnection getDbConnection()
    {
        if (this.connection == null)
        {
            this.connection = new SqlConnection(this.connectionString);
        }
        if (this.connection.State == System.Data.ConnectionState.Closed ||
        this.connection.State == System.Data.ConnectionState.Broken)
        {
            this.connection.Open();
        }
        return this.connection;
    }

    public void closeConnection()
    {
        this.connection.Close();
    }

    public SqlCommand getSqlCommand(String query)
    {
        return new SqlCommand(query, this.getDbConnection());
    }

    public SqlDataReader getdataReader(String query)
    {
        return this.getSqlCommand(query).ExecuteReader();
    }
}
