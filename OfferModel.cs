using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Kostishin
{
    public class OfferModel
    {

        public int Offer_Id { get; set; }
        public int Lot_Id { get; set; }
        public int Customer_Id { get; set; }
        public int Price_Offered { get; set; }

        public OfferModel()
        {

        }

        public OfferModel(int lotId, int custId, int price)
        {
            this.Lot_Id = lotId;
            this.Customer_Id = custId;
            this.Price_Offered = price;
        }
    }
}
