using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    public GameManager gameManager;
    private bool alreadyInteractedWith = false;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Hand" && !alreadyInteractedWith)
        {
            gameManager.countForGrabbedItems += 1;
            alreadyInteractedWith = true;
        }
    }
}
