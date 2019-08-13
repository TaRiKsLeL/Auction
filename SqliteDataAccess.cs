using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Kostishin
{
    public class SqliteDataAccess
    {
        public static List<LotModel> LoadLots()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) // connection to SQlite
            {
                var output = cnn.Query<LotModel>("select * from Lots", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveLot(LotModel lot)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) // connection to SQlite
            {
                cnn.Execute("insert into Lots (Title,Description,Min_Price,To_Date) values (@Title,@Description,@Min_Price,@To_Date)", lot);
            }
        }



        public static List<CustomerModel> LoadCustomers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<CustomerModel>("select * from Customers", new DynamicParameters());
                return output.ToList();
            }
        }



        public static void SaveCustomer(CustomerModel customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Customers (Name,Login,Email,Password) values (@Name,@Login,@Email,@Password)", customer);
            }
        }

        public static List<OfferModel> LoadOffers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<OfferModel>("select * from Offers", new DynamicParameters());
                return output.ToList();
            }
        }


        public static void SaveOffer(OfferModel offer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Offers (Lot_Id,Customer_Id,Price_Offered) values (@Lot_Id,@Customer_Id,@Price_Offered)", offer);
            }
        }

        
        private static string LoadConnectionString(string id ="Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
