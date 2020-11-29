using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttableObject : MonoBehaviour
{
    public delegate void ObjectDestroyedHandler(bool harmful);
    public event ObjectDestroyedHandler OnDestroyed;

    public bool harmful;


    void OnCollisionEnter2D(Collision2D collision)
    {
        // Identify if the object is being cut
        if (collision.gameObject.tag == "Cut")
        {
            if (OnDestroyed != null)
            {
                OnDestroyed(harmful);
            }

            Destroy(gameObject);
        }
    }
}
