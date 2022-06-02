using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using EntityToDB;
namespace EGen
{
	/// <summary>
	/// Interaction logic for SelectSqlServerWin.xaml
	/// </summary>
	public partial class SelectSqlServerWin : Window
	{
		public string Server =>c_server.Text;
		public string UserName =>c_userName.Text;
		public string Password => c_password.Password;

		public SelectSqlServerWin()
		{
			InitializeComponent();
		}

		private void OKClick(object sender, RoutedEventArgs e)
		{


			using (SqlConnection db = new SqlConnection(DbUtil.GetConnectionString(Server, UserName, Password, "Master")))
			{
				try
				{
					db.Open();
					this.DialogResult = true;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
	
			}

		}
	}
}
