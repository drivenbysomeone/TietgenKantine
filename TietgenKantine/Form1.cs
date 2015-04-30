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


            revealTheDataMainCourse();
            revealTheDataAccessories();
            revealTheDataDrinks();


        }

        private void revealTheDataDrinks()

            // SE https://social.msdn.microsoft.com/forums/windows/en-us/1a04eeb6-51db-44e7-9522-ac5c285f05c8/grouping-radio-buttons - grouping isn't possible!
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string queryString = "SELECT * FROM Drinks;";
            DataTable dt = GetData(connectionString, queryString);
            var drinkList = new List<Drinks>();

            foreach (DataRow item in dt.Rows)
            {
                var theDrink = new Drinks();
                theDrink.Id = Convert.ToInt32(item["Id"].ToString());
                theDrink.TheDrinkName = item["DrinkName"].ToString();
                drinkList.Add(theDrink);
            }

            
            
            
        }

        private void revealTheDataMainCourse()
        {
            //solution link:
            #region 
            //http://stackoverflow.com/questions/1346132/how-do-i-extract-data-from-a-datatable
            #endregion 

            var connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string queryString = "SELECT * FROM MainCourse";
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

         //   throw new NotImplementedException();
        }

        private void revealTheDataAccessories()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            string queryString = "SELECT * FROM Tilbehør;";
            DataTable dt = GetData(connectionString, queryString);
            var extrasList = new List<Tilbehør>();

            foreach (DataRow item in dt.Rows)
            {
                var theExtras = new Tilbehør();
                theExtras.Id = Convert.ToInt32(item["Id"].ToString());
                theExtras.EkstraTilbehør = item["Ekstra Tilbehør"].ToString();
                extrasList.Add(theExtras);

            }

            lstBoxAccessories.ValueMember = "Id";
            lstBoxAccessories.DisplayMember = "EkstraTilbehør";
            lstBoxAccessories.DataSource = extrasList;

        }





        private static DataTable GetData(string connectionString, string queryString)
        {
            DataTable dt = new DataTable();
           
         
            using (var connection = new SqlConnection(connectionString))
            {

                //SqlCommand kan kun tage 1 queryString!
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);

                    // get more data and insert in other VS design tools
                }

                connection.Close();

                return dt;
                
            }



        }

        private void rdbSoda_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null)
            {
                if(radioButton.Checked)
                {
                    MessageBox.Show("d");


                }


            }


        }
    }
}