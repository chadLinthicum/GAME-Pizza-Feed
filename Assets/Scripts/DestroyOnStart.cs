using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnStart : MonoBehaviour
{
    public bool Hidden = true;
    // Start is called before the first frame update
    void Start()
    {
        if (Hidden)
        {
            Destroy(gameObject);

        } 
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
