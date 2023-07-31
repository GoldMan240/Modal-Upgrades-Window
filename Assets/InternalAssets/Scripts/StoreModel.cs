using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreModel : IStoreModel
{
    public Sprite Image { get ; set ; }
    public string Title { get ; set ; }
    public string Description { get; set; }
    public float Price { get; set; }
}
