using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        // Positions projectile at mid-section and in front of Player 
        //transform.Translate(Vector3.up * Time.deltaTime * 150);
        //transform.Translate(Vector3.forward * Time.deltaTime * 200);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
