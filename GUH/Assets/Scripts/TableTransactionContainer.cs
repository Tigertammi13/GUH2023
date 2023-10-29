using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TableTransactionContainer: MonoBehaviour
{
    // Start is called before the first frame update
    int number;
    List<TextMeshPro> textProList;
   
    void start()
    {
        Repository.loadData();
        textProList = new List<TextMeshPro>();
        number = 0;
        
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

    void addTransaction(Transaction transaction) {
        TextMeshPro tmp=new TextMeshPro();
        tmp.text = transaction.merchant.name + ' ' + transaction.amount + " " + transaction.currency + " " + transaction.timestamp;
        textProList.Add(tmp);
    }
    void loadTransaction(string accountID)
    {
        foreach (Transaction transaction in Repository.transactions)
        {
            if(transaction.accountUUID == accountID)
            {
                addTransaction(transaction);            }
        }
    }
}
