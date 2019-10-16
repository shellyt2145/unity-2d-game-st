using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class Collectible : MonoBehaviour
{

    private bool _hasBeenCollected = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (!_hasBeenCollected && collision.gameObject.GetComponent<PlatformerCharacter2D>())
        {
            handlecollected();

        }

    }
    void handlecollected()
    {
        CollectibleManager.Instance.Handledankweedcollected();

        _hasBeenCollected = true;
        print("420 Blaze it");
        Destroy(gameObject);
    }
}
