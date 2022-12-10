using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 30.0f;
    private float bottomBoundary = -10.0f;
    private float horizontalBoundary = 22.0f;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes out of bounds in the game, remove that object. 
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBoundary || transform.position.x < -horizontalBoundary || transform.position.x > horizontalBoundary)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER!");
        }
    }
}
