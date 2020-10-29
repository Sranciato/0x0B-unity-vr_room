using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class detects if projector can turn on or not
public class ProjectorInteraction : MonoBehaviour
{
    public GameObject particles;
    public GameManager gameManager;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Hand" && gameManager.countForItemsOnBoard == 4)
        {
            particles.SetActive(true);
        }
    }
}
