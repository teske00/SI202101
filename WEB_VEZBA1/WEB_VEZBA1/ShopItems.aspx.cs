using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB_VEZBA1.Models;

namespace WEB_VEZBA1
{
    public partial class ShopItems : System.Web.UI.Page
    {

        private string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ShopItem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshItems();
        }

        public void refreshItems()
        {
            List<ShopItem> shopItems = getAllItems();
            items_list.Items.Clear();

            foreach(ShopItem item in shopItems)
            {
                items_list.Items.Add(String.Format(item.ItemName));
            }
        }


        public List<ShopItem> getAllItems()
        {
            List<ShopItem> ls = new List<ShopItem>();
            using (SqlConnection sqlConnection = new SqlConnection(this.connString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM ShopItem";

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                while (sqlReader.Read())
                {
                    ShopItem s1 = new ShopItem();

                    s1.Id = sqlReader.GetInt32(0);
                    s1.ItemName = sqlReader.GetString(1);
                    s1.ItemDescription = sqlReader.GetString(2);
                    s1.ItemPrice = sqlReader.GetDecimal(3);
                    s1.ItemCategory = sqlReader.GetString(4);
                    s1.ItemDiscount = sqlReader.GetBoolean(5);

                    ls.Add(s1);
                }
            }

            return ls;

        }
    }
}