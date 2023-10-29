using System;
using System.Collections.Generic;

[Serializable]
public class Merchant
{
    public string name;
    public string category;
    public string description;
    public List<string> pointOfSale;
}

[Serializable]
public class Transaction
{
    public string transactionUUID;
    public string accountUUID;
    public string merchantUUID;
    public Merchant merchant;
    public double amount;
    public string creditDebitIndicator;
    public string currency;
    public string timestamp;
    public string emoji;
    public double latitude;
    public double longitude;
    public string status;
    public string message;
    public string pointOfSale;
}

[Serializable]
public class TransactionList
{
    public List<Transaction> transactions;
}
