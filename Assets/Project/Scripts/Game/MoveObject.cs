using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Speed variables
    public float minimumXSpeed;
    public float maximumXSpeed;
    public float minimumYSpeed;
    public float maximumYSpeed;

    // Gameplay variables
    public float lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        // Throw object upwards
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(
            Random.Range(minimumXSpeed, maximumXSpeed),
            Random.Range(minimumYSpeed, maximumYSpeed)
            );
        // Wait and destroy
        Destroy(gameObject, lifeTime);
    }
}
