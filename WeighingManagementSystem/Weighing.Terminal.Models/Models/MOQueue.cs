//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weighing.Terminal.Models
{
    using OanTech.Common;
    using System;
    using System.Collections.Generic;

    public partial class MOQueue : ITimeStamp
    {
        public long MOQueueId { get; set; }
        public string MoNumber { get; set; }
        public System.DateTime ExecuteDate { get; set; }
        public bool IsPriority { get; set; }
        public string Status { get; set; }
        public string UsrCrt { get; set; }
        public System.DateTime DtmCrt { get; set; }
        public string UsrUpd { get; set; }
        public System.DateTime DtmUpd { get; set; }
    }
}