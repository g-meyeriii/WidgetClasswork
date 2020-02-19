using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetClasswork {
    class GoldWidget : IProduct {
        //Properties

        public Product Product { get; set; }
                     
        public string GetModelName() {
            return Product.GetModelName();

        }
        public string GetStateName() {
            return Product.GetStateName();
        }
            public double GetPrice() {
            return Product.GetPrice();
        }

        public string GetStateNeme() {
            throw new NotImplementedException();
        }

        //Default Constructor
        public GoldWidget() {
            Product = new Product {
                Code = "GW",
                Name = "Gold Widget",
                Model = ModelType.Gold
            };
        }
    }
}
