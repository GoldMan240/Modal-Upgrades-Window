using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class UpgradeStoreButtonUI : MonoBehaviour
{
    [SerializeField] private GameObject upgradeWindowContainerGamaeObject;

    private void Awake()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            upgradeWindowContainerGamaeObject.SetActive(true);
        });
    }
}
