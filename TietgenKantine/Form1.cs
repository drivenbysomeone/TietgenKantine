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
            var list = new List<MainCourse>();
            foreach (DataRow item in dt.Rows)
            {
                 var main = new MainCourse();
                 main.Id = Convert.ToInt32(item["Id"].ToString());
                 main.Name = item["MainCourseName"].ToString();
                 list.Add(main);
            }
           

            cmbDishes.ValueMember = "Id";
            cmbDishes.DisplayMember = "Name";
            cmbDishes.DataSource = list;
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
                }
            }
            return dt;

        }
    }
}
