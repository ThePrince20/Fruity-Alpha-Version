using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public delegate void ObjectSpawnedHandler(CuttableObject obj);
    public event ObjectSpawnedHandler OnObjectSpawned;
    
    // Object to spawn
    public GameObject prefab;

    // Waiting time to spawn
    public float interval;
    // Minimum value to the left
    public float minimumX;
    public float maximumX;
    // vertical position where object is to be spawned
    public float y;

    // Sprite array
    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        // Call repeated times
        InvokeRepeating("Spawn", interval, interval);
    }

    private void Spawn()
    {
        // Instantiate and position the object
        GameObject instance = Instantiate(prefab);
        instance.transform.position = new Vector2(
            Random.Range(minimumX, maximumX), y
            );

        instance.transform.SetParent(transform);

        if (OnObjectSpawned != null)
        {
            OnObjectSpawned(instance.GetComponent<CuttableObject>());
        }

        // Set a random sprite
        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        instance.GetComponent<SpriteRenderer>().sprite = randomSprite;
    }
}
