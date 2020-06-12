using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBusinessRule
{
    public class Product
    {

        private ProductTypes enumProductType = ProductTypes.Undefined;
        private SubProductTypes enumSubProductType= SubProductTypes.Undefined;

        public ProductTypes ProductType
        {
            get
            {
                return enumProductType;
            }
            set
            {
                 enumProductType= value;
            }
        }

        public SubProductTypes SubProductType
        {
            get
            {
                return enumSubProductType;
            }
            set
            {
                enumSubProductType = value;
            }
        }
    }
}
