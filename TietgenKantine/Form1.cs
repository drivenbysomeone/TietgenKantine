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
        static string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        List<MainCourse> dishList = new List<MainCourse>();
        List<Tilbehør> extrasList = new List<Tilbehør>();

        Drinks drinks = new Drinks();
        Tilbehør extras = new Tilbehør();
        MainCourse main = new MainCourse();
        string theWater = "";
        
        public Form1()
        {
            InitializeComponent();
            revealTheDataMainCourse();
            revealTheDataAccessories();
        }
        private void revealTheDataMainCourse()
        {
            //solution link:
            #region
            //http://stackoverflow.com/questions/1346132/how-do-i-extract-data-from-a-datatable
            #endregion
            string queryString = "SELECT * FROM MainCourse";
            DataTable dt = GetData(queryString);
            foreach (DataRow item in dt.Rows)
            {
                var main = new MainCourse();
                main.Id = Convert.ToInt32(item["Id"].ToString());
                main.Name = item["MainCourseName"].ToString();
                main.Price = Convert.ToDecimal(item["Price"].ToString());
                dishList.Add(main);
            }
            cmbDishes.ValueMember = "Id";
            cmbDishes.DisplayMember = "Name";
            cmbDishes.DataSource = dishList;
        }
        private void revealTheDataAccessories()
        {
            string queryString = "SELECT * FROM Tilbehør;";
            DataTable dt = GetData(queryString);
            foreach (DataRow item in dt.Rows)
            {
                var theExtras = new Tilbehør();
                theExtras.Id = Convert.ToInt32(item["Id"].ToString());
                theExtras.EkstraTilbehør = item["Ekstra Tilbehør"].ToString();
                theExtras.Price = Convert.ToDecimal(item["Price"].ToString());
                extrasList.Add(theExtras);
            }
            lstBoxAccessories.ValueMember = "Id";
            lstBoxAccessories.DisplayMember = "EkstraTilbehør";
            lstBoxAccessories.DataSource = extrasList;
        }

        private static DataTable GetData(string queryString)
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
                connection.Close();

                return dt;
            }
        }

        private void rdbSoda_CheckedChanged(object sender, EventArgs e)
        {
        
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null)
            {
                
                if (radioButton.Checked)
                {
                    string sql = "SELECT * FROM Drinks WHERE DrinkName = '" + radioButton.Text + "'";

                    DataTable dt = GetData(sql);
                    foreach (DataRow item in dt.Rows)
                    {
                        drinks.Id = Convert.ToInt32(item["Id"].ToString());
                        drinks.TheDrinkName = item["DrinkName"].ToString();
                        drinks.Price = Convert.ToDecimal(item["Price"].ToString());
                    }
                }
            }
        }

        private void chkBoxWater_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxWater != null)
            {
                if (chkBoxWater.Checked)
                {
                    theWater = "Free water";
                }
            }

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string order = Environment.NewLine + cmbDishes.Text + "   " + main.Price + Environment.NewLine + lstBoxAccessories.Text + "free";
            order += Environment.NewLine + drinks.TheDrinkName + "   " + drinks.Price + Environment.NewLine + theWater;
            order += Environment.NewLine + Environment.NewLine + Environment.NewLine + "Total cost:" + Environment.NewLine;
            order += Environment.NewLine + TotalCost();
            MessageBox.Show("You have ordered the following:" + order);

        }

        private string TotalCost()
        {
            decimal totalValue = main.Price + extras.Price + drinks.Price;
            return totalValue.ToString();
        }

        private void lstBoxAccessories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxAccessories.SelectedIndex != -1)
            {
                int i = lstBoxAccessories.SelectedIndex;
                extras = extrasList[i];
            }
        }

        private void cmbDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDishes.SelectedIndex != -1)
            {
                int i = cmbDishes.SelectedIndex;
                main = dishList[i];
            }
        }

        private void deleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbDishes.SelectedValue = 0;
            lstBoxAccessories.SelectedValue = 0;            
            chkBoxWater.Checked = false;
 
            this.Refresh();
            
        }
    }
}