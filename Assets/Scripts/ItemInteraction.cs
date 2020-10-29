using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class for determining hand interactions
public class ItemInteraction : MonoBehaviour
{
    public GameManager gameManager;
    private bool alreadyInteractedWith = false;

    // Called when a collider passes through a gameobject
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Hand" && !alreadyInteractedWith)
        {
            gameManager.countForGrabbedItems += 1;
            alreadyInteractedWith = true;
        }
    }
}
