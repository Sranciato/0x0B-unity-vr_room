using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public int countForGrabbedItems = 0;
    [HideInInspector]
    public int countForItemsOnBoard = 0;

    public void AddCount()
    {
        countForGrabbedItems += 1;
    }
    public int GetCount()
    {
        return countForGrabbedItems;
    }
}
