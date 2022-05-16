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
using System.Windows.Navigation;
using System.Windows.Shapes;
using EntityToDB;
using TSDataDatabase;
using TSDataModel;
using CommonLibrary;
namespace DbTest
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private string GetConnectionString()
		{
			SqlConnectionStringBuilder connStrBuilder = new SqlConnectionStringBuilder();
			connStrBuilder.DataSource = @".\sqlexpress";
			connStrBuilder.InitialCatalog = "TSData";
			connStrBuilder.IntegratedSecurity = true;

			return connStrBuilder.ConnectionString;
		}
		private void ReadClick(object sender, RoutedEventArgs e)
		{
			using TSDataDbHandle tsData = new TSDataDbHandle(GetConnectionString());
			var list = tsData.Read<tCustomer>("where Country = {0}", "US");
			c_grid.ItemsSource = list;
		}

		private void ReadTypeClick(object sender, RoutedEventArgs e)
		{
			using TSDataDbHandle tsData = new TSDataDbHandle(GetConnectionString());
			var list = tsData.Read(typeof(tCustomer),"where Country = {0}", "UK");
			c_grid.ItemsSource = list;
		}
		private void FindClick(object sender, RoutedEventArgs e)
		{
			using TSDataDbHandle tsData = new TSDataDbHandle(GetConnectionString());
			var cust = tsData.Find<tCustomer>("where CustomerID = {0}", "100");
			c_info.Text = String.Format("Customer ID - {0}. Name - {1}", cust.CustomerID, cust.CustomerName);		
		}

		private void FindTypeClick(object sender, RoutedEventArgs e)
		{
			using TSDataDbHandle tsData = new TSDataDbHandle(GetConnectionString());
			var cust = (tCustomer) tsData.Find(typeof(tCustomer), "where CustomerID = {0}", "100");
			c_info.Text = String.Format("Customer ID - {0}. Name - {1}", cust.CustomerID, cust.CustomerName);
		}

		private void QueryClick(object sender, RoutedEventArgs e)
		{
			using TSDataDbHandle tsData = new TSDataDbHandle(GetConnectionString());
			var list = tsData.Query<vCustomerSite> ("select * from vCustomerSite where CustomerID < 200");
			c_grid.ItemsSource = list;
		}

		private void InsertClick(object sender, RoutedEventArgs e)
		{
			try
			{
				using TSDataDbHandle tsData = new TSDataDbHandle(GetConnectionString());
				tCustomer cust = new tCustomer() { CustomerID = 123456, CustomerName = "Test Customer" };

				tsData.Insert(cust);
				MessageBox.Show("Test Customer Added");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void UpdateClick(object sender, RoutedEventArgs e)
		{
			try
			{
				using TSDataDbHandle tsData = new TSDataDbHandle(GetConnectionString());
				tCustomer cust = tsData.Find<tCustomer>("where CustomerID = {0}", 123456);
				if (cust != null)
				{
					cust.CustomerName = "Test Customer New Name";
					tsData.Update(cust);

					c_grid.ItemsSource = tsData.Read<tCustomer>("where CustomerID = 123456");

					MessageBox.Show("Customer name changed");
				}
				else
				{
					MessageBox.Show("Customer not found");
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DeleteClick(object sender, RoutedEventArgs e)
		{
			try
			{
				using TSDataDbHandle tsData = new TSDataDbHandle(GetConnectionString());
				tCustomer cust = tsData.Find<tCustomer>("where CustomerID = {0}", 123456);
				if (cust != null)
				{
					
					tsData.Delete(cust);

					c_grid.ItemsSource = tsData.Read<tCustomer>("where CustomerID = 123456");

					MessageBox.Show("Test Customer deleted");
				}
				else
				{
					MessageBox.Show("Customer not found");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void InsertRangeClick(object sender, RoutedEventArgs e)
		{
			try
			{
				List<tCustomer> list = new List<tCustomer>();
				for (int i = 0; i <= 10; i++)
				{
					list.Add(new tCustomer() { CustomerID = 200000 + i, CustomerName = "Customer " + i.ToString() });
				}

				using TSDataDbHandle tsData = new TSDataDbHandle(GetConnectionString());
				try
				{
					tsData.BeginTransaction();
					tsData.InsertRange(list);
					tsData.Commit();
				}
				catch(Exception ex)
				{
					tsData.RollBack();
					MessageBox.Show(ex.Message);
				}
				c_grid.ItemsSource = tsData.Read<tCustomer>("where CustomerID >= 200000");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DeleteRangeClick(object sender, RoutedEventArgs e)
		{
			try
			{

				using TSDataDbHandle tsData = new TSDataDbHandle(GetConnectionString());
				var list = tsData.Read<tCustomer>("where CustomerID >= 200000");
			
				tsData.DeleteRange(list);

				c_grid.ItemsSource = tsData.Read<tCustomer>("where CustomerID >= 200000");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void UpdateRangeClick(object sender, RoutedEventArgs e)
		{
			try
			{

				using TSDataDbHandle tsData = new TSDataDbHandle(GetConnectionString());	
				var list = tsData.Read<tCustomer>("where CustomerID >= 200000");

				foreach (var cust in list)
					cust.Country = "US";
				try
				{
					tsData.BeginTransaction();
					tsData.UpdateRange(list);
					tsData.Commit();
				}
				catch (Exception ex)
				{
					tsData.RollBack();
					MessageBox.Show(ex.Message);
				}

				c_grid.ItemsSource = tsData.Read<tCustomer>("where CustomerID >= 200000");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void SaveClick(object sender, RoutedEventArgs e)
		{
			try
			{

				using TSDataDbHandle tsData = new TSDataDbHandle(GetConnectionString());
				var list = tsData.Read<tCustomer>("where CustomerID >= 200000");

				ChangeTrackableCollection<tCustomer> collection = new ChangeTrackableCollection<tCustomer>(list);

				//Change 

				collection[0].City = "Vancouter";
				
				//Delete

				collection.RemoveAt(1);

				collection.Add(new tCustomer { CustomerID = 300000, CustomerName = "Customer 300000" });

				tsData.Save(collection);

				c_grid.ItemsSource = tsData.Read<tCustomer>("where CustomerID >= 200000");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}