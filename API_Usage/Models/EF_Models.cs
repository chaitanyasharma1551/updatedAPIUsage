using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_Usage.Models
{
    public class Company
    {
        [Key]
        public string symbol { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public bool isEnabled { get; set; }
        public string type { get; set; }
        public string iexId { get; set; }
        public List<Equity> Equities { get; set; }
    }

    public class Equity
    {
        public int EquityId { get; set; }
        public string date { get; set; }
        public float open { get; set; }
        public float high { get; set; }
        public float low { get; set; }
        public float close { get; set; }
        public int volume { get; set; }
        public int unadjustedVolume { get; set; }
        public float change { get; set; }
        public float changePercent { get; set; }
        public float vwap { get; set; }
        public string label { get; set; }
        public float changeOverTime { get; set; }
        public string symbol { get; set; }
    }


    public class dividends
    {
        [Key]
        public string exDate { get; set; }
        public string paymentDate { get; set; }
        public string recordDate { get; set; }
        public string declaredDate { get; set; }
        public float amount { get; set; }
        public string flag { get; set; }
        public string type { get; set; }
        public string qualified { get; set; }
        public string indicated { get; set; }
    }


    public class shortinterest
    {
        
        public string SettlementDate { get; set; }
        public string SymbolinINETSymbology { get; set; }
        public string SymbolinCQSSymbology { get; set; }
        public string SymbolinCMSSymbology { get; set; }
        public string SecurityName { get; set; }
        public string CompanyName { get; set; }
        public string CurrentShortInterest { get; set; }
        public string PreviousShortInterest { get; set; }
        public string PercentChange { get; set; }
        public string AverageDailyVolume { get; set; } 
        [Key]
        public string DaystoCover { get; set; }
        public string StockAdjustmentFlag { get; set; }
        public string NewIssueFlag { get; set; }
        public string RevisionFlag { get; set; }
    }


    public class history
    {
        [Key]
        public string date { get; set; }
        public int volume { get; set; }
        public int routedVolume { get; set; }
        public float marketShare { get; set; }
        public int isHalfday { get; set; }
        public int litVolume { get; set; }
    }




    public class market
    {
        [Key]
        public string mic { get; set; }
        public string tapeId { get; set; }
        public string venueName { get; set; }
        public long volume { get; set; }
        public int tapeA { get; set; }
        public int tapeB { get; set; }
        public int tapeC { get; set; }
        public float marketPercent { get; set; }
        public long lastUpdated { get; set; }
    }



   

    public class mktperformance
    {
        public string type { get; set; }
        [Key]
        public string name { get; set; }
        public float performance { get; set; }
        public long lastUpdated { get; set; }
    }



    public class ChartRoot
    {
        public Equity[] chart { get; set; }
    }
}