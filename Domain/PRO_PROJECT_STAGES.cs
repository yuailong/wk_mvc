//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRO_PROJECT_STAGES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRO_PROJECT_STAGES()
        {
            this.PRO_PROJECT_TEAMS = new HashSet<PRO_PROJECT_TEAMS>();
        }
    
        public int ID { get; set; }
        public int FK_ProjectId { get; set; }
        public string StageTitle { get; set; }
        public int NeedNumber { get; set; }
        public int StageTimeLimit { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int StageStatus { get; set; }
        public bool IsOverTime { get; set; }
        public int OverDays { get; set; }
        public int OrderNumber { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public System.DateTime UpdateDate { get; set; }
    
        public virtual PRO_PROJECTS PRO_PROJECTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRO_PROJECT_TEAMS> PRO_PROJECT_TEAMS { get; set; }
    }
}