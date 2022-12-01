using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class ProductDetailData
    {
        public ProductMain productMain { get; set; }
        public List<ProductImage> productImages { get; set; }
        public List<ProductProperty> productProperties { get; set; }
    }

    public class ProductImage
    {
        public int id { get; set; }
        public string imagePath { get; set; }
    }

    public class ProductMain
    {
        public int id { get; set; }
        public string name { get; set; }
        public string stockCode { get; set; }
        public double salePrice { get; set; }
        public string salePriceVat { get; set; }
        public double listingPrice { get; set; }
        public string listingPriceVat { get; set; }
        public double purchasePrice { get; set; }
        public double merchantPrice1 { get; set; }
        public double merchantPrice2 { get; set; }
        public double merchantPrice3 { get; set; }
        public double merchantPrice4 { get; set; }
        public double merchantPrice5 { get; set; }
        public int stock { get; set; }
        public string categoryName { get; set; }
        public string currency { get; set; }
        public string description { get; set; }
        public string saleUnit { get; set; }
        public double kdv { get; set; }
        public double unitIncrement { get; set; }
        public double discountRate { get; set; }
        public double isInFavorite { get; set; }
        public double maxSaleUnit { get; set; }
        public double minSaleUnit { get; set; }
        public double inCartQty { get; set; }
    }

    public class ProductProperty
    {
        public string barcode { get; set; }
        public string stock { get; set; }
        public double price { get; set; }
        public string variants { get; set; }
        public string ozelAlan { get; set; }
        public string gtin { get; set; }
    }

    public class StatusProductDetailData
    {
        public bool status { get; set; }
        public ProductDetailData data { get; set; }
    }
}
