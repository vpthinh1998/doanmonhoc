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
    
    public partial class NEWS
    {
        public int IdNews { get; set; }
        public string NewsTitle { get; set; }
        public string NewsSumary { get; set; }
        public string NewsDetail { get; set; }
        public string NewsThumbail { get; set; }
        public int IdCategory { get; set; }
        public Nullable<int> IdUser { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
    
        public virtual CATEGORY_NEWS CATEGORY_NEWS { get; set; }
        public virtual USER USER { get; set; }
    }
}
