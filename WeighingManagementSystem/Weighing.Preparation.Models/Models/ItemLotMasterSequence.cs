﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weighing.Preparation.Models
{
    using OanTech.Common;
    using System;
    using System.Collections.Generic;

    public partial class ItemLotMasterSequence : ITimeStamp
    {
        public long ID { get; set; }
        public string ItemCode { get; set; }
        public string LotNo { get; set; }
        public System.DateTime ExecutionDate { get; set; }
        public int Length { get; set; }
        public int Seq { get; set; }
        public string UsrCrt { get; set; }
        public System.DateTime DtmCrt { get; set; }
        public string UsrUpd { get; set; }
        public System.DateTime DtmUpd { get; set; }
    }
}
