using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeItemSpawner : MonoBehaviour
{
    [SerializeField] private GameObject storeModelPrefab;

    private void Start()
    {
        IStoreModel[] storeModels = InputData.Instance.StoreModels;

        for (int i = 0; i < storeModels.Length; i++)
        {
            UpgradeItemUI upgradeItem = Instantiate(storeModelPrefab, gameObject.transform).GetComponent<UpgradeItemUI>();
            upgradeItem.Setup(storeModels[i]);
        }
    }
}
