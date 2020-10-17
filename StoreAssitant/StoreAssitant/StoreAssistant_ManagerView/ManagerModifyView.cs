﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAssitant
{
    public partial class ManagerModifyView : UserControl
    {
        public ManagerModifyView()
        {
            InitializeComponent();
            InitializeEventHandler();
        }

        internal void LoadDataFromDB()
        {
            using (DatabaseController databaseController = new DatabaseController())
            {
                databaseController.ConnectToSQLDatabase();
                tableView1.SetData(databaseController.GetTableCount());
                menuView1.SetData(databaseController.GetProductInfos2());
            }
        }

        void InitializeEventHandler()
        {
            menuView1.ClickAddButton += MenuView1_ClickAddButton;
            
            tableView1.TableRemoved += TableView1_UpdateNumber;
            tableView1.TableAdded += TableView1_UpdateNumber;
        }

        private void TableView1_UpdateNumber(object sender, EventArgs e)
        {
            TableView tableView = (TableView)sender;

            using (DatabaseController databaseController = new DatabaseController())
            {
                databaseController.ConnectToSQLDatabase();
                databaseController.UpdateTableCount(tableView.NumberTable);
            }
        }

        private void MenuView1_ClickAddButton(object sender, EventArgs e)
        {
            OpenAddProductDialog();
        }

        private void OpenAddProductDialog()
        {
            using (AddProductForm form = new AddProductForm())
            {
                form.ClickSubmitOK += new EventHandler<ProductInfo>((object sender, ProductInfo info) =>
                {
                    using (DatabaseController databaseController = new DatabaseController())
                    {
                        databaseController.InsertProduct(info);
                        menuView1.AddMenuControl(info);
                        //MessageBox.Show("Click On a product" + Environment.NewLine + info.ToString());
                    }
                });
                form.ShowDialog();
            }
        }
    }
}