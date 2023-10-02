using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class FC_Interactable : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject core;
    public bool isColliding = false;
    // Start is called before the first frame update
    List<GameObject> cores;

    void Start()
    {
         //audioSource = GetComponent<AudioSource>();
        cores =  new List<GameObject>();
    }

    void OnCollisionEnter(Collision collision)
    {

        if(isColliding == false)
        {
             Debug.Log(collision.gameObject.name);

            if(collision.gameObject.name == "HandColliderLeft(Clone)" || collision.gameObject.name == "HandColliderRight(Clone)")
            {
                isColliding = true;
                if(audioSource.isPlaying == false)
                audioSource.Play();

            }
        }
       
       

        
    }

    public bool generateCore()
    {
        cores.Add(GameObject.Instantiate(core));
        return true;
    }

    void OnCollisionExit(Collision collision)
    {
       isColliding = false;
    }
}
