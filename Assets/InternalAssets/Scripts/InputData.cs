using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputData : MonoBehaviour
{
    public static InputData Instance { get; private set; }

    public IStoreModel[] StoreModels { get; private set; }
    public IWallet CurrencyWallet { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        CurrencyWallet = Wallet.Instance as IWallet;
        StoreModels = StoreModelFiller.Instance.GetStoreModels();
    }
}
