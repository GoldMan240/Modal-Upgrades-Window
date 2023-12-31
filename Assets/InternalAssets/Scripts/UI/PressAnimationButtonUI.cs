using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class PressAnimationButtonUI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private const int MULTIPLIER_TO_CONVERT = -1;

    [SerializeField] private RectTransform contentContainer;

    private Button button;
    private float originalTopOffset;
    private float originalBottomOffset;

    private void Awake()
    {
        button = GetComponent<Button>();
        originalTopOffset = contentContainer.offsetMax.y;
        originalBottomOffset = contentContainer.offsetMin.y;
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        float convertedOriginalTopOffset = originalTopOffset * MULTIPLIER_TO_CONVERT;
        float convertedOriginalBottomOffset = originalBottomOffset * MULTIPLIER_TO_CONVERT;
        ChangeOffset(convertedOriginalTopOffset, convertedOriginalBottomOffset);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ChangeOffset(originalTopOffset, originalBottomOffset);
    }

    private void ChangeOffset(float topOffset, float bottomOffset)
    {
        if (button.interactable)
        {
            contentContainer.offsetMax = new Vector2(contentContainer.offsetMax.x, topOffset);
            contentContainer.offsetMin = new Vector2(contentContainer.offsetMin.x, bottomOffset);
        }
    }
}
