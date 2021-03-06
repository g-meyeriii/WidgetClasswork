﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetClasswork {
    

        public enum ModelType { Bronse, Silver, Gold };

        public class Product {

            public string Code { get; set; }
            public string Name { get; set; }
            public ModelType Model { get; set; }

            public string GetStateName() {
            var stateName = "";
            switch(Model){ //Older version of the switch statement probably the most used, wholly not used often 
                case ModelType.Gold:
                    stateName = "Ohio"; break;
                case ModelType.Silver:
                    stateName = "Indiana"; break;
                case ModelType.Bronse:
                    stateName = "Kentucky"; break;
                default:
                    stateName = "Not found"; break;
            }
            return stateName;
        }

            public double GetPrice() {
                return Model switch //New version of switch, limited 
                {
                    ModelType.Bronse => 20,
                    ModelType.Silver => 90,
                    ModelType.Gold => 500,
                    _ => 0 // everything else
                };
            }
            public string GetModelName() {
            return Model switch
            {
                ModelType.Bronse => "Bronse Widget",
                ModelType.Silver => "Silver Widget",
                ModelType.Gold => "Gold Widget",
                _ => "Not found"
            };
            }

            public Product() { }
        }
}
