//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductManagement.Data
{
    using System;
    using System.Collections.Generic;

    public partial class ProductFeature : EntityBase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string FeatureName { get; set; }
        public string FeatureValue { get; set; }
        public string Description { get; set; }
        public int ShowOrder { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
