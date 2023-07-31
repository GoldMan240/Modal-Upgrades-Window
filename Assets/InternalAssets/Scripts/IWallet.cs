using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWallet
{
    event Action OnMoneyChanged;
    float GetMoneyAmount();
    void RemoveMoney(float moneyAmount);
}
