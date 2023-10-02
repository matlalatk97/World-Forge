//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: This object will get hover events and can be attached to the hands
//
//=============================================================================

using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

namespace Valve.VR.InteractionSystem
{
    //-------------------------------------------------------------------------
    public class Interactable_Core : MonoBehaviour
    {
        public Interactable CoreScript;
       void Start(){

       }

       void OnCollisionEnter(Collision col)
       {
            Debug.Log(col.gameObject.name);
            Debug.Log("Game Object is held : " + CoreScript.isHeld());
       }

    }
}
