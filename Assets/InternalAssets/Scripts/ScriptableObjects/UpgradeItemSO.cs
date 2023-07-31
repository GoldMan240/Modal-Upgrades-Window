using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class UpgradeItemSO : ScriptableObject
{
    public Sprite image;
    public string title;
    public string description;
    public int price;
}
