using System;
using System.Collections.Generic;
// communicates with the rest of the services within the application
	public class CustomerController
	{
		public CustomerController()
		{
		}

		public static List<String> getListOfCustomerNames()
		{
			Customer customer = new Customer();
			return customer.getListOfCustomerNames();
		}
		public static int getCustomerCount()
		{
			Customer customer = new Customer();
			return customer.getNumberOfCustomers();
		}

	}
