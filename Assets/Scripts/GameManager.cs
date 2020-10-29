using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class for managing gameobject interactions
public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public int countForGrabbedItems = 0;
    [HideInInspector]
    public int countForItemsOnBoard = 0;

    // public function for adding count of interactions 
    public void AddCount()
    {
        countForGrabbedItems += 1;
    }
    // public function for getting the count of interactions
    public int GetCount()
    {
        return countForGrabbedItems;
    }
}
