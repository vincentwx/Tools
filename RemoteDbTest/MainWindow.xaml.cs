using System;
using System.Collections.Generic;
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
using CommonLibrary;
using TSDataModel;
namespace RemoteDbTest
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		private AppConnector m_connector;

		public MainWindow()
		{
			InitializeComponent();
			m_connector = new AppConnector();
			m_connector.ServerHost = "http://localhost:5018";

		}

		private async void ReadClick(object sender, RoutedEventArgs e)
		{
			try
			{
				var list = await m_connector.ReadAsync<tCustomer>("where Country = {0}", "US");
				c_grid.ItemsSource = list;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private async void ReadTypeClick(object sender, RoutedEventArgs e)
		{

	

		}
		private void FindClick(object sender, RoutedEventArgs e)
		{
	
		}

		private void FindTypeClick(object sender, RoutedEventArgs e)
		{
	
		}

		private async void QueryClick(object sender, RoutedEventArgs e)
		{
			try
			{

				
				var list = await m_connector.QueryAsync<vCustomerSite>("select * from vCustomerSite where CustomerID < {0}", 200);
				c_grid.ItemsSource = list;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.GetDescription());
			}

		}



		private async void InsertClick(object sender, RoutedEventArgs e)
		{
			try
			{
				
				tCustomer cust = new tCustomer() { CustomerID = 123456, CustomerName = "Test Customer" };
				await m_connector.InsertAsync(cust);
				MessageBox.Show("Test Customer Added");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private async void UpdateClick(object sender, RoutedEventArgs e)
		{
			try
			{
				
				tCustomer cust = await m_connector.FindAsync<tCustomer>("where CustomerID = {0}", 123456);
				if (cust != null)
				{
					cust.CustomerName = "Test Customer New Name";
					m_connector.Update(cust);

					c_grid.ItemsSource = await m_connector.ReadAsync<tCustomer>("where CustomerID = 123456");

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

		private async void DeleteClick(object sender, RoutedEventArgs e)
		{
			try
			{
				
				tCustomer cust = await m_connector.FindAsync<tCustomer>("where CustomerID = {0}", 123456);
				if (cust != null)
				{

					await m_connector.DeleteAsync(cust);

					c_grid.ItemsSource = await m_connector.ReadAsync<tCustomer>("where CustomerID = 123456");

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

		private async void InsertRangeClick(object sender, RoutedEventArgs e)
		{
			try
			{
				List<tCustomer> list = new List<tCustomer>();
				for (int i = 0; i <= 10; i++)
				{
					list.Add(new tCustomer() { CustomerID = 200000 + i, CustomerName = "Customer " + i.ToString() });
				}

				
				try
				{
					
					await m_connector.InsertRangeAsync(list);
					
				}
				catch (Exception ex)
				{
				
					MessageBox.Show(ex.Message);
				}
				c_grid.ItemsSource = await m_connector.ReadAsync<tCustomer>("where CustomerID >= 200000");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private async void DeleteRangeClick(object sender, RoutedEventArgs e)
		{
			try
			{

				
				var list =  await m_connector.ReadAsync<tCustomer>("where CustomerID >= 200000");

				await m_connector.DeleteRangeAsync(list);

				c_grid.ItemsSource = await m_connector.ReadAsync<tCustomer>("where CustomerID >= 200000");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private async void UpdateRangeClick(object sender, RoutedEventArgs e)
		{
			try
			{			
				var list = await m_connector.ReadAsync<tCustomer>("where CustomerID >= 200000");

				foreach (var cust in list)
					cust.Country = "US";
				try
				{
					await m_connector.UpdateRangeAsync(list);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				c_grid.ItemsSource = await m_connector.ReadAsync<tCustomer>("where CustomerID >= 200000");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private async void SaveClick(object sender, RoutedEventArgs e)
		{
			try
			{

				
				var list = m_connector.Read<tCustomer>("where CustomerID >= 200000");

				ChangeTrackableCollection<tCustomer> collection = new ChangeTrackableCollection<tCustomer>(list);

				//Change 

				collection[0].City = "Vancouter";

				//Delete

				collection.RemoveAt(1);

				collection.Add(new tCustomer { CustomerID = 300000, CustomerName = "Customer 300000" });

				await m_connector.SaveAsync(collection);

				c_grid.ItemsSource = m_connector.Read<tCustomer>("where CustomerID >= 200000");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void EchoClick(object sender, RoutedEventArgs e)
		{

			AppRequest req = new AppRequest();
			req.RequestCode = "Echo";
			req.Set("Content", "Hello");

			try
			{
				AppResponse rsp = m_connector.Send(req);

				string s = rsp.Get<string>("Content");
				MessageBox.Show(s);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
