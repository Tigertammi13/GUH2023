using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Account
{
    [field: SerializeField] public string creditScore;
    [field: SerializeField] public string firstname;
    [field: SerializeField] public string liveBalance;
    [field: SerializeField] public string lastname;
    [field: SerializeField] public string accountId;
    [field: SerializeField] public string phoneNumber;
    [field: SerializeField] public string developerId;
    [field: SerializeField] public float balance;
    [field: SerializeField] public float creditLimit;
    [field: SerializeField] public string uci;
    [field: SerializeField] public int riskScore;
    [field: SerializeField] public string state;
    [field: SerializeField] public string currencyCode;
    [field: SerializeField] public string productType;
    [field: SerializeField] public string email;
    [field: SerializeField] public string homeAddress;
}

