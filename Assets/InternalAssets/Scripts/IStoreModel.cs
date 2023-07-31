using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStoreModel
{
    Sprite Image { get; }
    string Title { get; }
    string Description { get; }
    float Price { get; }
}
