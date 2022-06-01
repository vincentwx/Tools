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
			m_connector.ServerHost = "http://localhost:2015";
		}

		private void ReadClick(object sender, RoutedEventArgs e)
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

		private void ReadTypeClick(object sender, RoutedEventArgs e)
		{
	
		}
		private void FindClick(object sender, RoutedEventArgs e)
		{
	
		}

		private void FindTypeClick(object sender, RoutedEventArgs e)
		{
	
		}

		private void QueryClick(object sender, RoutedEventArgs e)
		{
			try
			{
				

				var list = m_connector.Query<tCustomer>("select * from TCustomer where AccountID < {0} and Country = {1}", 300, "US");

				//var list = m_connector.Query<tCustomer>("select top 10 * from tCustomer");


				//int deptID = 1;
				//var list = connector.Read<TEmployee>("where DeptID = {0}", deptID);

				MessageBox.Show("OK");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.GetDescription());
			}

		}

		private void InsertClick(object sender, RoutedEventArgs e)
		{

		}
		private void UpdateClick(object sender, RoutedEventArgs e)
		{
	
		}

		private void DeleteClick(object sender, RoutedEventArgs e)
		{
	

		}

		private void InsertRangeClick(object sender, RoutedEventArgs e)
		{

		}

		private void DeleteRangeClick(object sender, RoutedEventArgs e)
		{

		}

		private void UpdateRangeClick(object sender, RoutedEventArgs e)
		{

		}

		private void SaveClick(object sender, RoutedEventArgs e)
		{

		}
	}
}
