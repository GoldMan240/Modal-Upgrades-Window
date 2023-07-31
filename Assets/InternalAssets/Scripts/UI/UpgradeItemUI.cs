using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeItemUI : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI descriptionText;
    [SerializeField] private TextMeshProUGUI priceText;
    [SerializeField] private Button button;

    private IWallet wallet;
    private float price;

    public void Setup(IStoreModel storeModel)
    {
        this.iconImage.sprite = storeModel.Image;
        this.titleText.text = storeModel.Title;
        this.descriptionText.text = storeModel.Description;
        this.priceText.text = storeModel.Price + "T";
        price = storeModel.Price;

        UpdateButton();
    }

    private void Start()
    {
        wallet = InputData.Instance.CurrencyWallet;
        wallet.OnMoneyChanged += Wallet_OnMoneyChanged;

        button.onClick.AddListener(() =>
        {
            Destroy(gameObject);
            wallet.RemoveMoney(price);
        });
    }

    private void OnDisable()
    {
        wallet.OnMoneyChanged -= Wallet_OnMoneyChanged;
    }

    private void Wallet_OnMoneyChanged()
    {
        UpdateButton();
    }

    private void UpdateButton()
    {
        if (wallet == null)
        {
            wallet = InputData.Instance.CurrencyWallet;
        }
        float moneyAmount = wallet.GetMoneyAmount();
        
        if (moneyAmount < price)
        {
            button.interactable = false;
            priceText.color = Color.red;
        }
    }
}
