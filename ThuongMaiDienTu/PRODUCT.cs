//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThuongMaiDienTu
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            this.COMMENT_PRODUCT = new HashSet<COMMENT_PRODUCT>();
            this.COMMENT_PRODUCT1 = new HashSet<COMMENT_PRODUCT>();
            this.PRODUCT_IMG = new HashSet<PRODUCT_IMG>();
            this.PRODUCT_INFO = new HashSet<PRODUCT_INFO>();
            this.PRODUCT_INFO1 = new HashSet<PRODUCT_INFO>();
            this.PRODUCT_ORDER = new HashSet<PRODUCT_ORDER>();
            this.PRODUCT_ORDER1 = new HashSet<PRODUCT_ORDER>();
            this.PRODUCT_PROMOTION = new HashSet<PRODUCT_PROMOTION>();
            this.PRODUCT_PROMOTION1 = new HashSet<PRODUCT_PROMOTION>();
            this.REVIEW_PRODUCT = new HashSet<REVIEW_PRODUCT>();
            this.REVIEW_PRODUCT1 = new HashSet<REVIEW_PRODUCT>();
        }
    
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public string ProductSumary { get; set; }
        public string ProductDetail { get; set; }
        public double ProductPrice { get; set; }
        public int IdCategory { get; set; }
        public int IdUser { get; set; }
    
        public virtual CATEGORY_PRODUCT CATEGORY_PRODUCT { get; set; }
        public virtual CATEGORY_PRODUCT CATEGORY_PRODUCT1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENT_PRODUCT> COMMENT_PRODUCT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENT_PRODUCT> COMMENT_PRODUCT1 { get; set; }
        public virtual USER USER { get; set; }
        public virtual USER USER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT_IMG> PRODUCT_IMG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT_INFO> PRODUCT_INFO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT_INFO> PRODUCT_INFO1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT_ORDER> PRODUCT_ORDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT_ORDER> PRODUCT_ORDER1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT_PROMOTION> PRODUCT_PROMOTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT_PROMOTION> PRODUCT_PROMOTION1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REVIEW_PRODUCT> REVIEW_PRODUCT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REVIEW_PRODUCT> REVIEW_PRODUCT1 { get; set; }
    }
}
