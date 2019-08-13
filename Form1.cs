using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auction_Kostishin
{
    public partial class Form1 : Form
    {

        public CustomerModel currCustomer;

        LotModel currLot;
        List<LotModel> lots = new List<LotModel>();
        List<OfferModel> offers = new List<OfferModel>();
        public Form1()
        {
            InitializeComponent();
        }
        
        public void ReloadData()
        {
            if (currCustomer != null)
            {
                plzLogIn.Visible = false;

                label1.Text = "Вітаю, " + currCustomer.Name;
                logInBtn.Visible = false;
                logOutBtn.Visible = true;
                LotsDataGrid.Visible = true;

                lots=SqliteDataAccess.LoadLots();
                LotsDataGrid.DataSource = lots;

                if (currCustomer.Login.Equals("admin"))
                {
                    userGroupBox.Visible = false;
                    filterGroupBox.Visible = false;
                    adminGroupBox.Visible = true;
                    offersDataGroupBox.Visible = true;

                    offers = SqliteDataAccess.LoadOffers();
                    offersDataGrid.DataSource = offers;
                    comboBox2.SelectedItem = comboBox2.Items[0];
                }
                else
                {
                    userGroupBox.Visible = true;
                    filterGroupBox.Visible = true;
                    adminGroupBox.Visible = false;
                    offersDataGroupBox.Visible = false;
                }
            }
            else
            {
                plzLogIn.Visible = true;

                logInBtn.Visible = true;
                logOutBtn.Visible = false;
                adminGroupBox.Visible = false;
                offersDataGroupBox.Visible = false;
                userGroupBox.Visible = false;
                filterGroupBox.Visible = false;
                LotsDataGrid.Visible = false;
                label1.Text = "";
            }
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            (new RegistrationLoginForm(this)).ShowDialog();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            currCustomer = null;
            ReloadData();
        }

        private void addToLots_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.SaveLot(new LotModel(lotTitleTextBox.Text, lotDescrTextBox.Text, Convert.ToInt32(lotMinPriceTextBox.Text), dateTimePicker1.Value.ToString("yyyy/MM/dd")));
            MessageBox.Show("Нову позицію створено");

            ReloadData();
            lotTitleTextBox.Text = "";
            lotDescrTextBox.Text = "";
            lotMinPriceTextBox.Text = "";

        }

        private void makeOfferBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(offeredPrice.Text) > currLot.Min_Price)
            {
                SqliteDataAccess.SaveOffer(new OfferModel(currLot.Lot_Id, currCustomer.Customer_Id, Convert.ToInt32(offeredPrice.Text)));

                MessageBox.Show("Ставка прийнята!!!");
            }
            else
            {
                MessageBox.Show("Предложена сума менше заявленої!!!");
            }
        }

        private void LotsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (LotsDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    currLot = (LotModel)LotsDataGrid.CurrentRow.DataBoundItem; //Отрмую нажату книгу
                    lotSelectedLabel.Text = "Вибраний лот: " + currLot;

                }
            }
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            BindingList<LotModel> myObjList = new BindingList<LotModel>(lots);


            if (comboBox1.Text.Equals("Title"))
            {

                BindingList<LotModel> filtered = new BindingList<LotModel>(myObjList.Where(obj => obj.Title.Contains(filterTextBox.Text)).ToList());
                LotsDataGrid.DataSource = filtered;
                LotsDataGrid.Update();
            }
            else if (comboBox1.Text.Equals("Description"))
            {
                BindingList<LotModel> filtered = new BindingList<LotModel>(myObjList.Where(obj => obj.Description.Contains(filterTextBox.Text)).ToList());
                LotsDataGrid.DataSource = filtered;
                LotsDataGrid.Update();
            }
            else if (comboBox1.Text.Equals("Min_Price"))
            {
                BindingList<LotModel> filtered = new BindingList<LotModel>(myObjList.Where(obj => obj.Min_Price.ToString().Contains(filterTextBox.Text)).ToList());
                LotsDataGrid.DataSource = filtered;
                LotsDataGrid.Update();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                var source = new BindingSource();
                source.DataSource = GetOffersOutOfDate(offers,lots);
                offersDataGrid.DataSource = source;
            }
            else
            {
                offersDataGrid.DataSource = offers;
            }
        }

        public List<OfferModel> GetOffersOutOfDate(List<OfferModel> offerModels,List<LotModel> lotModels)
        {
            List<OfferModel> tempListOffers = new List<OfferModel>();

            foreach(OfferModel offer in offerModels)
            {
                LotModel temoLot = lotModels.Find(item => item.Lot_Id == offer.Lot_Id);

                DateTime lotDate = DateTime.Parse(temoLot.To_Date);
                DateTime dateNow = DateTime.Now;

                if (lotDate <= dateNow)
                {
                    tempListOffers.Add(offer);
                }

            }
            return tempListOffers;
        }

    }
}
