using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float bottomBound = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players view in the game, remove that object. 
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER!");
        }
    }
}
