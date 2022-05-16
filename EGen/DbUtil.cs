using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EGen
{
	public static  class DbUtil
	{
		public static string  GetConnectionString(string server, string userName, string password, string dbName)
		{
			SqlConnectionStringBuilder connStrBuilder = new SqlConnectionStringBuilder();
			connStrBuilder.DataSource = server;
			if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
			{
				connStrBuilder.IntegratedSecurity = true;
				connStrBuilder.InitialCatalog = dbName;
			}
			else
			{
				connStrBuilder.UserID = userName;
				connStrBuilder.Password = password;
			}

			string connStr = connStrBuilder.ToString();

			return connStr;
		}
	}
}
