using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Kostishin
{
    public class LotModel
    {
        public int Lot_Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Min_Price { get; set; }

        public string To_Date { get; set; }

        public LotModel()
        {

        }

        public LotModel(string title, string desc, int price, string toDate)
        {
            this.Title = title;
            this.Description = desc;
            this.Min_Price = price;
            this.To_Date = toDate;
        }

        public override string ToString()
        {
            return "''" + this.Title + "'' " + "Мін ціна: " + this.Min_Price;
        }
    }
}
