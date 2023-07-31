using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CloseButtonUI : MonoBehaviour
{
    [SerializeField] private Button overlayButton;
    [SerializeField] private GameObject windowGameObject;

    private void Awake()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(CloseWindow);
        overlayButton.onClick.AddListener(CloseWindow);
    }

    private void CloseWindow()
    {
        windowGameObject.SetActive(false);
    }
}
