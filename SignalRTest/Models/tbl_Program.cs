//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SignalRTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Program
    {
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public string ProgramURL { get; set; }
        public bool IsParentProgram { get; set; }
        public Nullable<System.Guid> ParentProgramID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<System.Guid> DeletedBy { get; set; }
        public bool Active { get; set; }
    }
}