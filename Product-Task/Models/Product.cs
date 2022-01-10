using Product_Task.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Task.Models
{
    class Product
    {
        private static int _counter = 1000;
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
        public ProductType ProductType { get; set; }
        private static int _totalCount = 0;

        public Product(string name, double price, ProductType productType, double discountedPrice = 0)
        {
            _counter++;
            _totalCount++;

            Name = name;
            ProductType = productType;

            if (ProductType == ProductType.Bakery)
            {
                discountedPrice = 10;
                DiscountedPrice = discountedPrice;
            }
            else
            {
                DiscountedPrice = discountedPrice;
            }

            Price = price - (price * (discountedPrice / 100));

            switch ((int)ProductType)
            {
                case (int)ProductType.Bakery:
                    Code = "B" + _counter;
                    break;
                case (int)ProductType.Drink:
                    Code = "D" + _counter;
                    break;
                case (int)ProductType.Meat:
                    Code = "M" + _counter;
                    break;
                case (int)ProductType.Fish:
                    Code = "F" + _counter;
                    break;
            }
        }

        public override string ToString()
        {
            if (DiscountedPrice == 0)
            {
                return $"Mehsul adi: {Name}\nMehsulun qiymeti: {Price}\nMehsulun tipi: {ProductType}\nMehsulun kodu: {Code}";
            }

            return $"Mehsul adi: {Name}\nMehsulun qiymeti: {Price} ({DiscountedPrice}% endirim)\nMehsulun tipi: {ProductType}\nMehsulun kodu: {Code}";
        }
    }
}
