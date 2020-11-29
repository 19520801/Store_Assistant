﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using StoreAssitant.Class_Information;

namespace StoreAssitant
{
    public class BillInfo: INotifyPropertyChanged
    {
        public int ID;
        private int number_table;
        private DateTime day;
        private int price_Bill;
        private string voucher;
        private MyList<Products> productBills;
        private int take;
        public int TOTAL
        {
            get => price_Bill + 0;
        }
        public int Give
        {
            get => Take - TOTAL;
        }
        public int Number_table { get => number_table; set => number_table = value; }
        public DateTime DAY { get => day; set => day = value; }
        public string USER_Name { get; set; }
        public int Price_Bill {
            get
            {
                return price_Bill;
            }
            set
            {
                price_Bill = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Price_Bill"));
            }
        }
        public string Voucher { 
            get => voucher;
            set
            {
                voucher = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("SaleCode"));
                //PropertiesChanged(this, new EventArgs());
            }
        }
        public MyList<Products> ProductBills { 
            get => productBills; 
            set
            {
                productBills = value;
                //InvokePropertyChanged(new PropertyChangedEventArgs("Price Customer"));
            }
        }
        public int Take { 
            get => take;
            set
            {
                take = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Price Customer"));
            }
        }


        public BillInfo() { 
            productBills = new MyList<Products>();

            PropertyChanged = new PropertyChangedEventHandler((s, e) => { });
            productBills.OnAdded += new EventHandler((s, e) => { Price_Bill = ProductBills.Sum(i => i.Price * i.NumberProduct); });
            productBills.OnRemoved += new EventHandler((s, e) => { Price_Bill = ProductBills.Sum(i => i.Price * i.NumberProduct); });
        }
        public BillInfo(int id, DateTime day, int price, string code, MyList<Products> productBills)
        {
            number_table = id;
            this.day = day;
            price_Bill = price;
            voucher = code;
            this.productBills = productBills;
            PropertyChanged = new PropertyChangedEventHandler((s, e) => { });
        }

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        #endregion
    }
}