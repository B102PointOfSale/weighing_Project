//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weighing.Setting.Models
{
    using OanTech.Common;
    using System;
    using System.Collections.Generic;

    public partial class GeneralSetting : ITimeStamp
    {
        public long GeneralSettingId { get; set; }
        public string GSCode { get; set; }
        public string GSKey { get; set; }
        public string GSValue { get; set; }
        public string UsrCrt { get; set; }
        public System.DateTime DtmCrt { get; set; }
        public string UsrUpd { get; set; }
        public System.DateTime DtmUpd { get; set; }
    }
}
