//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountManagement.Models
{
    using OanTech.Common;
    using System;
    using System.Collections.Generic;

    [Serializable()]
    public partial class RoleMenuMapping : ITimeStamp
    {
        public long RoleMenuMappingId { get; set; }
        public long RoleId { get; set; }
        public long MenuId { get; set; }
        public string UsrCrt { get; set; }
        public System.DateTime DtmCrt { get; set; }
        public string UsrUpd { get; set; }
        public System.DateTime DtmUpd { get; set; }
    
        public virtual Menu Menu { get; set; }
        public virtual Role Role { get; set; }
    }
}
