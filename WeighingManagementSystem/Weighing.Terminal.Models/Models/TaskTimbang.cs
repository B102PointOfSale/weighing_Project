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

    public partial class TaskTimbang : ITimeStamp
    {
        public long TaskTimbangId { get; set; }
        public string Barcode { get; set; }
        public long OracleHeaderId { get; set; }
        public int Seq { get; set; }
        public string BagNo { get; set; }
        public string ItemCode { get; set; }
        public decimal Weight { get; set; }
        public string LotNo { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public string NewLotNo { get; set; }
        public System.DateTime NewExpirationDate { get; set; }
        public string Type { get; set; }
        public bool IsAllergen { get; set; }
        public bool IsTimbang { get; set; }
        public string TerminalId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> ExecuteDate { get; set; }
        public string Status { get; set; }
        public string UsrCrt { get; set; }
        public System.DateTime DtmCrt { get; set; }
        public string UsrUpd { get; set; }
        public System.DateTime DtmUpd { get; set; }

        public virtual OracleHeader OracleHeader { get; set; }
    }
}
