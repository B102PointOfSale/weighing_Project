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
    public partial class User : ITimeStamp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.UserRoleMappings = new HashSet<UserRoleMapping>();
        }
    
        public long UserId { get; set; }
        public string UserLoginCode { get; set; }
        public string UserLoginPin { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public bool IsActive { get; set; }
        public bool IsLogin { get; set; }
        public string UsrCrt { get; set; }
        public System.DateTime DtmCrt { get; set; }
        public string UsrUpd { get; set; }
        public System.DateTime DtmUpd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRoleMapping> UserRoleMappings { get; set; }
    }
}
