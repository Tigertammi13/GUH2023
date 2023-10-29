using System;
using System.Collections.Generic;

public class Merchant
{
    public string name { get; set; }
    public string category { get; set; }
    public string description { get; set; }
    public List<string> pointOfSale { get; set; }
}

public class Transaction
{
    public string transactionUUID { get; set; }
    public string accountUUID { get; set; }
    public string merchantUUID { get; set; }
    public Merchant merchant { get; set; }
    public double amount { get; set; }
    public string creditDebitIndicator { get; set; }
    public string currency { get; set; }
    public string timestamp { get; set; }
    public string emoji { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
    public string status { get; set; }
    public string message { get; set; }
    public string pointOfSale { get; set; }
}
