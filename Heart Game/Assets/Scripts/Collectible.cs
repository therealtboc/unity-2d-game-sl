﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HandleCollected();
    }
    void HandleCollected()
    {
        //print("Handle the pickup");
        CollectibleManager.Instance.HandleHeartCollected();
        Destroy(gameObject);
    }
}
