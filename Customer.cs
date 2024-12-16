using System;
using System.Collections.Generic;
using System.Data.SqlClient;

// business layer
public class Customer
{

    private Database db;
    public Customer()
	{
        this.db = new Database();
    }
    public int getNumberOfCustomers()
    {
        int customersCount = 0;
        try
        {
            // Create a command to execute the query
            using (SqlCommand command = this.db.getSqlCommand("SELECT COUNT(CustomerID) FROM Customers"))
            {
                customersCount = (int)command.ExecuteScalar();
            }
        }
        catch (Exception ex)
        {
            //TODO: handle edge cases for errors. Currently returning 0 UC
        }
        return customersCount;
    }

    public List<String> getListOfCustomerNames()
    {
        List<String> customerNames = new List<String>();
        try
        {
            using (SqlDataReader reader = this.db.getdataReader("SELECT ContactName FROM Customers"))
            {
                // Read the results
                while (reader.Read())
                {
                    customerNames.Add(reader["ContactName"].ToString());
                }
            }
        }
        catch (Exception ex)
        {
            customerNames.Add("No Customers Found!");
        }
        return customerNames;
    }
}
