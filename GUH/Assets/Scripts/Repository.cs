using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Transactions;
using UnityEngine;

public static class Repository
{
    public static List<Transaction> transactions;
    public static List<Account > accounts;
    public static void loadData()
    {
        string transactionText = File.ReadAllText("transactions.json");
        string accountText= File.ReadAllText("accounts.json");

        transactions=JsonUtility.FromJson<List<Transaction>>(transactionText);
        accounts=JsonUtility.FromJson<List<Account>>(accountText);

    }
}
