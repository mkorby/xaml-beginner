using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {
        protected override void OnDataLoaded()
        {
            this.OrderItems = base.Repository.Orders;
        }

        private List<Order> _OrderItems;
        public List<Order> OrderItems
        {
            get { return this._OrderItems; } 
            set
            {
                if (value != this._OrderItems) 
                {
                    this._OrderItems = value;
                    this.NotifyPropertyChanged();
                }

            }

        }
    }
}
