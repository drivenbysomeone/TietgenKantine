using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

// SQL - notes:
// using System.Configurasion added
// using System.Data.sqlClient added
//
//The Connection string is added in App.config (see Solution Explorer)
//
//In Solution Explorer - right click References -> Add Reference -> and add the System.Configuraion; 
// 
// In Sql Server Explorer - everytime a new table has been created - look at its Id properties and set Id Identity Specification to True.


namespace TietgenKantine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
         
            var connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            string queryString = "SELECT * FROM MainCourse;";
            DataTable dt = GetData(connectionString, queryString);
            var dishList = new List<MainCourse>();
            foreach (DataRow item in dt.Rows)
            {
                 var main = new MainCourse();
                 main.Id = Convert.ToInt32(item["Id"].ToString());
                 main.Name = item["MainCourseName"].ToString();
                 dishList.Add(main);
            }
           

            cmbDishes.ValueMember = "Id";
            cmbDishes.DisplayMember = "Name";
            cmbDishes.DataSource = dishList;
        }

        private static DataTable GetData(string connectionString, string queryString)
        {
             DataTable dt = new DataTable();
            using (var connection = new SqlConnection(connectionString))
            {
               
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {           
                        dt.Load(reader);
                    // get more data and insert in other VS design tools
                }

                connection.Close();
            }
            return dt;

        }

      

    }
}
