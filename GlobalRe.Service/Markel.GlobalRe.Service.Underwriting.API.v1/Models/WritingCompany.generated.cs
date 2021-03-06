﻿// Template: Models (ApiModel.t4) version 3.0

// This code was generated by RAML Server Scaffolder

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Markel.GlobalRe.Service.Underwriting.API.v1.Models
{
    public partial class WritingCompany
    {
        [Required]
        [JsonProperty("paperNum")]
        public int Papernum { get; set; } // papernum

        [JsonProperty("companyName")]
        public string Companyname { get; set; } // companyname

        [JsonProperty("cpnum")]
        public int? Cpnum { get; set; } // cpnum

        [JsonProperty("addr1")]
        public string Addr1 { get; set; } // addr1

        [JsonProperty("addr2")]
        public string Addr2 { get; set; } // addr2

        [JsonProperty("addr3")]
        public string Addr3 { get; set; } // addr3

        [JsonProperty("city")]
        public string City { get; set; } // city

        [JsonProperty("state")]
        public string State { get; set; } // state

        [JsonProperty("postalCode")]
        public string Postalcode { get; set; } // postalcode

        [JsonProperty("country")]
        public string Country { get; set; } // cty

        [JsonProperty("phone")]
        public string Phone { get; set; } // phone

        [JsonProperty("fax")]
        public string Fax { get; set; } // fax

        [JsonProperty("imageFilename")]
        public string Imagefilename { get; set; } // imagefilename

        [JsonProperty("companyShortname")]
        public string CompanyShortname { get; set; } // company_shortname

        [JsonProperty("SLTrequired")]
        public byte? SlTrequired { get; set; } // SLTrequired

        [JsonProperty("IPTrequired")]
        public byte? IpTrequired { get; set; } // IPTrequired

        [JsonProperty("territory")]
        public int? Territory { get; set; } // Territory

        [JsonProperty("currency")]
        public int? Currency { get; set; } // Currency

        [JsonProperty("active")]
        public byte Active { get; set; } // active

        [JsonProperty("closeDate")]
        public DateTime CloseDate { get; set; } // CloseDate

        [JsonProperty("restrictDate")]
        public DateTime RestrictDate { get; set; } // RestrictDate

        [JsonProperty("paperToken")]
        public string PaperToken { get; set; } // paper_token

        [JsonProperty("rptLastCloseDate")]
        public DateTime? RptLastCloseDate { get; set; } // RptLastCloseDate

        [JsonProperty("hideUnusedClaimCategory")]
        public bool HideUnusedClaimCategory { get; set; } // HideUnusedClaimCategory

        [JsonProperty("complianceCloseDate")]
        public DateTime? ComplianceCloseDate { get; set; } // ComplianceCloseDate

        [JsonProperty("rptLastComplianceCloseDate")]
        public DateTime? RptLastComplianceCloseDate { get; set; } // RptLastComplianceCloseDate

        [JsonProperty("outwardCloseDate")]
        public DateTime? OutwardCloseDate { get; set; } // OutwardCloseDate

        [JsonProperty("outwardRestrictDate")]
        public DateTime? OutwardRestrictDate { get; set; } // OutwardRestrictDate

        [JsonProperty("rptLastOutwardCloseDate")]
        public DateTime? RptLastOutwardCloseDate { get; set; } // RptLastOutwardCloseDate

        [JsonProperty("JECode")]
        public string JeCode { get; set; } // JECode

        [JsonProperty("claimsCloseDate")]
        public DateTime? ClaimsCloseDate { get; set; } // ClaimsCloseDate

        [JsonProperty("rptLastClaimsCloseDate")]
        public DateTime? RptLastClaimsCloseDate { get; set; } // RptLastClaimsCloseDate

        [JsonProperty("rptExclude")]
        public bool RptExclude { get; set; } // RptExclude

        [JsonProperty("rptJE")]
        public string RptJe { get; set; } // RptJE

        [JsonProperty("companyPrintName")]
        public string CompanyPrintName { get; set; } // companyPrintName

        [JsonProperty("assumedFlag")]
        public int? AssumedFlag { get; set; } // AssumedFlag

        [JsonProperty("assumedSortOrder")]
        public string AssumedSortOrder { get; set; } // AssumedSortOrder

        [JsonProperty("cededFlag")]
        public int? CededFlag { get; set; } // CededFlag

        [JsonProperty("cededSortOrder")]
        public string CededSortOrder { get; set; } // CededSortOrder

        
    }
}