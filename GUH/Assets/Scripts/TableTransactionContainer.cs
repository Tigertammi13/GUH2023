using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TableTransactionContainer: MonoBehaviour
{
    // Start is called before the first frame update
    int number;
    List<GameObject> columns;
   
    void start()
    {
        Repository.loadData();
        number = 0;
        columns = new List<GameObject>();
        for (int i = 0; i < gameObject.transform.childCount; i++)
            columns.Add(gameObject.transform.GetChild(i).gameObject);
        
    }
    

    // Update is called once per frame
   void appear()
    {
        this.gameObject.SetActive(true);

    }

    void hide()
    {
        this.gameObject.SetActive(false);
    }

    void clearTable()
    {
        columns[0].GetComponent<TextMeshPro>().text = "Merchant";
        columns[1].GetComponent<TextMeshPro>().text = "Amount";
        columns[2].GetComponent<TextMeshPro>().text = "Currency";
        columns[3].GetComponent<TextMeshPro>().text = "Date";
    }

    void addTransaction(Transaction transaction) {
        columns[0].GetComponent<TextMeshPro>().text+="\n" + transaction.merchant.name;
        columns[1].GetComponent<TextMeshPro>().text+="\n" + transaction.amount.ToString();
        columns[2].GetComponent<TextMeshPro>().text+="\n" + transaction.currency;
        columns[3].GetComponent<TextMeshPro>().text+="\n" + transaction.timestamp;
        
    }
    void loadTransaction(string accountID)
    {
        Debug.Log("We are at loading");
        foreach (Transaction transaction in Repository.transactions.transactions)
        {
            Debug.Log(transaction.accountUUID);
            if(transaction.accountUUID == accountID)
            {
                Debug.Log("YES");
                addTransaction(transaction);            
            }
        }
        Debug.Log("Finished");
    }

    void Start()
    {
        Debug.Log("Start");
        start();
        loadTransaction("69395148");
    }
}
