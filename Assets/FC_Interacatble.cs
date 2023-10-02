using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class FC_Interacatble : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject core;
    public bool isColliding = false;
    // Start is called before the first frame update
    List<GameObject> cores;

    double position_x;
    double position_y;
    double position_z;

    Vector3 corePosition;

    void Start()
    {
         //audioSource = GetComponent<AudioSource>();
        cores =  new List<GameObject>();
        position_x = -1.018;
        position_y = 1.029;
        position_z = -0.939;
        corePosition = new Vector3(-1.018f,1.039f,-0.939f);
    }

    void OnCollisionEnter(Collision collision)
    {

        if(isColliding == false)
        {
            // Debug.Log(collision.gameObject.name);

            if(collision.gameObject.name == "HandColliderLeft(Clone)" || collision.gameObject.name == "HandColliderRight(Clone)")
            {
                isColliding = true;
                /*if(audioSource.isPlaying == false)
                audioSource.Play();*/

            }
        }
       
       

        
    }

    public bool isCollidingFunction()
    {
        // Debug.Log("FC COLINGIND----------");
         return isColliding;
    }

    public bool generateCore()
    {
        
        cores.Add(GameObject.Instantiate(core,corePosition,new Quaternion(0.0f,0.0f,0.0f,0.0f)));
        return true;
    }

    void OnCollisionExit(Collision collision)
    {
       isColliding = false;
    }
}
