using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Transactions;
using UnityEngine;

public static class Repository
{
    public static List<Transaction> transactions;
    public static List<Account > accounts;
    public static List<Transaction> challanges;
    public static void loadData()
    {
        string transactionText = File.ReadAllText("transactions.json");
        string accountText= File.ReadAllText("accounts.json");
        string challengeText = File.ReadAllText("transactions.json");

        transactions=JsonUtility.FromJson<List<Transaction>>(transactionText);
        accounts=JsonUtility.FromJson<List<Account>>(accountText);
        challanges=JsonUtility.FromJson<List<Transaction>>(challengeText);


    }
}
