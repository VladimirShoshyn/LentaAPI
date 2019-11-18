using System;
using System.Collections.Generic;

namespace LentaAPI
{
    public class Product
    {
        public Guid ID { get; set; }
        public string VendorCode { get; set; }
        public string VendorCodeFull { get; set; }
        public string Pattern { get; set; }
        public string PatternFull { get; set; }
        public decimal Hight { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Diameter { get; set; }
        public string Name { get; set; }
        public string Desription { get; set; }
        public string Unit { get; set; }
        public string UnitOKEI { get; set; }
        public double Price { get; set; }
        public decimal VAT { get; set; }
        public string CurrencyID { get; set; }
        public int ProducePack { get; set; }
        public int TradePack { get; set; }
        public string Composition { get; set; }
        public string Photo { get; set; }
        public bool NewProduct { get; set; }
        public bool SaleProduct { get; set; }
        public bool OnStock { get; set; }
    }

    public class ProductCategories
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }

    public class ProductGroups
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public List<ProductCategories> ProductCategories { get; set; }
    }

    public class ProductSections
    {
        public int SectionID { get; set; }
        public string SectionName { get; set; }
        public List<ProductGroups> ProductGroups { get; set; }
    }
}
