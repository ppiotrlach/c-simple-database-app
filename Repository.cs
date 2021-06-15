using System;
using System.Data;
using System.Data.SqlClient;

public class Repository
{
	private readonly SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

	public Repository()
	{
	}
}
