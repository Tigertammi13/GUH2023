using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Transactions;
using UnityEngine;

public static class Repository
{
    public static TransactionList transactions;
    public static List<Account > accounts;
    public static List<Transaction> challanges;
    public static void loadData()
    {
        string transactionText = "[{" +
        "\"transactionUUID\": \"0641a151-03ef-48ac-9c42-e566dd747a60\"," +
        "\"accountUUID\": \"20360206\"," +
        "\"merchantUUID\": \"4\"," +
        "\"merchant\": {" +
            "\"name\": \"Pear Retail\"," +
            "\"category\": \"Shopping\"," +
            "\"description\": \"Computers, phones and other shiny electrical things\"," +
            "\"pointOfSale\": [" +
                "\"Online\"," +
                "\"In-store\"" +
            "]" +
        "}," +
        "\"amount\": -201.29," +
        "\"creditDebitIndicator\": \"Debit\"," +
        "\"currency\": \"GBP\"," +
        "\"timestamp\": \"2023-07-22 14:22:48\"," +
        "\"emoji\": \"😭\"," +
        "\"latitude\": 52.86109314048868," +
        "\"longitude\": -1.8728627784523362," +
        "\"status\": \"Declined\"," +
        "\"message\": \"Weekly wage of 201.29 (GBP, positive) from Pear Retail\"," +
        "\"pointOfSale\": \"In-store\"" +
    "}]";
        string accountText= File.ReadAllText("Assets/Scripts/accounts.json");
        string challengeText = File.ReadAllText("Assets/Scripts/transactions.json");

        //string transactionText= "[\r\n        {\r\n            \"transactionUUID\": \"0641a151-03ef-48ac-9c42-e566dd747a60\",\r\n            \"accountUUID\": \"20360206\",\r\n            \"merchantUUID\": \"4\",\r\n            \"merchant\": {\r\n                \"name\": \"Pear Retail\",\r\n                \"category\": \"Shopping\",\r\n                \"description\": \"Computers, phones and other shiny electrical things\",\r\n                \"pointOfSale\": [\r\n                    \"Online\",\r\n                    \"In-store\"\r\n                ]\r\n            },\r\n            \"amount\": -201.29,\r\n            \"creditDebitIndicator\": \"Debit\",\r\n            \"currency\": \"GBP\",\r\n            \"timestamp\": \"2023-07-22 14:22:48\",\r\n            \"emoji\": \"😭\",\r\n            \"latitude\": 52.86109314048868,\r\n            \"longitude\": -1.8728627784523362,\r\n            \"status\": \"Declined\",\r\n            \"message\": \"Weekly wage of 201.29 (GBP, positive) from Pear Retail\",\r\n            \"pointOfSale\": \"In-store\"\r\n        }]";
        transactions =JsonUtility.FromJson<TransactionList>(transactionText);
        Debug.Log(transactions.transactions[0].accountUUID);
        accounts=JsonUtility.FromJson<List<Account>>(accountText);
        Debug.Log(accounts.Count);
        challanges =JsonUtility.FromJson<List<Transaction>>(challengeText);


    }
}
