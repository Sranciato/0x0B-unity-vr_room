using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Defines if chess pieces have or have not been found
public class FoundPieces : MonoBehaviour
{
    public GameManager gameManager;
    private bool foundPawn, foundBishop, foundRook, foundKnight;

    // Called when there is a collision between gameobjects
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pawn" && !foundPawn)
        {
            gameManager.countForItemsOnBoard += 1;
            foundPawn = true;
            Debug.Log("FOUND PAWN");
        }
        if (collision.gameObject.tag == "Bishop" && !foundBishop)
        {
            gameManager.countForItemsOnBoard += 1;
            foundBishop = true;
            Debug.Log("FOUND PAWN");
        }
        if (collision.gameObject.tag == "Rook" && !foundRook)
        {
            gameManager.countForItemsOnBoard += 1;
            foundRook = true;
            Debug.Log("FOUND PAWN");
        }
        if (collision.gameObject.tag == "Knight" && !foundKnight)
        {
            gameManager.countForItemsOnBoard += 1;
            foundKnight = true;
            Debug.Log("FOUND PAWN");
        }
    }
}
