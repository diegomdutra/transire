//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransireWebStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int prod_id { get; set; }
        public string prod_name { get; set; }
        public string prod_description { get; set; }
        public decimal prod_price { get; set; }
        public string prod_img_path { get; set; }
        public int prod_cat_id { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
