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
using System.IO;
using System.Data.SqlClient;
using System.Data;
using EntityToDB;
namespace EGen
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private string m_server = "";
		private string m_username = "";
		private string m_password = "";

		public MainWindow()
		{
			InitializeComponent();
		}

		private void SelectSqlServerClick(object sender, RoutedEventArgs e)
		{
			var dlg = new SelectSqlServerWin();
			dlg.Owner = this;

			if (dlg.ShowDialog() != true)
				return;


			m_server = dlg.Server;
			m_username = dlg.UserName;
			m_password = dlg.Password;

			c_sqlServer.Text = m_server;
			c_dbList.Items.Clear();

			try
			{
				using (SqlConnection db = new SqlConnection(DbUtil.GetConnectionString(m_server, m_username, m_password, "Master")))
				{
					db.Open();
					DataTable table = db.GetSchema("Databases");
					foreach (DataRow row in table.Rows)
					{
						c_dbList.Items.Add(row["database_name"]);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void GenerateClick(object sender, RoutedEventArgs e)
		{

			try
			{
				string dbName = c_dbList.SelectedItem as string;

				DbScripter dbScriper = new DbScripter();

				string connectionString = DbUtil.GetConnectionString(m_server, m_username, m_password, dbName);

				ODatabase database = dbScriper.ScriptDatabase(connectionString);


				DbModelGenerator dbModelGenerator = new DbModelGenerator();
				(string contextFile, string modelFile)  = dbModelGenerator.GenerateAll(database);

				string schemaFile = database.DBName + "Schema.txt";
				dbScriper.Save(database, schemaFile);

				c_contextFile.Text  = File.ReadAllText(contextFile);
				c_modelFile.Text = File.ReadAllText(modelFile);
				c_schemaFile.Text = File.ReadAllText(schemaFile);

				MessageBox.Show(string.Format("Generated:\n\n{0}\n{1}\n{2}", contextFile, modelFile, schemaFile));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void CopyContextClick(object sender, RoutedEventArgs e)
		{
			Clipboard.SetText(c_contextFile.Text);
		}

		private void CopyModelClick(object sender, RoutedEventArgs e)
		{
			Clipboard.SetText(c_modelFile.Text);
		}

		private void CopySchemaClick(object sender, RoutedEventArgs e)
		{
			Clipboard.SetText(c_schemaFile.Text);
		}

		private void MigrateDatabaseClick(object sender, RoutedEventArgs e)
		{
			try
			{

				DbScripter dbScriper = new DbScripter();
				ODatabase database = dbScriper.Parse(c_schemaFile.Text);
				string connectionString = DbUtil.GetConnectionString(m_server, m_username, m_password, database.DBName);
				dbScriper.Migrate(connectionString,  database);

				MessageBox.Show("Migrated");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		
		}
	}
}
