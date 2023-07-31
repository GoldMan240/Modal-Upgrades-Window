using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour, IWallet
{
    public event Action OnMoneyChanged;
    public static Wallet Instance { get; private set; }

    private float moneyCounter = 100;

    private void Awake()
    {
        Instance = this;
    }

    public void RemoveMoney(float moneyAmount)
    {
        moneyCounter -= moneyAmount;

        OnMoneyChanged?.Invoke();

        if (moneyCounter < 0)
        {
            moneyCounter = 0;

            Debug.LogWarning($"Попытка вычесть {moneyAmount} из {moneyCounter}! Счетчик валюты обнулен.");
        }
    }

    public float GetMoneyAmount()
    {
        return moneyCounter;
    }
}
