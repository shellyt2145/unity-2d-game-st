using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        handlecollected();
        

    }
    void handlecollected()
    {
        CollectibleManager.Instance.handledankweedcollected();

        print("420 Blaze it");
        Destroy(gameObject);

    }
}
