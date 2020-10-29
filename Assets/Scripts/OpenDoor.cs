using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class detects if door can open or not
public class OpenDoor : MonoBehaviour
{
    public Animator animator;
    public GameManager gameManager;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player" && gameManager.countForGrabbedItems == 2)
            animator.SetBool("character_nearby", true);
    }
}
