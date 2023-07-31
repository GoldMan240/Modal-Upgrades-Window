using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreModelFiller : MonoBehaviour
{
    public static StoreModelFiller Instance { get; private set; }

    [SerializeField] private UpgradeItemSO[] storeModelsSO;

    private IStoreModel[] storeModels;

    private void Awake()
    {
        Instance = this;

        UpgradeItemSO[] sortedStoreModelsSO = new UpgradeItemSO[storeModelsSO.Length];


        storeModels = new IStoreModel[storeModelsSO.Length];

        for (int i = 0; i < storeModelsSO.Length; i++)
        {
            StoreModel storeModel = new StoreModel
            {
                Image = storeModelsSO[i].image,
                Title = storeModelsSO[i].title,
                Description = storeModelsSO[i].description,
                Price = storeModelsSO[i].price,
            };

            storeModels[i] = storeModel;
        }
    }

    public IStoreModel[] GetStoreModels()
    {
        return storeModels;
    }
}
