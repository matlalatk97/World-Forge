using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BreakCrystal : MonoBehaviour
{
    // Start is called before the first frame update
    bool isCurrentlyColliding;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCurrentlyColliding) {
            Debug.Log("Colliding");
        }
    }

    void OnCollisonEnter(Collision col)
    {
        isCurrentlyColliding = true;
        Debug.Log("isCurrentlyColliding" + isCurrentlyColliding);
        if(col.gameObject.name == "Prop_Core")
        {
             Debug.Log("Colliding Mineral");
            Destroy(this);
        }
    }

    void OnCollisionExit(Collision col) {
        isCurrentlyColliding = false;
    }
}
