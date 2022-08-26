using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopOrganizer
{
    public partial class ProductsScreen : Form
    {
        // Datenbankverbindungsinformationen
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = T-999-MW\SQLEXPRESS; Initial Catalog = ShopOrganizerDB; User ID = sa; Password=***********");


        public ProductsScreen()
        {
            InitializeComponent();

            // Start der Verbindung nmit der Datenbank
            // Wenn man eine Verbindung opened muss man sie später auch wieder closen!!
            databaseConnection.Open();
            databaseConnection.Close();
        }

        private void ProductsScreen_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text;
            // save productName in database
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
