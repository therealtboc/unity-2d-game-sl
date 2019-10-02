using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Collectible : MonoBehaviour
{

    private bool _hasBeenCollected = false;

    //This trigger handles logic for a collision with the Collider2D object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //This if statment checks if the collision comes from the player character (PlatformerCharacter2D) AND if the collectible boolean hasn't been switched to true yet
        if (!_hasBeenCollected && collision.gameObject.GetComponent<PlatformerCharacter2D>()) 
        {
            //By calling this function, a collision will destroy the instance of the collided object that is associated with a Collectible.cs script
            HandleCollected();
        }
    }

    //This function destroys the instance of collectible
    void HandleCollected()
    {
        _hasBeenCollected = true;                               //Setting this boolean to true sets this as "collected"
        //print("Handle the pickup");
        CollectibleManager.Instance.HandleHeartCollected();
        Destroy(gameObject);
    }
}
